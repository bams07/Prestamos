using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;
using System.Collections;
using Prestamos.Logica.Postgres;
using System.Text.RegularExpressions;

namespace Prestamos.Vista.Ventanas
{


    public partial class frmNuevoPrestamo : Form
    {
        #region Variables
        DateTime fecha;
        string cliente;
        double monto;
        double interes;
        double totalInteres;
        double total;
        double valorxcuotas;
        int numeroPrestamo;
        ArrayList cuotasGeneradas;

        #endregion

        frmPrestamos prestamos;

        public frmNuevoPrestamo(frmPrestamos Prestamos, string Cliente, string ClienteNombre)
        {
            InitializeComponent();
            prestamos = Prestamos;
            lblCliente.Text = ClienteNombre;
            SecuenciaPrestamo();
            cliente = Cliente;

        }

        public void SecuenciaPrestamo()
        {

            PrestamosCL oPrestamos = new PrestamosCL();

            int secuencia;
            try
            {
                secuencia = Convert.ToInt32(SecuenciasCL.TraerSecuenciaPrestamo().Tables[0].Rows[0].ItemArray[0]) + 1;
            }
            catch (System.IndexOutOfRangeException e)
            {

                secuencia = 1;

            }

            lblNumeroPrestamo.Text = Convert.ToString("00000" + secuencia);
            numeroPrestamo = secuencia;

        }

