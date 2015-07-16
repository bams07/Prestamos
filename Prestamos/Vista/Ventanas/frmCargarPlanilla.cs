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
    public partial class frmCargarPlanilla : Form
    {
        frmPlanillaCobro iPlanilla;
        public DateTime fechaPago;
        string numPlanilla;
        string detPlanilla;
        string fechaPlanilla;
        string ticket;
        string errores;
        bool procesadaPlanilla;
        int cRows;


        public frmCargarPlanilla(string nPlanilla, frmPlanillaCobro oPlanillaCobro, string fecha, string detalle, bool procesada)
        {
            InitializeComponent();

            #region VARIABLES IGUALADAS

            numPlanilla = nPlanilla;
            iPlanilla = oPlanillaCobro;
            detPlanilla = detalle;
            fechaPlanilla = fecha;
            procesadaPlanilla = procesada;

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


        // CARGA LAS CUOTAS DE LA PLANILLA
        public void CargarDetallePlanilla(string planilla)
        {

            PlanillaCL oPlanilla = new PlanillaCL();

            DataSet oDatos = oPlanilla.TraerPlanillaDetalle(planilla);

            dtgPrestamosCuotas.DataSource = oDatos.Tables[0];

            TotalPlanilla();

        }

        // VALIDA SI LAS CUOTAS YA HAN SIDO PAGADAS
        public bool ValidarPago()
        {
            Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

            int cont = 0;
            errores = "La siguientes cuotas ya han sido pagadas:";

            foreach (DataGridViewRow row in dtgPrestamosCuotas.Rows)
            {
                int idPrestamo = Convert.ToInt32(row.Cells["Prestamo"].Value.ToString());

                DataTable oDatos = oCuotas.TraerPrestamoCuotas_Pago(idPrestamo.ToString()).Tables[0];

                foreach (DataRow cuota in oDatos.Rows)
                {
                    if (cuota["num_cuota"].ToString() == row.Cells["Numero_cuota"].Value.ToString())
                    {
                        cont++;
                        errores += "\n" + "La cuota numero " + row.Cells["Numero_cuota"].Value.ToString() + " del prestamo " + row.Cells["Prestamo"].Value.ToString();
                    }

                    if (oDatos.Rows.Count - (int)row.Cells["Numero_cuota"].Value > 1)
                    {

                    }


                }

            }

            if (cont > 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        //OBTENER FECHA DE PAGO
        public bool ObtenerFechaPago()
        {
            frmFechaPlanillaProcesar oFecha = new frmFechaPlanillaProcesar(this);

            oFecha.ShowDialog();

            if (fechaPago.Year == 1)
            {
                return false;
            }
            else
            {
                return true;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            iPlanilla.CargarPlanilla("");
            this.Dispose();
        }

        //ELIMINA LAS CUOTAS DE LA PLANILLA
        private void dtgPrestamosCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                PlanillaCL oPlanilla = new PlanillaCL();


                string idCuota = dtgPrestamosCuotas.Rows[e.RowIndex].Cells["Prestamos_cuotas_id"].Value.ToString();
                string idPlanilla = numPlanilla;

                oPlanilla.EliminarPlanillaDetalle(idCuota, idPlanilla);

                dtgPrestamosCuotas.Rows.RemoveAt(e.RowIndex);

                TotalPlanilla();
            }

        }

        private void frmCargarPlanilla_Shown(object sender, EventArgs e)
        {
            OrdernarColumnas();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (this.dtgPrestamosCuotas.Rows.Count != 0)
            {
                PrestamosCL prestamosCL = new PrestamosCL();
                Prestamos_CuotasCL prestamos_CuotasCL = new Prestamos_CuotasCL();
                Abonos_CuotasCL abonos_CuotasCL = new Abonos_CuotasCL();
                PlanillaCL planillaCL = new PlanillaCL();
                if (this.ValidarPago())
                {
                    if (this.ObtenerFechaPago())
                    {
                        foreach (DataGridViewRow dataGridViewRow in dtgPrestamosCuotas.Rows)
                        {
                            int num = Convert.ToInt32(dataGridViewRow.Cells["Prestamos_cuotas_id"].Value.ToString());
                            int id = Convert.ToInt32(dataGridViewRow.Cells["Prestamo"].Value.ToString());
                            DataSet dataSet = prestamosCL.TraerPrestamoSaldo(id.ToString());
                            DataTable dataTable = dataSet.Tables[0];
                            DataRow dataRow = dataTable.Rows[0];
                            double num2 = (double)Convert.ToInt32(dataRow.ItemArray.GetValue(0).ToString());
                            DataSet dataSet2 = abonos_CuotasCL.TraerSuma_Abonos(dataGridViewRow.Cells["Prestamos_cuotas_id"].Value.ToString());
                            DataTable dataTable2 = dataSet2.Tables[0];
                            DataRow dataRow2 = dataTable2.Rows[0];
                            if (!string.IsNullOrEmpty(dataRow2.ItemArray.GetValue(0).ToString()))
                            {
                                double num3 = Convert.ToDouble(dataRow2.ItemArray.GetValue(0).ToString());
                                double monto = (double)Convert.ToInt32(dataGridViewRow.Cells["Monto"].Value.ToString()) - num3;
                                abonos_CuotasCL.InsertarAbono_Cuotas(num, monto, this.fechaPago);
                                num2 -= (double)Convert.ToInt32(dataGridViewRow.Cells["Monto"].Value.ToString()) - num3;
                            }
                            else
                            {
                                num2 -= (double)Convert.ToInt32(dataGridViewRow.Cells["Monto"].Value.ToString());
                            }
                            prestamosCL.EditarPrestamo(id, num2);
                            prestamos_CuotasCL.EditarPrestamoCuotas(num, this.fechaPago, true, "");
                        }
                        planillaCL.EditarPlanilla(Convert.ToInt32(this.numPlanilla), true);
                        if (planillaCL.IsError)
                        {
                            MessageBox.Show(planillaCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show("Planilla procesada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.iPlanilla.CargarPlanilla("");
                            base.Dispose();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this.errores, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("No hay cuotas que procesar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (this.dtgPrestamosCuotas.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Desea imprimir los ticket de esta planilla? ", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.cRows = 0;
                    for (int i = 0; i < this.dtgPrestamosCuotas.Rows.Count; i++)
                    {
                        this.ImprimirTickets.Print();
                        this.cRows++;
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede procesar una planilla sin cuotas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void ImprimirTickets_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FontFamily family = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(family, 9f);
            e.Graphics.PageUnit = GraphicsUnit.Pixel;
            this.imprimirTicketsValores();
            e.Graphics.DrawString(this.ticket, font, Brushes.Black, 20f, 10f);

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

        private void dtgPrestamosCuotas_SelectionChanged(object sender, EventArgs e)
        {
            lblTotalCuotasSeleccionadas.Text = dtgPrestamosCuotas.SelectedRows.Count.ToString();
        }

        private void dtgPrestamosCuotas_Sorted(object sender, EventArgs e)
        {
            CargarAbonosCuotas();
        }

        private void frmCargarPlanilla_Load(object sender, EventArgs e)
        {
            CargarAbonosCuotas();
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


    }
}
