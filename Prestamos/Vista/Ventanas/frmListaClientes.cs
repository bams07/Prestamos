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

    public partial class frmListaClientes : Form
    {
        frmClientes clientes;
        frmPrestamos prestamos;
        frmAbonos abonos;
        frmRFiltroCuentaCobrar filtroPrestamos;
        frmRFiltroEstadoCuenta filtroPrestamos_Cuotas;
        DataTable datosClientes;


        public frmListaClientes(frmClientes Clientes)
        {
            InitializeComponent();
            clientes = Clientes;
            CargarClientes();

        }

        public frmListaClientes(frmPrestamos Prestamos)
        {
            InitializeComponent();
            prestamos = Prestamos;
            CargarClientes();
        }

        public frmListaClientes(frmAbonos Abonos)
        {
            InitializeComponent();
            abonos = Abonos;
            CargarClientes();

        }

        public frmListaClientes(frmRFiltroCuentaCobrar filtro)
        {
            InitializeComponent();
            filtroPrestamos = filtro;
            CargarClientes();
        }

        public frmListaClientes(frmRFiltroEstadoCuenta filtro)
        {
            InitializeComponent();
            filtroPrestamos_Cuotas = filtro;
            CargarClientes();
        }

        public void CargarClientes()
        {

            ClientesCL oClientes = new ClientesCL();

            DataSet oDatos = oClientes.TraerClientes("");

            dtgClientes.DataSource = oDatos.Tables[0];

            datosClientes = oDatos.Tables[0];

        }

        public void BuscarClientes()
        {

            // Realiza un consulta con LINQ busca por cedula y por nombre
            var datos = from item in datosClientes.AsEnumerable()
                        where item.Field<string>("cedula").ToUpper().Contains(txtBusqueda.Text.ToUpper()) ||
                         item.Field<string>("nombre").ToUpper().Contains(txtBusqueda.Text.ToUpper())
                        select item;

            // Si hay valores asociados a esa busqueda los muetra si no muestra alerta
            if (datos.Count() > 0)
            {
                dtgClientes.DataSource = datos.CopyToDataTable();
            }
            else
            {
                MessageBox.Show("No hay informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            BuscarClientes();
        }

        private void dtgClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            if (clientes != null)
            {
                this.clientes.ActivarCajas(2);
                this.clientes.txtCedula.Text = this.dtgClientes["Cedula", this.dtgClientes.CurrentCell.RowIndex].Value.ToString();
                this.clientes.txtNombre.Text = this.dtgClientes["Nombre", this.dtgClientes.CurrentCell.RowIndex].Value.ToString();
                this.clientes.txtTelefono.Text = this.dtgClientes["Telefono", this.dtgClientes.CurrentCell.RowIndex].Value.ToString();
                this.clientes.txtCelular.Text = this.dtgClientes["Celular", this.dtgClientes.CurrentCell.RowIndex].Value.ToString();
                this.clientes.txtDireccion.Text = this.dtgClientes["Direccion", this.dtgClientes.CurrentCell.RowIndex].Value.ToString();
                this.clientes.ckMoroso.Checked = Convert.ToBoolean(this.dtgClientes["Moroso", this.dtgClientes.CurrentCell.RowIndex].Value.ToString());

            }

            if (prestamos != null)
            {

                prestamos.txtCliente.Text = dtgClientes["Cedula", dtgClientes.CurrentCell.RowIndex].Value.ToString();
                prestamos.CargarClientes();
                prestamos.CargarPrestamos();

            }

            if (abonos != null)
            {

                abonos.txtCliente.Text = dtgClientes["Cedula", dtgClientes.CurrentCell.RowIndex].Value.ToString();
                abonos.CargarClientes();
                abonos.CargarPrestamos();

            }

            if (filtroPrestamos != null)
            {

                filtroPrestamos.txtCliente.Text = dtgClientes["Cedula", dtgClientes.CurrentCell.RowIndex].Value.ToString();
                filtroPrestamos.ComprobarPrestamos();
            }

            if (filtroPrestamos_Cuotas != null)
            {

                filtroPrestamos_Cuotas.txtCliente.Text = dtgClientes["Cedula", dtgClientes.CurrentCell.RowIndex].Value.ToString();
                filtroPrestamos_Cuotas.ComprobarPrestamos();
            }

        }

        private void frmListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientes != null)
            {
                if (clientes.txtCedula.Text == "")
                {
                    clientes.DesactivarCajas();
                    clientes.MenuAgregar.Enabled = true;
                    clientes.MenuEditar.Enabled = true;
                    clientes.btnFiadores.Enabled = false;
                }
            }


        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarClientes();
            }


        }


    }
}
