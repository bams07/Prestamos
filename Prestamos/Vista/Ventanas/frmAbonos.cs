using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;
using Prestamos.Vista;
using Prestamos.Formatos;

namespace Prestamos.Vista.Ventanas
{

    public partial class frmAbonos : Form
    {
        #region VARIABLES

        string cliente;
        string nombre;
        DateTime fechaPactada;
        public DateTime fechaPreliminarPago;
        int cuota;
        int numCuota;
        int prestamo;
        double MontoCuota;
        EPrestamos oEPrestamos;

        #endregion

        public frmAbonos()
        {
            InitializeComponent();

        }

        #region METODOS

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
            PrestamosCL oPrestamos = new PrestamosCL();

            DataSet oDatos = oPrestamos.TraerPrestamo(txtCliente.Text, true);

            if (cliente != null)
            {

                dtgPrestamos.DataSource = oDatos.Tables[0];

                if (oDatos.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Este cliente no presenta prestamos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPrestamosCuotas("0");
                }


            }

        }

        public void OrdenColumnas()
        {
            // ESTABLE EL ORDEN DE LAS COLUMNAS
            dtgCuotas.Columns["num_cuota"].DisplayIndex = 0;
            dtgCuotas.Columns["fecha_pactada"].DisplayIndex = 1;
            dtgCuotas.Columns["fecha_pago"].DisplayIndex = 2;
            dtgCuotas.Columns["monto_cuota"].DisplayIndex = 3;
            dtgCuotas.Columns["saldo"].DisplayIndex = 4;
            dtgCuotas.Columns["pago"].DisplayIndex = 5;
            dtgCuotas.Columns["abonos"].DisplayIndex = 6;
        }

        public void CargarPrestamosCuotas(string prestamo)
        {
            // INSTANCIAS
            Prestamos_CuotasCL oPrestamosCuotas = new Prestamos_CuotasCL();

            Abonos_CuotasCL oAbonosCuotas = new Abonos_CuotasCL();

            // TRAE LAS CUOTAS DE LOS PRESTAMOS
            DataSet oDatos = oPrestamosCuotas.TraerPrestamoCuotas(prestamo);

            // ASIGNA LOS DATOS AL DATAGRID DE CUOTAS
            dtgCuotas.DataSource = oDatos.Tables[0];

            // CICLO QUE REVISA LAS FILAS DEL DATAGRID DE CUOTAS
            foreach (DataGridViewRow row in dtgCuotas.Rows)
            {
                if (Convert.ToBoolean(row.Cells["pago"].Value.ToString()) == true)
                {
                    // ESTABLECE COLOR VERDE SI LA COLUMNA PAGO ESTA CON CHECK
                    row.DefaultCellStyle.BackColor = Color.LightGreen;


                }
                else
                {
                    // ESTABLECE COLOR SALMON SI LA COLUMNA PAGO ESTA SIN CHECK
                    row.DefaultCellStyle.BackColor = Color.Salmon;


                }


                // TRAE LOS ABONOS DE UNA CUOTA
                DataSet oDatosAbonos = oAbonosCuotas.TraerAbono_Cuotas(row.Cells["id"].Value.ToString());

                // CALCULA LA CANTIDAD DE ABONOS
                int cantidadAbonos = Convert.ToInt32(oDatosAbonos.Tables[0].Rows.Count);

                // COMPRUEBA LA CANTIDAD
                if (cantidadAbonos > 0)
                {
                    // ESTABLECE EL TEXTO DEL BOTON DE ABONOS
                    row.Cells["abonos"].Value = "Abonos";
                }
                else
                {
                    // CAMBIA EL TIPO DE COLUMNA A TEXTO
                    row.Cells["abonos"] = new DataGridViewTextBoxCell();
                    row.Cells["abonos"].Value = "";
                }

            }

            // LLAMA AL METODO QUE ORDENA LAS COLUMNAS
            OrdenColumnas();
        }

        public void NuevoAbono()
        {
            // IGUAL LAS VARIABLES A LOS VALORES DEL DATAGRID
            fechaPactada = Convert.ToDateTime(dtgCuotas["fecha_pactada", dtgCuotas.CurrentCell.RowIndex].Value.ToString());
            cuota = Convert.ToInt32(dtgCuotas["id", dtgCuotas.CurrentCell.RowIndex].Value.ToString());
            numCuota = Convert.ToInt32(dtgCuotas["num_cuota", dtgCuotas.CurrentCell.RowIndex].Value.ToString());
            prestamo = Convert.ToInt32(dtgCuotas["id_prestamos", dtgCuotas.CurrentCell.RowIndex].Value.ToString());
            MontoCuota = Convert.ToDouble(dtgCuotas["monto_cuota", dtgCuotas.CurrentCell.RowIndex].Value.ToString());

            // INSTANCIA QUE LLAMA A LA VENTANA PARA GENERAR UN NUEVO ABONO
            frmNuevoAbono oNuevoAbono = new frmNuevoAbono(this, prestamo, cuota, numCuota, fechaPactada, MontoCuota, dtgPrestamos.CurrentCell.RowIndex, txtCliente.Text);
            oNuevoAbono.ShowDialog(this);

        }

