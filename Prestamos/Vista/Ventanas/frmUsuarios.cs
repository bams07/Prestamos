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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }


        public void ActivarCajas(int opcion)
        {
            if (opcion == 1)
            {
                txtCedula.Enabled = true;
                txtUsuario.Enabled = true;
                txtNombre.Enabled = true;
                txtContrasena.Enabled = true;
                txtUsuario.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (opcion == 2)
            {
                txtCedula.Enabled = false;
                txtUsuario.Enabled = true;
                txtNombre.Enabled = true;
                txtUsuario.Enabled = true;
                txtContrasena.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        public void DesactivarCajas()
        {

            txtCedula.Enabled = false;
            txtUsuario.Enabled = false;
            txtNombre.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            btnGuardar.Enabled = false;
            btnGuardar.Tag = "1";
            btnCancelar.Enabled = false;



            txtCedula.Clear();
            txtUsuario.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();

            this.Refresh();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCedula.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtUsuario.Text) ||
                string.IsNullOrEmpty(txtContrasena.Text))
            {

                MessageBox.Show("Faltan campos que llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                UsuariosCL oUsuarios = new UsuariosCL();

                if (btnGuardar.Tag == "1")
                {


                    oUsuarios.InsertarUsuario(txtCedula.Text, txtNombre.Text, txtUsuario.Text, txtContrasena.Text);

                    if (oUsuarios.IsError)
                    {

                        MessageBox.Show(oUsuarios.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        MessageBox.Show("Usuario agregado: " + txtCedula.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuAgregar.Enabled = true;
                        MenuEditar.Enabled = true;
                        DesactivarCajas();
                    }
                }
                else
                {
                    oUsuarios.EditarUsuario(txtCedula.Text, txtNombre.Text, txtUsuario.Text, txtContrasena.Text);

                    if (oUsuarios.IsError)
                    {
                        MessageBox.Show(oUsuarios.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario editado: " + txtCedula.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Tag = "1";
                        MenuAgregar.Enabled = true;
                        MenuEditar.Enabled = true;
                        DesactivarCajas();
                    }

                }
            }
        }

        private void MenuAgregar_Click(object sender, EventArgs e)
        {
            ActivarCajas(1);
            MenuEditar.Enabled = false;
        }

        private void MenuEditar_Click(object sender, EventArgs e)
        {
            MenuAgregar.Enabled = false;
            frmListaUsuarios oListaUsuarios = new frmListaUsuarios(this);
            btnGuardar.Tag = "0";
            oListaUsuarios.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesactivarCajas();
            MenuAgregar.Enabled = true;
            MenuEditar.Enabled = true;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
