using Prestamos.Formatos;
using Prestamos.Logica;
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
    public partial class frmCargarPlanillaProcesada : Form
    {

        #region VARIABLES

        frmPlanillaCobro iPlanilla;
        public DateTime fechaPago;
        string numPlanilla;
        string detPlanilla;
        string fechaPlanilla;
        string errores;
        int cRows;
        string ticket;

        #endregion

        public frmCargarPlanillaProcesada(string nPlanilla, frmPlanillaCobro oPlanillaCobro, string fecha, string detalle)
        {
            InitializeComponent();

            #region VARIABLES IGUALADAS

            numPlanilla = nPlanilla;
            iPlanilla = oPlanillaCobro;
            detPlanilla = detalle;
            fechaPlanilla = fecha;


            #endregion

            CargarPlanilla();

        }

        public void CargarPlanilla()
        {

            this.Text = "Planilla #0000" + numPlanilla;

            // OPCIONES DE DETALLE
            txtDetalle.Text = detPlanilla;
            txtDetalle.Enabled = false;

            // ESTABLECE LA FECHA
            lblFecha.Text = Convert.ToDateTime(fechaPlanilla).ToShortDateString();

            //CARGA LOS DETALLES DE LA PLANILLA
            CargarDetallePlanilla(numPlanilla);


        }

        //CALCULA EL TOTAL DE MONTO DE LA PLANILLA
        public void TotalPlanilla()
        {
            double total = 0;

            foreach (DataGridViewRow row in dtgPrestamosCuotas.Rows)
            {
                total += Convert.ToDouble(row.Cells["Monto"].Value.ToString());
            }

            // MUESTRAS EL TOTOAL DE CUOTAS
            lblTotalCuotas.Text = dtgPrestamosCuotas.Rows.Count.ToString();

            lblValorTotal.Text = "₡" + total.ToString();

        }

        // CARGA LAS CUOTAS DE LA PLANILLA
        public void CargarDetallePlanilla(string planilla)
        {

            PlanillaCL oPlanilla = new PlanillaCL();

            DataSet oDatos = oPlanilla.TraerPlanillaDetalle(planilla);

            dtgPrestamosCuotas.DataSource = oDatos.Tables[0];

            TotalPlanilla();

        }

        public void CargarAbonosCuotas()
        {

            Abonos_CuotasCL oAbonosCuotas = new Abonos_CuotasCL();

            foreach (DataGridViewRow row in dtgPrestamosCuotas.Rows)
            {

                // TRAE LOS ABONOS DE UNA CUOTA
                DataSet oDatosAbonos = oAbonosCuotas.TraerAbono_Cuotas(row.Cells["Prestamos_cuotas_id"].Value.ToString());

                // CALCULA LA CANTIDAD DE ABONOS
                int cantidadAbonos = Convert.ToInt32(oDatosAbonos.Tables[0].Rows.Count);

                // COMPRUEBA LA CANTIDAD
                if (cantidadAbonos > 0)
                {
                    // ESTABLECE EL TEXTO DEL BOTON DE ABONOS
                    row.Cells["Abonos"].Value = "Abonos";


                }
                else
                {
                    // CAMBIA EL TIPO DE COLUMNA A TEXTO
                    row.Cells["Abonos"] = new DataGridViewTextBoxCell();
                    row.Cells["Abonos"].Value = "";
                }

            }


        }


        // ORDENA LAS COLUMNAS DEL DATAGRID
        public void OrdernarColumnas()
        {
            dtgPrestamosCuotas.Columns["Cedula"].DisplayIndex = 0;
            dtgPrestamosCuotas.Columns["Nombre"].DisplayIndex = 1;
            dtgPrestamosCuotas.Columns["Prestamo"].DisplayIndex = 2;
            dtgPrestamosCuotas.Columns["Numero_cuota"].DisplayIndex = 3;
            dtgPrestamosCuotas.Columns["Fecha_pactada"].DisplayIndex = 4;
            dtgPrestamosCuotas.Columns["Monto"].DisplayIndex = 5;
            dtgPrestamosCuotas.Columns["Saldo"].DisplayIndex = 6;
            dtgPrestamosCuotas.Columns["Abonos"].DisplayIndex = 7;

        }

        public void imprimirTicketsValores()
        {
            // INSTANCIA
            EPrestamos oEPrestamos = new EPrestamos();

            PrestamosCL oPrestamos = new PrestamosCL();

            DataTable oPrestamoTotal = oPrestamos.TraerPrestamoTotal(Convert.ToInt32(dtgPrestamosCuotas.Rows[cRows].Cells["Cedula"].Value.ToString())).Tables[0];

            DataTable oPrestamoFechaFinal = oPrestamos.TraerFechaFinalPrestamo(Convert.ToInt32(dtgPrestamosCuotas.Rows[cRows].Cells["Prestamo"].Value.ToString())).Tables[0];

            ClientesCL oClientes = new ClientesCL();

            DataTable oTable = oClientes.TraerClientes(dtgPrestamosCuotas.Rows[cRows].Cells["Cedula"].Value.ToString()).Tables[0];

            double saldoAnterior = Convert.ToDouble(dtgPrestamosCuotas.Rows[cRows].Cells["Saldo"].Value.ToString()) + Convert.ToDouble(dtgPrestamosCuotas.Rows[cRows].Cells["Monto"].Value.ToString());


            // VALORES DEL TICKETS
            oEPrestamos.cedulaCliente = dtgPrestamosCuotas.Rows[cRows].Cells["Cedula"].Value.ToString();
            oEPrestamos.nombreCliente = oTable.Rows[0].ItemArray.GetValue(1).ToString();
            oEPrestamos.telefonoCliente = oTable.Rows[0].ItemArray.GetValue(4).ToString();
            oEPrestamos.direccionCliente = oTable.Rows[0].ItemArray.GetValue(2).ToString();
            oEPrestamos.totalPrestamo = Convert.ToDouble(oPrestamoTotal.Rows[0].ItemArray.GetValue(0).ToString());
            oEPrestamos.fechaPactadaCuota = Convert.ToDateTime(dtgPrestamosCuotas.Rows[cRows].Cells["Fecha_pactada"].Value.ToString());
            oEPrestamos.fechaPagadaCuota = Convert.ToDateTime(lblFecha.Text);
            oEPrestamos.numeroCuota = Convert.ToInt32(dtgPrestamosCuotas.Rows[cRows].Cells["Numero_cuota"].Value.ToString());
            oEPrestamos.idCuota = Convert.ToInt32(dtgPrestamosCuotas.Rows[cRows].Cells["Prestamos_cuotas_id"].Value.ToString());
            oEPrestamos.numeroPrestamo = dtgPrestamosCuotas.Rows[cRows].Cells["Prestamo"].Value.ToString();
            oEPrestamos.saldoPrestamo = Convert.ToDouble(dtgPrestamosCuotas.Rows[cRows].Cells["Saldo"].Value.ToString());
            oEPrestamos.saldoAnterior = saldoAnterior;
            oEPrestamos.montoCuota = Convert.ToDouble(dtgPrestamosCuotas.Rows[cRows].Cells["Monto"].Value.ToString());
            oEPrestamos.fechaFinalPrestamo = Convert.ToDateTime(oPrestamoFechaFinal.Rows[0].ItemArray.GetValue(0).ToString());

            // IGUALA LA VARIABLE A AL TICKET 
            ticket = oEPrestamos.ticket;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            iPlanilla.CargarPlanilla("");
            this.Dispose();
        }

        private void frmCargarPlanilla_Shown(object sender, EventArgs e)
        {
            OrdernarColumnas();
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtgPrestamosCuotas.Rows.Count != 0)
            {

                DialogResult imprimir = MessageBox.Show("Desea imprimir los ticket de esta planilla? ", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (imprimir == DialogResult.Yes)
                {
                    cRows = 0;

                    for (int i = 0; i < dtgPrestamosCuotas.Rows.Count; i++)
                    {
                        ImprimirTickets.Print();
                        cRows++;

                    }
                }
            }

            else
            {

                MessageBox.Show("No puede procesar una planilla sin cuotas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ImprimirTickets_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // TIPO DE LETRA
            FontFamily oFamily = new FontFamily("Microsoft Sans Serif");

            // TAMANO DE LETRA
            Font oFont = new Font(oFamily, 9);

            e.Graphics.PageUnit = GraphicsUnit.Pixel;

            // CARGA LOS VALORES DEL TICKET
            imprimirTicketsValores();

            e.Graphics.DrawString(ticket, oFont, Brushes.Black,
                20, 10);

        }

        private void imprimirCuotas_Click(object sender, EventArgs e)
        {

            if (dtgPrestamosCuotas.Rows.Count != 0)
            {

                DialogResult imprimir = MessageBox.Show("Desea imprimir los ticket de las cuotas selecionadas?\nCuotas seleccionadas: " + dtgPrestamosCuotas.SelectedRows.Count, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (imprimir == DialogResult.Yes)
                {
                    cRows = 0;

                    // CONTIENE LAS FILAS SELECIONADAS
                    int[] filasSelecionadas = new int[dtgPrestamosCuotas.SelectedRows.Count];

                    // LLEVA LOS INDICES DE LAS FILAS EN EL ARRAY
                    int indexFilas = 0;

                    // AGREGA LAS FILAS AL ARREGLO
                    foreach (DataGridViewRow item in dtgPrestamosCuotas.SelectedRows)
                    {
                        filasSelecionadas[indexFilas] = item.Index;
                        indexFilas++;
                    }

                    // ORDENA LAS FILAS
                    Array.Sort(filasSelecionadas);

                    // CICLO QUE RECORRE EL ARREGLO PARA IMPRIMIR
                    for (int i = 0; i < filasSelecionadas.Length; i++)
                    {

                        cRows = filasSelecionadas[i];
                        ImprimirTickets.Print();

                    }

                }
            }

            else
            {

                MessageBox.Show("No puede procesar una planilla sin cuotas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void frmCargarPlanillaProcesada_Load(object sender, EventArgs e)
        {
            CargarAbonosCuotas();
        }


        private void dtgPrestamosCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {

                frmAbonosCuotas oAbonosCuotas = new frmAbonosCuotas(
                    Convert.ToInt32(dtgPrestamosCuotas["Prestamos_cuotas_id", dtgPrestamosCuotas.CurrentCell.RowIndex].Value.ToString()));

                oAbonosCuotas.ShowDialog();

            }
        }

        private void dtgPrestamosCuotas_Sorted(object sender, EventArgs e)
        {
            CargarAbonosCuotas();
        }

        private void dtgPrestamosCuotas_SelectionChanged_1(object sender, EventArgs e)
        {
            lblTotalCuotasSeleccionadas.Text = dtgPrestamosCuotas.SelectedRows.Count.ToString();
        }

    }
}
