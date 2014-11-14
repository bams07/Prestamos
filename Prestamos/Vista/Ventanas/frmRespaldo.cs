using System;
using System.Threading;
using System.Threading.Tasks;
using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmRespaldo : Form
    {
        public frmRespaldo()
        {
            InitializeComponent();

            CargarConfiguracion();

        }


        public void CargarConfiguracion()
        {
            RespaldoCL oRespaldo = new RespaldoCL();

            DataSet oDatos = oRespaldo.TraerConfiguracion();

            if (oDatos.Tables[0].Rows.Count > 0)
            {

                txtDireccionPostgre.Text = oDatos.Tables[0].Rows[0].ItemArray[1].ToString();
                txtClienteID.Text = oDatos.Tables[0].Rows[0].ItemArray[2].ToString();
                txtClienSecret.Text = oDatos.Tables[0].Rows[0].ItemArray[3].ToString();

            }
            else
            {

                MessageBox.Show("Compruebe la configuración antes de respaldar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedTab = tabPage2;


            }
        }


        // METODO PARA RESPALDAR EN GOOGLE DRIVE
        public void GDrive(string archivo, string nombre)
        {


            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = txtClienteID.Text,
                    ClientSecret = txtClienSecret.Text,
                },
                new[] { DriveService.Scope.Drive },
                "user",
                CancellationToken.None).Result;

            // CREA EL SERVICIO
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Sample",
            });

            Google.Apis.Drive.v2.Data.File body = new Google.Apis.Drive.v2.Data.File();
            body.Title = nombre;
            body.Description = "Respaldo base datos prestamos";
            body.MimeType = "application/octet-stream";



            byte[] byteArray = System.IO.File.ReadAllBytes(archivo);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);


            FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, " application/octet-stream");
            request.Upload();


            Google.Apis.Drive.v2.Data.File file = request.ResponseBody;
            Console.WriteLine("File id: " + file.Id);
            Console.WriteLine("Press Enter to end this process.");
            Console.ReadLine();


        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            SaveFileDialog oDireccion = new SaveFileDialog();
            oDireccion.Title = "Direccion de respaldo";
            oDireccion.Filter = "Backup File|*.backup";
            oDireccion.FilterIndex = 0;
            oDireccion.RestoreDirectory = true;

            string NombreRespaldo = "Prestamos-Respaldo(" + System.DateTime.Now.ToString("dd-MM-yyyy") + ")";

            oDireccion.FileName = NombreRespaldo;


            if (oDireccion.ShowDialog() == DialogResult.OK)
            {

                txtDireccion.Text = oDireccion.FileName;

                if (txtDireccion.Text != "")
                {

                    // CREA EL ARCHIVO BAT
                    StreamWriter sw = new StreamWriter("Respaldo.bat");

                    StringBuilder sb = new StringBuilder();

                    // AGREGAR LAS LINEAS AL ARCHIVO
                    sb.Append("cd " + txtDireccionPostgre.Text);
                    sb.Append("\nSET PGPASSWORD=123\n\npg_dump.exe --host localhost --port 5432 --username postgres --format custom --blobs --verbose --file ");
                    sb.Append("\"" + txtDireccion.Text + "\"");
                    sb.Append(" \"" + "Prestamos" + "\r\n\r\n");
                    sw.WriteLine(sb);
                    sw.Dispose();
                    sw.Close();


                    ProcessStartInfo startInfo = new ProcessStartInfo();

                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.FileName = "Respaldo.bat";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    // PROCESO DE ARCHIVO
                    using (Process proceso = Process.Start(startInfo))
                    {

                        proceso.WaitForExit();

                        if (proceso.HasExited)
                        {
                            MessageBox.Show(" Respaldo creado con exito ", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                   // GDrive(oDireccion.FileName, NombreRespaldo);


                }
                else
                {

                    MessageBox.Show("Debes selecionar un directorio y una ubicacion para poder realizar el respaldo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }



            }
            else
            {

                MessageBox.Show("Debes selecionar un directorio y una ubicacion para poder realizar el respaldo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }


        private void btnDireccionPostgre_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oDireccion = new FolderBrowserDialog();

            oDireccion.ShowDialog();

            string direccionPostgre = oDireccion.SelectedPath;

            txtDireccionPostgre.Text = direccionPostgre;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDireccionPostgre.Text) ||
                string.IsNullOrEmpty(txtClienteID.Text) ||
                string.IsNullOrEmpty(txtClienSecret.Text))
            {

                MessageBox.Show("Llene todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                RespaldoCL oRespaldo = new RespaldoCL();

                if (oRespaldo.TraerConfiguracion().Tables[0].Rows.Count > 0)
                {
                    oRespaldo.editarConfiguracion(1, txtDireccionPostgre.Text, txtClienteID.Text, txtClienSecret.Text);
                }
                else
                {

                    oRespaldo.insertarConfiguracion(1, txtDireccionPostgre.Text, txtClienteID.Text, txtClienSecret.Text);

                }

                if (oRespaldo.IsError)
                {

                    MessageBox.Show(oRespaldo.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    MessageBox.Show("Configuración de respaldo guardada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void ckGDrive_CheckStateChanged_1(object sender, EventArgs e)
        {
            if (ckGDrive.CheckState == CheckState.Checked)
            {

                txtClienSecret.Enabled = true;
                txtClienteID.Enabled = true;



            }

            if (ckGDrive.CheckState == CheckState.Unchecked)
            {
                txtClienSecret.Enabled = false;
                txtClienteID.Enabled = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }





    }
}
