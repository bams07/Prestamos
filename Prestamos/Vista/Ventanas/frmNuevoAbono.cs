using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;
using Prestamos.Formatos;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmNuevoAbono : Form
    {

        #region Variables

        private frmAbonos Abonos;
        private string cliente;
        private int Prestamo;
        private int Cuota;
        private int NumCuota;
        private int filaSelecionadaP;
        private double Monto;
        private double saldo;
        private double totalPrestamo;

        #endregion

        public frmNuevoAbono(frmAbonos oAbonos, int oPrestamo, int oCuota, int oNumCuota, DateTime ofechaPactada, double oMonto, int ofilaSelecionada, string ocliente)
        {
            InitializeComponent();
            dtFechaPactada.Value = ofechaPactada;
            txtMonto.Text = Convert.ToString(oMonto);
            Prestamo = oPrestamo;
            Monto = oMonto;
            Cuota = oCuota;
            NumCuota = oNumCuota;
            Abonos = oAbonos;
            filaSelecionadaP = ofilaSelecionada;
            cliente = ocliente;

        }

        public void PagoCuotas()
        {

            // INSTANCIAS
            Prestamos_CuotasCL oPrestamosCuotas = new Prestamos_CuotasCL();

            PrestamosCL oPrestamos = new PrestamosCL();

            Abonos_CuotasCL oAbonosCuotas = new Abonos_CuotasCL();
            
            // VARIABLE CONTIENE SALDO DEL PRESTAMO
            saldo = Convert.ToDouble(oPrestamos.TraerPrestamoSaldo(Convert.ToString(Prestamo)).Tables[0].Rows[0].ItemArray[0]);

            double saldoActual = saldo;

            double MontoAbono = Convert.ToDouble(txtMonto.Text);

            if (Abonos.dtgCuotas["num_cuota", 0].Value.ToString() != "0")
            {
                NumCuota -= 1;
            }
  

            for (int i = NumCuota; i < Abonos.dtgCuotas.Rows.Count; i++)
            {

                Monto = Convert.ToDouble(Abonos.dtgCuotas["monto_cuota", i].Value.ToString());

                DataSet oAbonosSuma = oAbonosCuotas.TraerSuma_Abonos(Abonos.dtgCuotas["id", i].Value.ToString());

                saldo = Convert.ToDouble(Abonos.dtgCuotas["saldo", i].Value.ToString());

                NumCuota = Convert.ToInt32(Abonos.dtgCuotas["num_cuota", i].Value.ToString());

                DataSet oAbonosCantidad = oAbonosCuotas.TraerCantidad_Abonos(Abonos.dtgCuotas["id", i].Value.ToString());

                // TERMINA 
                if (MontoAbono <= 0 || saldoActual <= 0)
                {
                    break;
                }



                if (oAbonosCantidad.Tables[0].Rows.Count > 0)
                {
                    double totalAbonos = Convert.ToDouble(oAbonosSuma.Tables[0].Rows[0].ItemArray.GetValue(0));

                    double totalFaltante = Monto - totalAbonos;

                    if (MontoAbono >= totalFaltante)
                    {

                        saldoActual -= totalFaltante;

                        oPrestamos.EditarPrestamo(Prestamo, saldoActual);

                        oAbonosCuotas.InsertarAbono_Cuotas(
                           Convert.ToInt32(Abonos.dtgCuotas["id", i].Value.ToString()),
                           totalFaltante,
                           dtFechaPago.Value);

                        oPrestamosCuotas.EditarPrestamoCuotas(
                            Convert.ToInt32(Abonos.dtgCuotas["id", i].Value.ToString()),
                           dtFechaPago.Value,
                             true,
                             null);

                        MontoAbono -= totalFaltante;

                        ImprimirTicket.Print();


                    }
                    else
                    {
                        saldoActual -= MontoAbono;

                        oAbonosCuotas.InsertarAbono_Cuotas(
                          Convert.ToInt32(Abonos.dtgCuotas["id", i].Value.ToString()),
                          MontoAbono,
                          dtFechaPago.Value);

                        oPrestamos.EditarPrestamo(Prestamo, saldoActual);

                        MontoAbono -= MontoAbono;
                    }

                }
                else
                {
                    // PAGA LA CUOTA
                    if (MontoAbono >= Monto)
                    {

                        saldoActual -= Monto;

                        oPrestamos.EditarPrestamo(Prestamo, saldoActual);

                        oPrestamosCuotas.EditarPrestamoCuotas(
                          Convert.ToInt32(Abonos.dtgCuotas["id", i].Value.ToString()),
                         dtFechaPago.Value,
                         true,
                         null);

                        MontoAbono -= Monto;

                        ImprimirTicket.Print();

                    }
                    else
                    {
                        saldoActual -= MontoAbono;

                        oAbonosCuotas.InsertarAbono_Cuotas(
                          Convert.ToInt32(Abonos.dtgCuotas["id", i].Value.ToString()),
                          MontoAbono,
                          dtFechaPago.Value);

                        oPrestamos.EditarPrestamo(Prestamo, saldoActual);

                        MontoAbono -= MontoAbono;

                    }

                }




            }




            //  DialogResult opcion = MessageBox.Show("El monto es mayor al pactado \nDesea pagar esta cuota y abonar el resto a las demas cuotas?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PagoCuotas();

            MessageBox.Show("Abono realizado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // CARGA EL PRESTAMO Y ESTABLECE EL SELECT EN EL PRESTAMO UTILIZADO
            Abonos.CargarPrestamos();
            Abonos.dtgPrestamos.CurrentCell = Abonos.dtgPrestamos.Rows[filaSelecionadaP].Cells[0];

            Abonos.Refresh();
            this.Dispose();

        }

        private void ImprimirTicket_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FontFamily family = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(family, 9f);
            EPrestamos ePrestamos = new EPrestamos();
            ClientesCL clientesCL = new ClientesCL();
            DataTable dataTable = clientesCL.TraerClientes(this.cliente).Tables[0];
            ePrestamos.clientePrestamo = this.cliente;
            ePrestamos.nombreCliente = dataTable.Rows[0].ItemArray.GetValue(1).ToString();
            ePrestamos.telefonoCliente = dataTable.Rows[0].ItemArray.GetValue(4).ToString();
            ePrestamos.direccionCliente = dataTable.Rows[0].ItemArray.GetValue(2).ToString();
            ePrestamos.totalPrestamo = this.totalPrestamo;
            ePrestamos.fechaPactada = Convert.ToDateTime(this.dtFechaPactada.Text);
            ePrestamos.fechaAbono = Convert.ToDateTime(Convert.ToString(this.dtFechaPago.Value));
            ePrestamos.numeroCuota = Convert.ToInt32(Convert.ToString(this.NumCuota));
            ePrestamos.prestamo = Convert.ToString(this.Prestamo);
            ePrestamos.saldoPrestamo = this.saldo;
            ePrestamos.saldoPretamoAnterior = this.saldo + this.Monto;
            ePrestamos.montoAbono = this.Monto;
            e.Graphics.PageUnit = GraphicsUnit.Pixel;
            e.Graphics.DrawString(ePrestamos.ticket, font, Brushes.Black, 20f, 10f);


        }

        private void frmNuevoAbono_Load(object sender, EventArgs e)
        {

        }

        private void ckOtroMonto_CheckStateChanged(object sender, EventArgs e)
        {

            if (ckOtroMonto.CheckState == CheckState.Checked)
            {

                txtMonto.Enabled = true;


            }
            else
            {

                txtMonto.Enabled = false;
                txtMonto.Text = Convert.ToString(Monto);


            }






        }


    }
}
