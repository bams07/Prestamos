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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        public void ActivarCajas(int opcion)
        {
            if (opcion == 1)
            {
                this.txtCedula.Enabled = true;
                this.txtDireccion.Enabled = true;
                this.txtNombre.Enabled = true;
                this.txtTelefono.Enabled = true;
                this.txtCelular.Enabled = true;
                this.ckMoroso.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            if (opcion == 2)
            {
                this.txtCedula.Enabled = false;
                this.txtDireccion.Enabled = true;
                this.txtNombre.Enabled = true;
                this.txtTelefono.Enabled = true;
                this.txtCelular.Enabled = true;
                this.ckMoroso.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnFiadores.Enabled = true;
            }
        }
        public void DesactivarCajas()
        {
            this.txtCedula.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtCelular.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Tag = "1";
            this.btnCancelar.Enabled = false;
            this.btnFiadores.Enabled = false;
            this.ckMoroso.Enabled = false;
            this.txtCedula.Clear();
            this.txtDireccion.Clear();
            this.txtNombre.Clear();
            this.txtTelefono.Clear();
            this.txtCelular.Clear();
            this.ckMoroso.Checked = false;
            this.Refresh();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCedula.Text) || string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Faltan campos que llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ClientesCL clientesCL = new ClientesCL();
                if (this.btnGuardar.Tag == "1")
                {
                    clientesCL.InsertarCliente(this.txtCedula.Text, this.txtNombre.Text, this.txtTelefono.Text, this.txtCelular.Text, this.txtDireccion.Text, this.ckMoroso.Checked);
                    if (clientesCL.IsError)
                    {
                        ErroresCl erroresCl = new ErroresCl();
                        string text = erroresCl.VentanaErrores(clientesCL.ErrorCode, "clientes");
                        MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("Cliente agregado: " + this.txtCedula.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.MenuAgregar.Enabled = true;
                        this.MenuEditar.Enabled = true;
                        this.DesactivarCajas();
                    }
                }
                else
                {
                    clientesCL.EditarCliente(this.txtCedula.Text, this.txtNombre.Text, this.txtTelefono.Text, this.txtCelular.Text, this.txtDireccion.Text, this.ckMoroso.Checked);
                    if (clientesCL.IsError)
                    {
                        ErroresCl erroresCl = new ErroresCl();
                        string text = erroresCl.VentanaErrores(clientesCL.ErrorCode, "clientes");
                        MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("Cliente editado: " + this.txtCedula.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.btnGuardar.Tag = "1";
                        this.MenuAgregar.Enabled = true;
                        this.MenuEditar.Enabled = true;
                        this.DesactivarCajas();
                    }
                }
            }
        }

        private void MenuAgregar_Click(object sender, EventArgs e)
        {
            this.ActivarCajas(1);
            this.MenuEditar.Enabled = false;
        }

        private void MenuEditar_Click(object sender, EventArgs e)
        {
            this.MenuAgregar.Enabled = false;
            frmListaClientes frmListaClientes = new frmListaClientes(this);
            this.btnGuardar.Tag = "0";
            frmListaClientes.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DesactivarCajas();
            this.MenuAgregar.Enabled = true;
            this.MenuEditar.Enabled = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCedula.Text))
            {
                ClientesCL clientesCL = new ClientesCL();
                clientesCL.EliminarCliente(this.txtCedula.Text);

                if (clientesCL.IsError)
                {
                    ErroresCl erroresCl = new ErroresCl();
                    string text = erroresCl.VentanaErrores(clientesCL.ErrorCode, "clientes");
                    MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.btnGuardar.Tag = "1";
                    this.MenuAgregar.Enabled = true;
                    this.MenuEditar.Enabled = true;
                    this.DesactivarCajas();
                }
                else
                {
                    MessageBox.Show("Cliente elimado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.btnGuardar.Tag = "1";
                    this.MenuAgregar.Enabled = true;
                    this.MenuEditar.Enabled = true;
                    this.DesactivarCajas();
                }
            }
            else
            {
                MessageBox.Show("Cedula invalida para eliminar, debes elegir algun cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnFiadores_Click(object sender, EventArgs e)
        {
            if (!MenuAgregar.Enabled || !string.IsNullOrEmpty(txtCedula.Text))
            {
                frmFiadores oFiadores = new frmFiadores(this);
                oFiadores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un cliente antes de ver sus fiadores", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }




    }
}
