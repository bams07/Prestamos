using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;


namespace Prestamos.Vista.Ventanas
{

    public partial class frmPrestamos : Form
    {

        string cliente;
        string nombre;
        private double totalPrestamoMonto;
        private double totalPrestamoGanancia;
        private double totalPrestamoSaldos;
        private double totalPrestamoRecargos;

        public frmPrestamos()
        {
            InitializeComponent();
        }

        public NumberFormatInfo Moneda()
        {
            NumberFormatInfo moneda = new CultureInfo(ConfigurationManager.AppSettings["DefaultCulture"], false).NumberFormat;

            return moneda;
        }

        public string getBusquedaCliente()
        {
            return txtCliente.Text;
        }

        public bool getMostrarRecargos()
        {
            return ckRecargos.Checked;
        }

        public bool getMostrarEliminados()
        {
            return ckBoxMostrarEliminados.Checked;
        }

        public void CargarClientes()
        {

            ClientesCL oClientes = new ClientesCL();

            DataSet oDatos = oClientes.TraerClientes(txtCliente.Text);


            if (oDatos.Tables[0].Rows.Count == 0)
            {

                MessageBox.Show("Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cliente = null;
            }
            else
            {
                cliente = oDatos.Tables[0].Rows[0].ItemArray[0].ToString();
                nombre = oDatos.Tables[0].Rows[0].ItemArray[1].ToString();
                lblDescripcion.Text = oDatos.Tables[0].Rows[0].ItemArray[1].ToString();
                lblDescripcion.Visible = true;
            }



        }

        public void CargarPrestamos()
        {
            DataSet oDatos;
            PrestamosCL oPrestamos = new PrestamosCL();
            string busquedaCliente = getBusquedaCliente();
            bool mostrarRecargos = getMostrarRecargos();
            bool mostrarEliminados = getMostrarEliminados();

            totalPrestamoMonto = 0000000;
            totalPrestamoGanancia = 0000000;
            totalPrestamoSaldos = 0000000;
            totalPrestamoRecargos = 0000000;

            oDatos = oPrestamos.TraerPrestamo(busquedaCliente, mostrarRecargos, mostrarEliminados);

            if (cliente != null)
            {
                // NUEVA COLUMNA 
                oDatos.Tables[0].Columns.Add("montoRecargo");

                foreach (DataRow row in oDatos.Tables[0].Rows)
                {
                    // MONTO
                    totalPrestamoMonto += Convert.ToDouble(row.ItemArray[2]);
                    // MONTO * INTERES = GANANCIA
                    totalPrestamoGanancia += Convert.ToDouble(row.ItemArray[2]) * (Convert.ToDouble(row.ItemArray[3]) / 100);
                    // SALDO
                    totalPrestamoSaldos += Convert.ToDouble(row.ItemArray[5]);
                    // TOTAL - ((MONTO * INTERES) + MONTO) = RECARGOS
                    totalPrestamoRecargos += Convert.ToDouble(row.ItemArray[6]) - ((Convert.ToDouble(row.ItemArray[2]) * (Convert.ToDouble(row.ItemArray[3]) / 100)) + Convert.ToDouble(row.ItemArray[2]));

                    // MONTO DE RECARGOS
                    row["montoRecargo"] = Convert.ToDouble(row.ItemArray[6]) - ((Convert.ToDouble(row.ItemArray[2]) * (Convert.ToDouble(row.ItemArray[3]) / 100)) + Convert.ToDouble(row.ItemArray[2]));

                }

                lblTotalPrestamoMonto.Text = totalPrestamoMonto.ToString("C", Moneda());
                lblTotalPrestamoGanancia.Text = totalPrestamoGanancia.ToString("C", Moneda());
                lblTotalSaldos.Text = totalPrestamoSaldos.ToString("C", Moneda());
                lblTotalRecargos.Text = totalPrestamoRecargos.ToString("C", Moneda());


                dtgPrestamos.DataSource = oDatos.Tables[0];

            }

        }


        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarClientes();
                CargarPrestamos();
            }
        }

        private void nuevoPrestamoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (cliente == null)
            {

                MessageBox.Show("Debes elegir algun cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = new frmNuevoPrestamo(this, cliente, nombre).ShowDialog();
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes oClientes = new frmListaClientes(this);
            oClientes.ShowDialog();


        }

        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbonos oAbonos = new frmAbonos();

            oAbonos.ShowDialog();

            this.Dispose();
        }

        private void recargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dtgPrestamos.SelectedRows.Count > 0)
            {
                int oPrestamo = Convert.ToInt32(this.dtgPrestamos.CurrentRow.Cells["ID"].Value);
                Prestamos_CuotasCL prestamos_CuotasCL = new Prestamos_CuotasCL();
                DataSet dataSet = prestamos_CuotasCL.TraerPrestamoCuotas_NoPago(oPrestamo.ToString());

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    double oMontoCuota = Convert.ToDouble(this.dtgPrestamos.CurrentRow.Cells["Cuotas"].Value);
                    double oSaldoPrestamo = Convert.ToDouble(this.dtgPrestamos.CurrentRow.Cells["Saldo"].Value);
                    double oTotalPrestamo = Convert.ToDouble(this.dtgPrestamos.CurrentRow.Cells["Total"].Value);
                    int oDia_pago = Convert.ToInt32(this.dtgPrestamos.CurrentRow.Cells["dia_pago"].Value);
                    frmRecargoPrestamo frmRecargoPrestamo = new frmRecargoPrestamo(this, oPrestamo, oMontoCuota, oSaldoPrestamo, oTotalPrestamo, oDia_pago, this.lblDescripcion.Text);
                    frmRecargoPrestamo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Este prestamo no presenta cuotas pendientes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar algun prestamo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void ckRecargos_CheckStateChanged(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        private void editarFechasCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgPrestamos.SelectedRows.Count > 0)
            {

                int prestamo = Convert.ToInt32(dtgPrestamos.CurrentRow.Cells["ID"].Value);

                Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

                DataSet oDatos = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString());

                if (oDatos.Tables[0].Rows.Count > 0)
                {

                    frmEdicionCuotaFecha oEfecha = new frmEdicionCuotaFecha(prestamo, lblDescripcion.Text);

                    oEfecha.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Este prestamo no presenta cuotas pendientes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar algun prestamo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        // ELIMINA UN PRESTAMO DEL CLIENTE
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dtgPrestamos.SelectedRows.Count > 0)
            {

                PrestamosCL prestamosCL = new PrestamosCL();
                // Prestamo ID
                int id = Convert.ToInt16(this.dtgPrestamos.CurrentRow.Cells["ID"].Value.ToString());
                prestamosCL.EliminarPrestamo(id);
                if (prestamosCL.IsError)
                {
                    MessageBox.Show(prestamosCL.ErrorDescripcion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Prestamo eliminado con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.CargarPrestamos();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar algún prestamo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // MUESTRA LOS PRESTAMOS ELIMINADOS
        private void ckBoxMostrarEliminados_CheckStateChanged(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        private void restaurarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dtgPrestamos.SelectedRows.Count > 0)
            {

                PrestamosCL prestamosCL = new PrestamosCL();
                // Prestamo ID
                int id = Convert.ToInt16(this.dtgPrestamos.CurrentRow.Cells["ID"].Value.ToString());
                prestamosCL.RestaurarPrestamoEliminado(id);
                if (prestamosCL.IsError)
                {
                    MessageBox.Show(prestamosCL.ErrorDescripcion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Prestamo restaurado con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.CargarPrestamos();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar algún prestamo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