        #endregion

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarClientes();
                CargarPrestamos();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes oClientes = new frmListaClientes(this);
            oClientes.ShowDialog();


        }

        private void dtgPrestamos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CargarPrestamosCuotas(dtgPrestamos[0, dtgPrestamos.CurrentCell.RowIndex].Value.ToString());
        }


        private void btnNuevoAbono_Click(object sender, EventArgs e)
        {
            if (dtgCuotas.CurrentCell.RowIndex == 0)
            {
                //COMPRUEBA SI LA FILA ACTUAL HA SIDO PAGADA
                if (Convert.ToBoolean(dtgCuotas["pago", dtgCuotas.CurrentCell.RowIndex].Value.ToString()))
                {

                    MessageBox.Show("Esta cuota ya ha sido pagada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //AGREGA UN NUEVO ABONO LLAMANDO AL METODO
                    NuevoAbono();

                }

            }
            else
            {
                //COMPRUEBA SI LA FILA ANTERIOR HA SIDO PAGADA
                if (Convert.ToBoolean(dtgCuotas["pago", dtgCuotas.CurrentCell.RowIndex - 1].Value.ToString()) == false)
                {

                    MessageBox.Show("Hay cuotas anteriores pendientes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {   //COMPRUEBA SI LA FILA ACTUAL HA SIDO PAGADA
                    if (Convert.ToBoolean(dtgCuotas["pago", dtgCuotas.CurrentCell.RowIndex].Value.ToString()))
                    {
                        MessageBox.Show("Esta cuota ya ha sido pagada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    { //AGREGA UN NUEVO ABONO LLAMANDO AL METODO
                        NuevoAbono();
                    }
                }
            }
        }

        private void btnEliminarAbono_Click(object sender, EventArgs e)
        {
            // COMPRUEBA SI LA CUOTA TIENE UN PAGO REGISTRADO
            if (Convert.ToBoolean(dtgCuotas["pago", dtgCuotas.CurrentCell.RowIndex].Value.ToString()) == true)
            {
                DialogResult opcion = MessageBox.Show("Esta seguro de eliminar este abono", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // SI EL USUARIO DIGITA SI EN EL DIALOGO ENTONCES PROCEDE A ELIMINAR EL ABONO
                if (opcion == DialogResult.Yes)
                {
                    // INSTANCIAS
                    Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

                    Abonos_CuotasCL oAbonos = new Abonos_CuotasCL();

                    PrestamosCL oPrestamos = new PrestamosCL();


                    // EDITAMOS PRESTAMO CUOTAS
                    oCuotas.EditarPrestamoCuotas(
                        Convert.ToInt32(dtgCuotas["id", dtgCuotas.CurrentCell.RowIndex].Value.ToString()),
                       Convert.ToDateTime(null),
                        false,
                        "eliminar"
                        );

                    // ELIMINA LOS ABONOS DE LA CUOTA
                    oAbonos.EliminarAbono_Cuotas_Id_Cuota(dtgCuotas["id", dtgCuotas.CurrentCell.RowIndex].Value.ToString());

                    // CALCULA EL NUEVO SALDO
                    double saldo =
                        Convert.ToInt32(dtgPrestamos["saldoPrestamo", dtgPrestamos.CurrentCell.RowIndex].Value.ToString()) +
                        Convert.ToInt32(dtgCuotas["monto_cuota", dtgCuotas.CurrentCell.RowIndex].Value.ToString());

                    // EDITA EL PRESTAMO
                    oPrestamos.EditarPrestamo(
                   Convert.ToInt32(dtgCuotas["id_prestamos", dtgCuotas.CurrentCell.RowIndex].Value.ToString()),
                   saldo);

                    // IMPRIME ERROR SI LO HAY
                    if (oCuotas.IsError)
                    {
                        MessageBox.Show(oCuotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        // GUARDA LA POSICION DEL PRESTAMO EN EL DATAGRID
                        int prestamoSelecion = dtgPrestamos.CurrentCell.RowIndex;

                        // LLAMA AL METODO CARGAR PRESTAMO
                        CargarPrestamos();

                        //ESTABLECE LA SELECION DEL PRESTAMO EN EL DATAGRID
                        dtgPrestamos.CurrentCell = dtgPrestamos.Rows[prestamoSelecion].Cells[0];

                        MessageBox.Show("Abono eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            else
            {
                // EN CASO DE QUE LA CUOTA NO TUVIERA PAGOS REGISTRADOS 
                MessageBox.Show("Esta cuota no tiene registros de pagos que eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(this.dtgCuotas["pago", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString()))
            {
                MessageBox.Show("Esta cuota no tiene registros de pagos que imprimir", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.oEPrestamos = new EPrestamos();
                ClientesCL clientesCL = new ClientesCL();
                PrestamosCL prestamosCL = new PrestamosCL();
                DataTable dataTable = clientesCL.TraerClientes(this.cliente).Tables[0];
                DataTable dataTable2 = prestamosCL.TraerFechaFinalPrestamo(Convert.ToString(this.dtgCuotas["id_prestamos", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString())).Tables[0];
                this.oEPrestamos.clientePrestamo = this.cliente;
                this.oEPrestamos.nombreCliente = dataTable.Rows[0].ItemArray.GetValue(1).ToString();
                this.oEPrestamos.telefonoCliente = dataTable.Rows[0].ItemArray.GetValue(4).ToString();
                this.oEPrestamos.direccionCliente = dataTable.Rows[0].ItemArray.GetValue(2).ToString();
                this.oEPrestamos.totalPrestamo = Convert.ToDouble(this.dtgPrestamos["Total1", this.dtgPrestamos.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.fechaPactada = Convert.ToDateTime(this.dtgCuotas["fecha_pactada", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.fechaAbono = Convert.ToDateTime(this.dtgCuotas["fecha_pago", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.numeroCuota = Convert.ToInt32(this.dtgCuotas["num_cuota", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.idCuota = Convert.ToInt32(this.dtgCuotas["id", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.prestamo = Convert.ToString(this.dtgCuotas["id_prestamos", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.saldoPrestamo = Convert.ToDouble(this.dtgCuotas["saldo", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.saldoPretamoAnterior = Convert.ToDouble(this.dtgCuotas["saldo", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString()) + Convert.ToDouble(this.dtgCuotas["monto_cuota", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.montoAbono = Convert.ToDouble(this.dtgCuotas["monto_cuota", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.fechaFinalPrestamo = Convert.ToDateTime(dataTable2.Rows[0].ItemArray.GetValue(0).ToString());
                this.ImprimirTicket.Print();
            }
        }

        private void ImprimirTicket_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            FontFamily oFamily = new FontFamily("Microsoft Sans Serif");

            Font oFont = new Font(oFamily, 9);

            e.Graphics.PageUnit = GraphicsUnit.Pixel;

            e.Graphics.DrawString(oEPrestamos.ticket, oFont, Brushes.Black,
                20, 10);

        }


        private void dtgCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                frmAbonosCuotas oAbonosCuotas = new frmAbonosCuotas(
                    Convert.ToInt32(dtgCuotas["id", dtgCuotas.CurrentCell.RowIndex].Value.ToString()),
                    Convert.ToInt32(dtgCuotas["id_prestamos", dtgCuotas.CurrentCell.RowIndex].Value.ToString()),
                    this
                  );

                oAbonosCuotas.ShowDialog();

            }
        }

        private void imprimirPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFechaPreliminarPagoCuota frmFechaPreliminarPagoCuota = new frmFechaPreliminarPagoCuota(this);
            frmFechaPreliminarPagoCuota.ShowDialog();
            if (this.fechaPreliminarPago.ToShortDateString() != "01/01/0001")
            {
                this.oEPrestamos = new EPrestamos();
                ClientesCL clientesCL = new ClientesCL();
                PrestamosCL prestamosCL = new PrestamosCL();
                DataTable dataTable = clientesCL.TraerClientes(this.cliente).Tables[0];
                DataTable dataTable2 = prestamosCL.TraerFechaFinalPrestamo(Convert.ToString(this.dtgCuotas["id_prestamos", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString())).Tables[0];
                this.oEPrestamos.clientePrestamo = this.cliente;
                this.oEPrestamos.nombreCliente = dataTable.Rows[0].ItemArray.GetValue(1).ToString();
                this.oEPrestamos.telefonoCliente = dataTable.Rows[0].ItemArray.GetValue(4).ToString();
                this.oEPrestamos.direccionCliente = dataTable.Rows[0].ItemArray.GetValue(2).ToString();
                this.oEPrestamos.totalPrestamo = Convert.ToDouble(this.dtgPrestamos["Total1", this.dtgPrestamos.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.fechaPactada = Convert.ToDateTime(this.dtgCuotas["fecha_pactada", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.fechaAbono = this.fechaPreliminarPago;
                this.oEPrestamos.numeroCuota = Convert.ToInt32(this.dtgCuotas["num_cuota", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.idCuota = Convert.ToInt32(this.dtgCuotas["id", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.prestamo = Convert.ToString(this.dtgCuotas["id_prestamos", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.saldoPrestamo = Convert.ToDouble(this.dtgCuotas["saldo", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.saldoPretamoAnterior = Convert.ToDouble(this.dtgCuotas["saldo", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString()) + Convert.ToDouble(this.dtgCuotas["monto_cuota", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.montoAbono = Convert.ToDouble(this.dtgCuotas["monto_cuota", this.dtgCuotas.CurrentCell.RowIndex].Value.ToString());
                this.oEPrestamos.fechaFinalPrestamo = Convert.ToDateTime(dataTable2.Rows[0].ItemArray.GetValue(0).ToString());
                this.ImprimirTicket.Print();
            }
        }



    }
}
