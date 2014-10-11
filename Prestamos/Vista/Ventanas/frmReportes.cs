using Prestamos.Formatos;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        public void ObtenerListaClientes()
        {
            //Obitene lista de clientes
            List<EClientes> oClientes = DClientes.ObtenerClientes();
            //Limpia el reporte
            ReportesVisor.LocalReport.DataSources.Clear();
            //Direccion del reporte
            ReportesVisor.LocalReport.ReportEmbeddedResource = "Prestamos.Vista.Reportes.ReportesClientes.rdlc";
            //Nombre del reporte
            ReportesVisor.LocalReport.DisplayName = "Lista de clientes";
            // Dataset del reporte y nombre establecido
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("Clientes", oClientes);
            // Asigna datos al reporte
            ReportesVisor.LocalReport.DataSources.Add(dataset);
            dataset.Value = oClientes;
            // Refrescar el reporte local
            ReportesVisor.LocalReport.Refresh();
            this.ReportesVisor.RefreshReport();


        }

        public void CuentasCobrar(string cliente, string prestamo, string fecha_desde, string fecha_hasta)
        {
            //Obitene lista de clientes
            List<EPrestamos> oPrestamos = DPrestamos.ObtenerPrestamos(cliente, prestamo,fecha_desde,fecha_hasta);
            //Limpia el reporte
            ReportesVisor.LocalReport.DataSources.Clear();
            //Direccion del reporte
            ReportesVisor.LocalReport.ReportEmbeddedResource = "Prestamos.Vista.Reportes.ReportesCuentasCobrar.rdlc";
            //Nombre del reporte
            ReportesVisor.LocalReport.DisplayName = "Prestamos por clientes";
            // Dataset del reporte y nombre establecido
            Microsoft.Reporting.WinForms.ReportDataSource prestamos = new Microsoft.Reporting.WinForms.ReportDataSource("Prestamos", oPrestamos);

            // Asigna datos al reporte
            ReportesVisor.LocalReport.DataSources.Add(prestamos);
            prestamos.Value = oPrestamos;

            // Refrescar el reporte local
            ReportesVisor.LocalReport.Refresh();
            this.ReportesVisor.RefreshReport();


        }

        public void EstadoCuenta(string cedula, string prestamo)
        {

            //Obitene lista de clientes
            List<ECuotas> oCuotas = DPrestamosCuotas.ObtenerCuotas(cedula, prestamo);
            //Limpia el reporte
            ReportesVisor.LocalReport.DataSources.Clear();
            //Direccion del reporte
            ReportesVisor.LocalReport.ReportEmbeddedResource = "Prestamos.Vista.Reportes.ReportesEstadoCuenta.rdlc";
            //Nombre del reporte
            ReportesVisor.LocalReport.DisplayName = "Estado de cuenta";
            // Dataset del reporte y nombre establecido
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("Cuotas", oCuotas);
            // Asigna datos al reporte
            ReportesVisor.LocalReport.DataSources.Add(dataset);
            dataset.Value = oCuotas;
            // Refrescar el reporte local
            ReportesVisor.LocalReport.Refresh();
            this.ReportesVisor.RefreshReport();

        }

        public void CierreCaja(string fecha_desde, string fecha_hasta)
        {

            //Obitene lista de cuotas
            List<ECierreCaja> oCuotas = DCierreCaja.ObtenerCuotasPagadas(fecha_desde, fecha_hasta);
            //Obitene lista de gastos
            List<EGastos> oGastos = DGastos.ObtenerGastos_RangoFecha(fecha_desde, fecha_hasta);
            //Obitene lista de abonos
            List<EAbonos> oAbonos = DAbonos.ObtenerAbonos_RangoFecha(fecha_desde, fecha_hasta);
            //Limpia el reporte
            ReportesVisor.LocalReport.DataSources.Clear();
            //Direccion del reporte
            ReportesVisor.LocalReport.ReportEmbeddedResource = "Prestamos.Vista.Reportes.ReportesCierreCaja.rdlc";
            //Nombre del reporte
            ReportesVisor.LocalReport.DisplayName = "Cierre caja";
            // Dataset del reporte y nombre establecido
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("PCuotas", oCuotas);
            Microsoft.Reporting.WinForms.ReportDataSource dataset1 = new Microsoft.Reporting.WinForms.ReportDataSource("Gastos", oGastos);
            Microsoft.Reporting.WinForms.ReportDataSource dataset2 = new Microsoft.Reporting.WinForms.ReportDataSource("Abonos", oAbonos);
            // Asigna datos al reporte
            ReportesVisor.LocalReport.DataSources.Add(dataset);
            ReportesVisor.LocalReport.DataSources.Add(dataset1);
            ReportesVisor.LocalReport.DataSources.Add(dataset2);
            dataset.Value = oCuotas;
            dataset1.Value = oGastos;
            dataset2.Value = oAbonos;
            // Refrescar el reporte local
            ReportesVisor.LocalReport.Refresh();
            this.ReportesVisor.RefreshReport();


        }

        public void CierreCaja_SinGastos(string fecha_desde, string fecha_hasta)
        {

            //Obitene lista de cuotas
            List<ECierreCaja> oCuotas = DCierreCaja.ObtenerCuotasPagadas(fecha_desde, fecha_hasta);
            //Obitene lista de abonos
            List<EAbonos> oAbonos = DAbonos.ObtenerAbonos_RangoFecha(fecha_desde, fecha_hasta);
            //Limpia el reporte
            ReportesVisor.LocalReport.DataSources.Clear();
            //Direccion del reporte
            ReportesVisor.LocalReport.ReportEmbeddedResource = "Prestamos.Vista.Reportes.ReportesCierreCajaSinGastos.rdlc";
            //Nombre del reporte
            ReportesVisor.LocalReport.DisplayName = "Cierre caja";
            // Dataset del reporte y nombre establecido
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("PCuotas", oCuotas);
            Microsoft.Reporting.WinForms.ReportDataSource dataset1 = new Microsoft.Reporting.WinForms.ReportDataSource("Abonos", oAbonos);
            // Asigna datos al reporte
            ReportesVisor.LocalReport.DataSources.Add(dataset);
            ReportesVisor.LocalReport.DataSources.Add(dataset1);
            dataset.Value = oCuotas;
            dataset1.Value = oAbonos;
            // Refrescar el reporte local
            ReportesVisor.LocalReport.Refresh();
            this.ReportesVisor.RefreshReport();

        }


        private void btnTodosClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestamosXCliente_Click(object sender, EventArgs e)
        {

        }

        private void cuotasPorPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }



    }
}
