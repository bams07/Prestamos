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

    public partial class frmFiadores : Form
    {
        // Variables globales
        FiadoresCL oFiadores;
        frmClientes clientes;
        DataTable datosClientes;

        // Variables
        string id;
        string cedula;
        string nombre;
        string telefono;
        string celular;
        string direccion;
        string cliente_cedula;
        string letra_cambio;


        public frmFiadores(frmClientes Clientes)
        {
            InitializeComponent();
            clientes = Clientes;
            CargarFiadores();

        }

        // Limpia las cajas de texto
        public void limpiarCajas()
        {
            this.txtCedula.Clear();
            this.txtDireccion.Clear();
            this.txtNombre.Clear();
            this.txtTelefono.Clear();
            this.txtCelular.Clear();
            this.txtLetraCambio.Clear();

            btnGuardar.Tag = "1";

        }

        public void guardarFiadores()
        {

            if (string.IsNullOrEmpty(this.txtCedula.Text) || string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Faltan campos que llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                // Variables
                cedula = txtCedula.Text;
                nombre = txtNombre.Text;
                telefono = txtTelefono.Text;
                celular = txtCelular.Text;
                direccion = txtDireccion.Text;
                cliente_cedula = clientes.txtCedula.Text;
                letra_cambio = txtLetraCambio.Text;

                // Instancia de fiadores
                oFiadores = new FiadoresCL();

                if (btnGuardar.Tag == "1")
                {
                    // Inserta los valores
                    oFiadores.insertarFiador(cliente_cedula, cedula, nombre, telefono, celular, direccion, letra_cambio);

                    if (oFiadores.IsError)
                    {

                        MessageBox.Show(oFiadores.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("Fiador agregado: " + cedula, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCajas();
                        CargarFiadores();

                    }
                }

                else if (btnGuardar.Tag == "0")
                {
                    oFiadores.editarFiador(id, cedula, nombre, telefono, celular, direccion, letra_cambio);

                    if (oFiadores.IsError)
                    {

                        MessageBox.Show(oFiadores.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("Fiador editado: " + cedula, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btnGuardar.Tag = "1";
                        limpiarCajas();
                        CargarFiadores();

                    }
                }


            }

        }


        // Carga los fiadores en la tabla
        public void CargarFiadores()
        {
            // Trae el valor del cliente para buscar los fiadores
            cliente_cedula = clientes.txtCedula.Text;

            oFiadores = new FiadoresCL();

            DataSet oDatos = oFiadores.traerFiadores(cliente_cedula);

            dtgFiadores.DataSource = oDatos.Tables[0];

            datosClientes = oDatos.Tables[0];

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarFiadores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Recorre la fila seleccionada
            foreach (DataGridViewRow item in dtgFiadores.SelectedRows)
            {
                // Variables
                id = item.Cells["ID"].Value.ToString();
                cedula = item.Cells["Cedula"].Value.ToString();
                nombre = item.Cells["Nombre"].Value.ToString();
                telefono = item.Cells["Telefono"].Value.ToString();
                celular = item.Cells["Celular"].Value.ToString();
                direccion = item.Cells["Direccion"].Value.ToString();
                cliente_cedula = item.Cells["Cliente_Cedula"].Value.ToString();
                letra_cambio = item.Cells["Letra_Cambio"].Value.ToString();
            }

            // Establece los valores
            txtCedula.Text = cedula;
            txtNombre.Text = nombre;
            txtTelefono.Text = telefono;
            txtCelular.Text = celular;
            txtDireccion.Text = direccion;
            txtLetraCambio.Text = letra_cambio;
            // Cambia el estado del boton para poder editar
            btnGuardar.Tag = "0";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Recorre la fila seleccionada
            foreach (DataGridViewRow item in dtgFiadores.SelectedRows)
            {
                id = item.Cells["ID"].Value.ToString();
                cedula = item.Cells["Cedula"].Value.ToString();
            }
            oFiadores = new FiadoresCL();

            oFiadores.eliminarFiador(id);

            if (oFiadores.IsError)
            {

                MessageBox.Show(oFiadores.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Fiador eliminado: " + cedula, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CargarFiadores();

            }


        }
    }
}
