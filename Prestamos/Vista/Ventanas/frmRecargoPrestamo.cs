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

        public frmRecargoPrestamo(frmPrestamos fPrestamos, int oPrestamo, double oMontoCuota, double oSaldoPrestamo, int oDia_pago, string cliente)
        {
            InitializeComponent();

            TraerCuotas(oPrestamo);

            #region VARIABLES IGUALADAS PARAMETROS

            ofrmPrestamos = fPrestamos;

            montoCuota = oMontoCuota;

            prestamo = oPrestamo;

            saldoPrestamo = oSaldoPrestamo;

            dia_pago = oDia_pago;

            lblCliente.Text = cliente;

            lblNumeroPrestamo.Text = Convert.ToString("00000" + oPrestamo);

            #endregion

        }


        // CARGAS LAS CUOTAS
        public void TraerCuotas(int prestamo)
        {

            Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

            DataSet oDatos = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString());

            dCuotas = oDatos.Tables[0];

            dtgCuotas.DataSource = dCuotas;

        }


        // CALCULA LA FECHA PACTADA
        public void ValidarFechaPactada()
        {

            #region CALCULA LA FECHA PARA DIAS

            if (dia_pago == 1)
            {

                fecha = fecha.AddDays(1);

            }

            #endregion

            #region CALCULA LA FECHA PARA LA SEMANAS

            if (dia_pago == 2)
            {

                fecha = fecha.AddDays(7);

            }


            #endregion

            #region CALCULA LA FECHA PARA LAS QUINCENAS

            if (dia_pago == 3)
            {
                int mes = fecha.Month;
                int dia = fecha.Day;


                // CALCULA LA FECHA PARA ESTOS MESESS


                //MESES CON DIAS 31
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {

                    if (dia == 31)
                    {

                        fecha = fecha.AddDays(15);

                    }

                    if (dia == 15)
                    {

                        fecha = fecha.AddDays(16);

                    }


                }
                //MESES CON DIAS 30
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia == 30)
                    {
                        fecha = fecha.AddDays(15);

                    }

                    if (dia == 15)
                    {
                        fecha = fecha.AddDays(15);

                    }

                }
                //MESES CON DIAS 28 O 29 
                else if (mes == 2)
                {
                    if (DateTime.IsLeapYear(fecha.Year))
                    {
                        if (dia == 29)
                        {
                            fecha = fecha.AddDays(15);
                        }

                        if (dia == 15)
                        {
                            fecha = fecha.AddDays(14);
                        }

                    }
                    else
                    {

                        if (dia == 28)
                        {
                            fecha = fecha.AddDays(15);

                        }

                        if (dia == 15)
                        {

                            fecha = fecha.AddDays(13);

                        }

                    }




                }
            }
            #endregion

            #region CALCULA LA FECHA PARA LOS MESES

            if (dia_pago == 4)
            {

                fecha = fecha.AddMonths(1);

            }


            #endregion

        }


        public void GenerarCuotasPrevias()
        {
            if (!string.IsNullOrEmpty(txtMonto.Text))
            {

                #region VARIABLES

                double oSaldoCuota = saldoPrestamo + Convert.ToDouble(txtMonto.Text);
                double valorxcuotas = montoCuota;
                Boolean terminarGenerarCuotas = true;
                int contador = 0;
                int numeroCuota = Convert.ToInt32(dCuotas.Rows[dCuotas.Rows.Count - 1]["num_cuota"]);
                fecha = Convert.ToDateTime(dCuotas.Rows[dCuotas.Rows.Count - 1]["fecha_pactada"]);

                #endregion

                // COPIA LA ESTRUCTURA Y DATOS DEL TABLE
                dCuotasPre = dCuotas.Copy();

                // CICLO QUE GENERA LAS CUOTAS DE RECARGO
                while (terminarGenerarCuotas)
                {

                    if (oSaldoCuota >= montoCuota)
                    {
                        valorxcuotas = montoCuota;
                    }
                    else
                    {
                        // TERMINA EL CICLO 
                        valorxcuotas = oSaldoCuota;
                        terminarGenerarCuotas = false;

                    }

                    oSaldoCuota -= valorxcuotas;

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

                        ValidarFechaPactada();

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
                MessageBox.Show("Escriba el monto de recargo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnGenerarPrevisualzacion_Click(object sender, EventArgs e)
        {
            GenerarCuotasPrevias();
        }

        // PROCESA LAS CUOTAS CON SU RESPECTIVA MODIFICACION DE FECHAS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // REVISA SI EL DATAGRID TIENE CUOTAS 
            if (dtgCuotasPrevias.Rows.Count > 0)
            {

                Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();
                PrestamosCL oPrestamos = new PrestamosCL();

                // NUEVO SALDO DEL PRESTAMOS SUMANDOLE EL MONTO DE RECARGO
                saldoPrestamo += Convert.ToDouble(txtMonto.Text);


                for (int i = 0; i < dtgCuotasPrevias.Rows.Count; i++)
                {

                    double monto = Convert.ToDouble(dtgCuotasPrevias["montoPre", i].Value);
                    double saldo = Convert.ToDouble(dtgCuotasPrevias["saldoPre", i].Value);
                    totalPrestamo += Convert.ToDouble(dtgCuotasPrevias["montoPre", i].Value);



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

                    MessageBox.Show("Recargo creado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // EDITA EL PRESTAMO AGREGANDOLE UN NUEVO SALDO Y ESTABLECIENDOLO COMO TIPO RECARGO
                     oPrestamos.EditarPrestamo_Recargo(prestamo, saldoPrestamo, totalPrestamo, true);
                    ofrmPrestamos.CargarPrestamos();
                    this.Dispose();

                }



            }
            else
            {
                MessageBox.Show("Debes generar primero la previsualización de fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }






    }
}
