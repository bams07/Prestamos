using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Vista;
using Prestamos.Logica;
using Prestamos.Formatos;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmDashBoard : Form
    {


        public frmDashBoard()
        {
            InitializeComponent();

            CargarTotalSaldo();
            CargarTotalClientes();

        }

        // CARGA EL TOTAL DE SALDO DE TODOS LOS PRESTAMOS
        public void CargarTotalSaldo()
        {
            PrestamosCL oPrestamos = new PrestamosCL();

            DataRow oTotalSaldo = oPrestamos.TraerPrestamoSaldoTotal().Tables[0].Rows[0];

            EPrestamos oPrestamosMoneda = new EPrestamos();

            string totalSaldo = oTotalSaldo.ItemArray.GetValue(0).ToString();

            lblTotalSaldoPrestamos.Text = Convert.ToDouble(totalSaldo).ToString("C", oPrestamosMoneda.Moneda());

        }

        // CARGA EL TOTAL DE CLIENTES REGISTRADOS
        public void CargarTotalClientes()
        {
            ClientesCL oClientes = new ClientesCL();

            DataRow oTotalClientes = oClientes.TraerTotalClientes().Tables[0].Rows[0];

            lblTotalClientes.Text = oTotalClientes.ItemArray.GetValue(0).ToString();

        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes oClientes = new frmClientes();
            oClientes.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos oPrestamos = new frmPrestamos();
            oPrestamos.Show();
        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            frmAbonos oAbonos = new frmAbonos();

            oAbonos.Show();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            frmGastos oGastos = new frmGastos();
            oGastos.Show();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            frmRespaldo oRespaldo = new frmRespaldo();
            oRespaldo.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes oReportes = new frmReportes();
            oReportes.ShowDialog();
        }

        private void btnPlanillaCobro_Click(object sender, EventArgs e)
        {
            frmPlanillaCobro oPlanilla = new frmPlanillaCobro();
            oPlanilla.Show();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            frmCierreCaja oCierre = new frmCierreCaja();
            oCierre.ShowDialog();
        }

        private void btnRListaClientes_Click(object sender, EventArgs e)
        {
            frmReportes oReportes = new frmReportes();
            oReportes.Show();
            oReportes.ObtenerListaClientes();
        }

        private void btnRCuentasXCobrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRPrestamosClientes_Click(object sender, EventArgs e)
        {
            frmRFiltroCuentaCobrar oFiltro = new frmRFiltroCuentaCobrar();
            oFiltro.ShowDialog();
        }

        private void btnRPrestamosCuotas_Click(object sender, EventArgs e)
        {
            frmRFiltroEstadoCuenta oFiltro = new frmRFiltroEstadoCuenta();
            oFiltro.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios oUsuarios = new frmUsuarios();

            oUsuarios.ShowDialog();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            frmCalendario oCalendario = new frmCalendario();

            oCalendario.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTotalSaldo();
            CargarTotalClientes();
        }
    }
}
