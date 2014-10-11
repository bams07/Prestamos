using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos.Logica;
using Prestamos.Datos;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmLogin : Form
    {

        ConfBD oBD = new ConfBD();

        public frmLogin()
        {



            Comprobar();

                InitializeComponent();

                

                
        }

        public void Comprobar()
        {
            if (!oBD.ExisteBD())
            {

                MessageBox.Show("La base de datos prestamo no existe");

                Environment.Exit(0);
            
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            UsuariosCL oUsarios = new UsuariosCL();

            DataSet oDatos = oUsarios.Login(txtUsuario.Text, txtContrasena.Text);

            if (oDatos.Tables[0].Rows.Count > 0)
            {
                frmDashBoard oDashboard = new frmDashBoard();
                oDashboard.Show();
                this.Hide();

            }
            else
            {

               MessageBox.Show("Usuario o contraseña inconrrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
