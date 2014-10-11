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

    public partial class frmListaUsuarios : Form
    {
        frmUsuarios usuarios;


        public frmListaUsuarios(frmUsuarios Usuarios)
        {
            InitializeComponent();
            usuarios = Usuarios;
            CargarUsuarios();

        }


        public void CargarUsuarios()
        {

            UsuariosCL oUsuarios = new UsuariosCL();

            DataSet oDatos = oUsuarios.TraerUsuarios("");

            dtgUsuarios.DataSource = oDatos.Tables[0];

        }

        public void BuscarUsuarios()
        {
            try
            {
                foreach (DataGridViewRow row in dtgUsuarios.Rows)
                {

                    if (row.Cells[0].Value.ToString().Contains(txtBusqueda.Text) ||
                        row.Cells[1].Value.ToString().Contains(txtBusqueda.Text)
                        )
                    {



                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            BuscarUsuarios();
        }

        private void dtgUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            if (usuarios != null)
            {
                usuarios.ActivarCajas(2);
                usuarios.txtCedula.Text = dtgUsuarios["Cedula", dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
                usuarios.txtNombre.Text = dtgUsuarios["Nombre", dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
                usuarios.txtUsuario.Text = dtgUsuarios["Usuario", dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
                usuarios.txtContrasena.Text = dtgUsuarios["Contraseña", dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
            
            }


        }

        private void frmListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuarios != null)
            {
                if (usuarios.txtCedula.Text == "")
                {
                    usuarios.DesactivarCajas();
                    usuarios.MenuAgregar.Enabled = true;
                    usuarios.MenuEditar.Enabled = true;
                }
            }


        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarUsuarios();
            }


        }


    }
}
