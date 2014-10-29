using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos.Logica;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmRecargoPrestamo : Form
    {
        #region VARIABLES

        frmPrestamos ofrmPrestamos;
        DataTable dCuotas;
        DataTable dCuotasPre;
        DateTime fecha;
        double montoCuota;
        double saldoPrestamo;
        double totalPrestamo;
        int dia_pago;
        int prestamo;

        #endregion

        public frmRecargoPrestamo(frmPrestamos fPrestamos, int oPrestamo, double oMontoCuota, double oSaldoPrestamo, double oTotalPrestamo, int oDia_pago, string cliente)
        {
            InitializeComponent();

            // BUSCA LAS CUOTAS DEL PRESTAMO
            traerCuotas(oPrestamo);

            #region VARIABLES IGUALADAS PARAMETROS

            ofrmPrestamos = fPrestamos;

            montoCuota = oMontoCuota;

            prestamo = oPrestamo;

            saldoPrestamo = oSaldoPrestamo;

            totalPrestamo = oTotalPrestamo;

            dia_pago = oDia_pago;

            lblCliente.Text = cliente;

            lblNumeroPrestamo.Text = Convert.ToString("00000" + oPrestamo);

            #endregion

        }


        // CARGAS LAS CUOTAS
        public void traerCuotas(int prestamo)
        {

            Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

            DataSet oDatos = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString());

            dCuotas = oDatos.Tables[0];

            dtgCuotas.DataSource = dCuotas;

        }


        // REVISAR SI LAS CUOTAS TIENE ABONOS PENDIENTES
        public bool revisarAbonos()
        {
            Abonos_CuotasCL oAbonosCuotas = new Abonos_CuotasCL();

            bool hayAbonos = false;

            // RECORRE LAS CUOTAS DE LA TABLA EN BUSCA DE ABONOS DE LAS CUOTAS
            foreach (DataGridViewRow row in dtgCuotas.Rows)
            {
                DataSet oDatosAbonos = oAbonosCuotas.TraerAbono_Cuotas(row.Cells["id_cuota"].Value.ToString());

                // CALCULA LA CANTIDAD DE ABONOS
                int cantidadAbonos = Convert.ToInt32(oDatosAbonos.Tables[0].Rows.Count);

                // COMPRUEBA LA CANTIDAD
                if (cantidadAbonos > 0)
                {
                    // ESTABLECE COLOR VERDE SI LA CUOTA TIENE ABONOS
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                    row.Selected = false;
                    hayAbonos = true;
                }

            }

            return hayAbonos;

        }

        // GENERA LA PREVISUALIZACION DE LAS NUEVAS CUOTAS 
        public void generarCuotasPrevias()
        {

            if (!revisarAbonos())
            {
                if (!string.IsNullOrEmpty(txtMonto.Text))
                {
                    #region VARIABLES

                    double oSaldoCuota = saldoPrestamo + Convert.ToDouble(txtMonto.Text);
                    double valorxcuotas = montoCuota;
                    saldoPrestamo += Convert.ToDouble(txtMonto.Text);
                    totalPrestamo += Convert.ToDouble(txtMonto.Text);
                    Boolean terminarGenerarCuotas = true;
                    fecha = Convert.ToDateTime(dCuotas.Rows[dCuotas.Rows.Count - 1]["fecha_pactada"]);
                    int contador = 0;
                    int numeroCuota = Convert.ToInt32(dCuotas.Rows[dCuotas.Rows.Count - 1]["num_cuota"]);
                    int dia = fecha.Day;
                    int mes = fecha.Month;
                    int ano = fecha.Year;
                    int tipo = dia_pago;

                    #endregion

                    // COPIA LA ESTRUCTURA Y DATOS DEL TABLE
                    dCuotasPre = dCuotas.Copy();

                    // CICLO QUE GENERA LAS CUOTAS DE RECARGO
                    while (terminarGenerarCuotas)
                    {
                        // VA DISMINUYENDO EL SALDO EN CADA VUELTA, PARA DARLE UN SALDO A CADA CUOTA
                        oSaldoCuota -= valorxcuotas;

                        if (oSaldoCuota > 0)
                        {
                            valorxcuotas = montoCuota;

                            /* SI EL SALDO ES MENOR AL VALOR DE LA CUOTA, ENTONCES EL VALOR DE
                            LA CUOTA SE CONVIERTE EN EL SALDO RESTANTE */
                            if (oSaldoCuota < valorxcuotas)
                            {
                                valorxcuotas = oSaldoCuota;
                            }

                        }
                        else
                        {
                            // TERMINA EL CICLO 
                            terminarGenerarCuotas = false;
                        }
                        // MODIFICA LAS CUOTAS EXISTENTES POR LOS NUEVOS VALORES

                        if (contador <= dCuotas.Rows.Count - 1)
                        {

                            dCuotasPre.Rows[contador]["monto"] = valorxcuotas;
                            dCuotasPre.Rows[contador]["saldo"] = oSaldoCuota;

                        }

                        // CREA UNA NUEVA FILA PARA AGREGAR CUOTAS

                        else
                        {
                            numeroCuota = numeroCuota + 1;

                            DataRow row = dCuotasPre.Rows.Add(numeroCuota);

                            fecha = ValidacionesCL.validarFechaPago(fecha.Day, fecha.Month, fecha.Year, fecha, tipo);

                            // AGREGA VALORES A LAS NUEVAS FILAS CREADAS
                            row["num_cuota"] = numeroCuota;
                            row["fecha_pactada"] = fecha;
                            row["monto"] = valorxcuotas;
                            row["saldo"] = oSaldoCuota;

                        }



                        contador++;
                    }


                    dtgCuotasPrevias.DataSource = dCuotasPre;

                }
                else
                {
                    MessageBox.Show("Escriba el monto a recargar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Las siguientes cuotas en rojo presentan abonos y no han sido pagadas en su totalidad, " +
                                "cancele las cuotas pendientes antes de continuar ",
                                "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        // BTN QUE ACTIVA LA PREVISUALIZACION
        private void btnGenerarPrevisualzacion_Click(object sender, EventArgs e)
        {
            generarCuotasPrevias();
        }

        // PROCESA LAS CUOTAS CON SU RESPECTIVA MODIFICACION DE FECHAS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // REVISA SI EL DATAGRID TIENE CUOTAS 
            if (dtgCuotasPrevias.Rows.Count > 0)
            {

                Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();
                PrestamosCL oPrestamos = new PrestamosCL();

                for (int i = 0; i < dtgCuotasPrevias.Rows.Count; i++)
                {

                    double monto = Convert.ToDouble(dtgCuotasPrevias["montoPre", i].Value);
                    double saldo = Convert.ToDouble(dtgCuotasPrevias["saldoPre", i].Value);




                    // ESTE IF COMPRUEBA LAS CUOTAS QUE SE DEBEN EDITAR
                    if (i < dtgCuotas.Rows.Count)
                    {

                        int id = Convert.ToInt32(dtgCuotasPrevias["idPre", i].Value);

                        oCuotas.EditarPrestamoCuotas_RecargoPrestamo(id, monto, saldo);

                    }
                    else
                    {
                        // AGREGA NUEVAS CUOTAS AL PRESTAMO COMO PARTE DE UN RECARGO
                        int num_cuota = Convert.ToInt32(dtgCuotasPrevias["num_cuotaPre", i].Value);
                        DateTime fecha_pactada = Convert.ToDateTime(dtgCuotasPrevias["fecha_pactadaPre", i].Value);


                        oCuotas.InsertarPrestamo_Cuotas(prestamo, num_cuota, fecha_pactada, monto, saldo);

                    }


                }


                if (oCuotas.IsError)
                {
                    MessageBox.Show(oCuotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {


                    // EDITA EL PRESTAMO AGREGANDOLE UN NUEVO SALDO Y ESTABLECIENDOLO COMO TIPO RECARGO
                    oPrestamos.EditarPrestamo_Recargo(prestamo, saldoPrestamo, totalPrestamo, true);

                    if (oPrestamos.IsError)
                    {

                        MessageBox.Show(oPrestamos.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        MessageBox.Show("Recargo creado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ofrmPrestamos.CargarPrestamos();
                        this.Dispose();

                    }

                }

            }
            else
            {
                MessageBox.Show("Debes generar primero la previsualización de cuotas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }






    }
}
