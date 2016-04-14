using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmNotas : Form
    {

        #region VARIABLES
        DataTable lNotas;
        NotasCL oNotas = new NotasCL();


        #endregion

        public frmNotas()
        {
            InitializeComponent();
            cargarNotas();
        }

        public void LimpiarCajas()
        {
            textBoxNota.Text = string.Empty;
            textBoxNota.Enabled = false;
            btnNuevaNota.Enabled = true;
            btnGuardar.Tag = "Crear";
        }

        public void nuevaNota()
        {
            textBoxNota.Text = string.Empty;
            textBoxNota.Enabled = true;

        }

        public void cargarNotas()
        {

            // TRAE LOS ABONOS DE CUOTAS Y LOS GUARDA EN DATATABLE
            DataTable oTable = oNotas.TraerNotas(0).Tables[0];

            listViewNotas.Clear();

            lNotas = oTable;


            //CICLO QUE RECORRE LOS ROWS
            foreach (DataRow item in oTable.Rows)
            {
                // CREAR UN GRUPO 
                ListViewGroup grupo = new ListViewGroup(item["fecha_creacion"].ToString());

                // CREAR UN ITEM DE GRUPO
                ListViewItem item_grupo = new ListViewItem("NOTA: " + item["nota"].ToString(), grupo);

                // AGREGAR EL GRUPO
                listViewNotas.Groups.Add(grupo);

                // AGREGAR EL ITEM
                listViewNotas.Items.Add(item_grupo);

            }


        }

        public void guardarNota()
        {

            if (!string.IsNullOrEmpty(textBoxNota.Text))
            {
                string nota = textBoxNota.Text;

                DateTime fecha = DateTime.Now;

                oNotas.InsertarNota(nota, fecha);

                if (oNotas.IsError)
                {
                    MessageBox.Show(oNotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Nota guardada con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarNotas();
                    LimpiarCajas();
                }
            }
            else
            {
                MessageBox.Show("Inserte alguna nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void editarNota()
        {

            if (!string.IsNullOrEmpty(textBoxNota.Text))
            {
                ListViewItem item = listViewNotas.SelectedItems[0];
                string nota = textBoxNota.Text;
                int id = int.Parse(lNotas.Rows[item.Index].ItemArray[0].ToString());
                DateTime fecha = DateTime.Now;

                oNotas.EditarNota(id, nota, fecha);

                if (oNotas.IsError)
                {
                    MessageBox.Show(oNotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Nota guardada con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarNotas();
                    LimpiarCajas();
                }
            }
            else
            {
                MessageBox.Show("Inserte algúna nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public void eliminarNota()
        {

            DialogResult opcion = MessageBox.Show("Desea eliminar la nota?", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            // ELIMINA NOTA SELECCIONADA
            if (opcion == DialogResult.OK)
            {

                ListViewItem item = listViewNotas.SelectedItems[0];

                int id = int.Parse(lNotas.Rows[item.Index].ItemArray[0].ToString());

                oNotas.EliminarNota(id);

                if (oNotas.IsError)
                {
                    MessageBox.Show(oNotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Nota eliminada con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarNotas();

                }

            }

        }

        public void mantenimiento(string opcion)
        {

            switch (opcion)
            {
                case "Crear":
                    guardarNota();
                    break;
                case "Editar":
                    editarNota();
                    break;
                case "Eliminar":
                    eliminarNota();
                    break;
                case "Nueva":
                    nuevaNota();
                    break;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string opcion = btnGuardar.Tag.ToString();

            if (opcion == "Crear")
            {
                mantenimiento(opcion);
            }
            else if (opcion == "Editar")
            {
                mantenimiento(opcion);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            mantenimiento("Nueva");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento("Eliminar");
        }

        private void MenuNotas_Opening(object sender, CancelEventArgs e)
        {
            if (listViewNotas.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewNotas.SelectedItems[0];

            string nota = lNotas.Rows[item.Index].ItemArray[1].ToString();

            textBoxNota.Text = nota;
            textBoxNota.Enabled = true;
            btnNuevaNota.Enabled = false;
            btnGuardar.Tag = "Editar";

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
    }
}
