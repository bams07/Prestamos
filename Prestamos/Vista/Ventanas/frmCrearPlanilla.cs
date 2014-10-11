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
    public partial class frmCrearPlanilla : Form
    {

        #region VARIABLES

        frmPlanillaCobro iPlanilla;
        public DateTime fechaPago;
        int numPlanilla;
        string fechaPlanilla;
        string errores;
        int cRows;
        string ticket;

        #endregion

        public frmCrearPlanilla(int nPlanilla, frmPlanillaCobro oPlanillaCobro, string fecha)
        {
            InitializeComponent();

            #region VARIABLES IGUALADAS

            numPlanilla = nPlanilla;
            iPlanilla = oPlanillaCobro;
            fechaPlanilla = fecha;


            #endregion

            CargarCuotas(fechaPlanilla);

        }


        // CARGA LAS CUOTAS PENDIENTES DE LA FECHA Y MENOR

        public void CargarCuotas(string fecha)
        {
            Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

            dtgPrestamosCuotas.DataSource = oCuotas.TraerPrestamoCuotas_Filtros(fecha).Tables[0];

            OrdernarColumnas();

            TotalPlanilla();

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
            dtgPrestamosCuotas.Columns["Eliminar"].DisplayIndex = 8;

        }

        public void imprimirTicketsValores()
        {
            EPrestamos ePrestamos = new EPrestamos();
            PrestamosCL prestamosCL = new PrestamosCL();
            DataTable dataTable = prestamosCL.TraerPrestamo_planilla(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Cedula"].Value.ToString(), this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Prestamo"].Value.ToString(), true).Tables[0];
            DataTable dataTable2 = prestamosCL.TraerFechaFinalPrestamo(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Prestamo"].Value.ToString()).Tables[0];
            ClientesCL clientesCL = new ClientesCL();
            DataTable dataTable3 = clientesCL.TraerClientes(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Cedula"].Value.ToString()).Tables[0];
            double saldoPretamoAnterior = Convert.ToDouble(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Saldo"].Value.ToString()) + Convert.ToDouble(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Monto"].Value.ToString());
            ePrestamos.clientePrestamo = this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Cedula"].Value.ToString();
            ePrestamos.nombreCliente = dataTable3.Rows[0].ItemArray.GetValue(1).ToString();
            ePrestamos.telefonoCliente = dataTable3.Rows[0].ItemArray.GetValue(4).ToString();
            ePrestamos.direccionCliente = dataTable3.Rows[0].ItemArray.GetValue(2).ToString();
            ePrestamos.totalPrestamo = Convert.ToDouble(dataTable.Rows[0].ItemArray.GetValue(6).ToString());
            ePrestamos.fechaPactada = Convert.ToDateTime(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Fecha_pactada"].Value.ToString());
            ePrestamos.fechaAbono = Convert.ToDateTime(this.lblFecha.Text);
            ePrestamos.numeroCuota = Convert.ToInt32(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Numero_cuota"].Value.ToString());
            ePrestamos.idCuota = Convert.ToInt32(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Prestamos_cuotas_id"].Value.ToString());
            ePrestamos.prestamo = this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Prestamo"].Value.ToString();
            ePrestamos.saldoPrestamo = Convert.ToDouble(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Saldo"].Value.ToString());
            ePrestamos.saldoPretamoAnterior = saldoPretamoAnterior;
            ePrestamos.montoAbono = Convert.ToDouble(this.dtgPrestamosCuotas.Rows[this.cRows].Cells["Monto"].Value.ToString());
            ePrestamos.fechaFinalPrestamo = Convert.ToDateTime(dataTable2.Rows[0].ItemArray.GetValue(0).ToString());
            this.ticket = ePrestamos.ticket;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dtgPrestamosCuotas.Rows.Count != 0)
            {

                DialogResult opcion = MessageBox.Show("Desea guardar la planilla con estas cuotas", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (opcion == DialogResult.OK)
                {



                    if (txtDetalle.Text == "")
                    {



                        MessageBox.Show("Escriba un detalle para esta planilla", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {

                        // INSTANCIAS

                        PlanillaCL oPlanilla = new PlanillaCL();

                        oPlanilla.InsertarPlanilla(numPlanilla, Convert.ToDateTime(lblFecha.Text), txtDetalle.Text, false);

                        foreach (DataGridViewRow row in dtgPrestamosCuotas.Rows)
                        {

                            int idCuota = Convert.ToInt32(row.Cells["Prestamos_cuotas_id"].Value.ToString());

                            oPlanilla.InsertarPlanillaDetalle(numPlanilla, idCuota);

                        }

                        // COMPRUEBA SI HAY ERROR

                        if (oPlanilla.IsError)
                        {

                            MessageBox.Show(oPlanilla.ErrorDescripcion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else
                        {
                            MessageBox.Show("Planilla creada con exito ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult imprimir = MessageBox.Show("Desea imprimir los ticket de esta planilla? ", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (imprimir == DialogResult.Yes)
                            {

                                int cRows = 0;

                                for (int i = 0; i < dtgPrestamosCuotas.Rows.Count; i++)
                                {

                                    ImprimirTickets.Print();

                                    cRows++;

                                }
                            }

                            iPlanilla.CargarPlanilla("");

                            this.Dispose();

                        }

                    }

                }

            }

            else
            {

                MessageBox.Show("No puede procesar una planilla sin cuotas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dtgPrestamosCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                PlanillaCL oPlanilla = new PlanillaCL();

                oPlanilla.EliminarPlanillaDetalle(dtgPrestamosCuotas.Rows[e.RowIndex].Cells["Prestamos_cuotas_id"].Value.ToString());

                dtgPrestamosCuotas.Rows.RemoveAt(e.RowIndex);

                TotalPlanilla();
            }
        }



    }
}