        public void GenerarCuotas()
        {
            // COMPRUEBA EL VALOR DE LOS CAMPOS
            if (txtInteres.Text == "" || txtMonto.Text == "" || txtCuotas.Text == "")
            {
                MessageBox.Show("LLene los campos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dia = dtFechaInicial.Value.Day;
                int mes = dtFechaInicial.Value.Month;
                int ano = dtFechaInicial.Value.Year;
                int tipo = ValidacionesCL.ValidarDiaPagoIndex(cmbDiaPago.SelectedItem.ToString());
                bool ValidacionQuincena = ValidacionesCL.validarQuincena(dia, mes, ano, tipo);

                // COMPRUEBA SI EL DIA DE PAGO NO ES QUINCENA
                if (ValidacionQuincena == false)
                {
                    cuotasGeneradas = new ArrayList();

                    #region COLUMNAS DE LA TABLA

                    DataSet oDatos = new DataSet();

                    DataTable oTable = oDatos.Tables.Add();

                    DataColumn oColumn = new DataColumn();

                    oColumn = oTable.Columns.Add("Numero couta");
                    oColumn = oTable.Columns.Add("Fecha de pago");
                    oColumn = oTable.Columns.Add("Monto");
                    oColumn = oTable.Columns.Add("Saldo");

                    #endregion

                    #region GENERA LAS CUOTAS


                    // TOMA LA FECHA INICIAL
                    fecha = dtFechaInicial.Value;


                    double cuotas = monto + totalInteres;

                    // EL SALDO ES IGUAL AL TOTAL AL PRINCIPIO
                    double SaldoCuotas = total;

                    // VARIABLE QUE SE ESTABLECE PARA DECIDIR CUANDO TERMINAR DE CALCULAR
                    Boolean terminarGenerarCuotas = true;

                    int cont = 1;

                    // CICLO QUE GENERA LAS CUOTAS

                    if (ckActivarCuoutaInicial.CheckState == CheckState.Checked)
                    {
                        if (string.IsNullOrEmpty(txtMontoCuotaInicial.Text))
                        {
                            MessageBox.Show("Falta el monto de la cuota inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SaldoCuotas -= Convert.ToDouble(txtMontoCuotaInicial.Text);

                            DataRow row = oTable.Rows.Add(0);

                            row["Numero couta"] = 0;
                            row["Fecha de pago"] = dtFechaCuotaInicial.Value.ToShortDateString();
                            row["Monto"] = txtMontoCuotaInicial.Text;
                            row["Saldo"] = SaldoCuotas;

                            cuotasGeneradas.Add(row);
                        }

                    }


                    if (SaldoCuotas > 0)
                    {

                        while (terminarGenerarCuotas)
                        {

                            if (SaldoCuotas >= Convert.ToDouble(txtCuotas.Text))
                            {
                                valorxcuotas = Convert.ToDouble(txtCuotas.Text);
                            }
                            else
                            {
                                valorxcuotas = SaldoCuotas;
                                terminarGenerarCuotas = false;
                            }

                            SaldoCuotas -= valorxcuotas;

                            DataRow row = oTable.Rows.Add(cont);

                            row["Numero couta"] = cont;
                            row["Fecha de pago"] = fecha.ToShortDateString();
                            row["Monto"] = valorxcuotas;
                            row["Saldo"] = SaldoCuotas;

                            // LLEVA EL CONTROL DE LOS MESES PARA UNA FECHA ESPECIFICA
                            ValidacionesCL.contadorMeses = cont;

                            // CONSULTA LA FECHA SIGUIENTE BASADO EN EL DIA PAGO ESCODIGO
                            fecha = ValidacionesCL.validarFechaPago(fecha.Day, fecha.Month, fecha.Year, fecha, tipo);

                            cuotasGeneradas.Add(row);

                            cont++;

                            if (SaldoCuotas == 0)
                            {

                                break;
                            }
                        }
                    }

                    #endregion

                    dtgCuotas.DataSource = oDatos.Tables[0];

                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int dia = dtFechaInicial.Value.Day;
            int mes = dtFechaInicial.Value.Month;
            int ano = dtFechaInicial.Value.Year;
            int tipo = ValidacionesCL.ValidarDiaPagoIndex(cmbDiaPago.SelectedItem.ToString());
            bool ValidacionQuincena = ValidacionesCL.validarQuincena(dia, mes, ano, tipo);

            // COMPRUEBA SI EL DIA DE PAGO NO ES QUINCENA
            if (ValidacionQuincena == false)
            {

                if (dtgCuotas.RowCount > 0)
                {

                    if (txtMonto.Text == "" || txtInteres.Text == "" || txtCuotas.Text == "")
                    {
                        MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PrestamosCL oPrestamos = new PrestamosCL();
                        Prestamos_CuotasCL oPrestamos_Cuotas = new Prestamos_CuotasCL();

                        double saldo = total;

                        oPrestamos.InsertarPrestamo(numeroPrestamo, dtFecha.Value, cliente, monto, interes, Convert.ToInt32(txtCuotas.Text), saldo, total, false, tipo);

                        foreach (DataRow item in cuotasGeneradas)
                        {

                            oPrestamos_Cuotas.InsertarPrestamo_Cuotas(

                               numeroPrestamo,
                               Convert.ToInt32(item.ItemArray[0]),
                               Convert.ToDateTime(item.ItemArray[1]),
                               Convert.ToInt32(item.ItemArray[2]),
                               Convert.ToInt32(item.ItemArray[3])

                                );
                        }

                        if (oPrestamos.IsError)
                        {
                            MessageBox.Show(oPrestamos.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            MessageBox.Show("Prestamo creado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            prestamos.CargarPrestamos();
                            this.Dispose();
                        }
                    }
                }
                else
                {

                    MessageBox.Show("Genere primero las cuotas antes de crear un prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {

            if (ValidacionesCL.ValidarSoloNumeros(txtInteres.Text))
            {

                // QUITA LOS ESPACIOS EN BLANCO
                txtMonto.Text = txtMonto.Text.Replace(" ", "");
                txtInteres.Text = txtInteres.Text.Replace(" ", "");

                if (txtInteres.Text == "" || txtMonto.Text == "")
                {
                    lblValorInteres.Text = "₡ 0000";
                    lblValorTotal.Text = "₡ 0000";

                }
                else
                {


                    monto = Convert.ToDouble(txtMonto.Text.Replace(" ", ""));

                    // TOMA EL INTERES Y SE LO AGREGA A LA VARIABLE
                    interes = Convert.ToDouble(txtInteres.Text);

                    totalInteres = (interes / 100) * monto;

                    total = monto + totalInteres;

                    lblValorTotal.Text = Convert.ToString("₡ " + total);

                    lblValorInteres.Text = Convert.ToString("₡ " + totalInteres);

                }
            }
            else
            {   // ELIMINA LOS VALOREES ( LETRAS, SIMBOLOS)

                txtInteres.Text = txtInteres.Text.Remove(txtInteres.Text.Length - 1);
                txtInteres.SelectionStart = txtInteres.Text.Length;

            }
        }

        private void btnGenerarCuotas_Click(object sender, EventArgs e)
        {
            GenerarCuotas();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            txtMonto.Text = txtMonto.Text.Replace(" ", "");
            txtInteres.Text = txtInteres.Text.Replace(" ", "");

            if (txtInteres.Text == "" || txtMonto.Text == "")
            {
                lblValorInteres.Text = "₡ 0000";
                lblValorTotal.Text = "₡ 0000";

            }
            else
            {


                monto = Convert.ToDouble(txtMonto.Text.Replace(" ", ""));

                interes = Convert.ToDouble(txtInteres.Text);

                totalInteres = (interes / 100) * monto;

                total = monto + totalInteres;

                lblValorTotal.Text = Convert.ToString("₡ " + total);

                lblValorInteres.Text = Convert.ToString("₡ " + totalInteres);

            }
        }

        private void txtCuotas_TextChanged(object sender, EventArgs e)
        {
            // QUITA LOS ESPACIOS EN BLANCO
            txtCuotas.Text = txtCuotas.Text.Replace(" ", "");

            // COMPARA EL VALOR DEL TOTOAL CON EL ESCRITO SI ESTE ES MAYOR ENTONCES ESTABLECE EL MONTO IGUAL AL TOTAL
            if (!string.IsNullOrEmpty(txtCuotas.Text) && lblValorTotal.Text != "₡ 0000")
            {
                if (Convert.ToDouble(lblValorTotal.Text.Replace("₡ ", "")) < Convert.ToDouble(txtCuotas.Text))
                {
                    txtCuotas.Text = lblValorTotal.Text;
                }

            }

        }

        private void dtFechaInicial_CloseUp(object sender, EventArgs e)
        {
            int dia = dtFechaInicial.Value.Day;
            int mes = dtFechaInicial.Value.Month;
            int ano = dtFechaInicial.Value.Year;
            int tipo = ValidacionesCL.ValidarDiaPagoIndex(cmbDiaPago.SelectedItem.ToString());
            bool ValidacionQuincena = ValidacionesCL.validarQuincena(dia, mes, ano, tipo);

        }

        private void ckActivarCuoutaInicial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckActivarCuoutaInicial.CheckState == CheckState.Checked)
            {
                txtMontoCuotaInicial.Enabled = true;
                dtFechaCuotaInicial.Enabled = true;
            }
            else
            {
                txtMontoCuotaInicial.Enabled = false;
                dtFechaCuotaInicial.Enabled = false;

            }
        }

        private void txtMontoCuotaInicial_TextChanged(object sender, EventArgs e)
        {
            // QUITA LOS ESPACIOS EN BLANCO
            txtMontoCuotaInicial.Text = txtMontoCuotaInicial.Text.Replace(" ", "");

            // COMPARA EL VALOR DEL TOTOAL CON EL ESCRITO SI ESTE ES MAYOR ENTONCES ESTABLECE EL MONTO IGUAL AL TOTAL
            if (!string.IsNullOrEmpty(txtMontoCuotaInicial.Text) && lblValorTotal.Text != "₡ 0000")
            {
                if (Convert.ToDouble(lblValorTotal.Text.Replace("₡ ", "")) < Convert.ToDouble(txtMontoCuotaInicial.Text))
                {
                    txtMontoCuotaInicial.Text = lblValorTotal.Text;
                }

            }


        }



    }
}
