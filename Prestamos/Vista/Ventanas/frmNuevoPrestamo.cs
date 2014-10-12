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

        // CALCULA LA FECHA PARA LAS QUINCENAS
        public void ValidarFechaPago()
        {

            #region CALCULA LA FECHA PARA DIAS

            if (cmbDiaPago.SelectedIndex == 0)
            {

                fecha = fecha.AddDays(1);

            }

            #endregion

            #region CALCULA LA FECHA PARA LA SEMANAS

            if (cmbDiaPago.SelectedIndex == 1)
            {
                fecha = fecha.AddDays(7);
            }


            #endregion

            #region CALCULA LA FEHCA BISEMANAL

            if (this.cmbDiaPago.SelectedIndex == 2)
            {
                this.fecha = this.fecha.AddDays(14.0);
            }

            #endregion

            #region CALCULA LA FECHA PARA LAS QUINCENAS

            if (cmbDiaPago.SelectedIndex == 3)
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

            #region CALCULA LA FECHA PARA LAS QUINCENAS ESPECIALES

            if (this.cmbDiaPago.SelectedIndex == 4)
            {
                int month = this.fecha.Month;
                int day = this.fecha.Day;
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day == 30)
                    {
                        this.fecha = this.fecha.AddDays(16.0);
                    }
                    if (day == 15)
                    {
                        this.fecha = this.fecha.AddDays(15.0);
                    }
                }
                else
                {
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        if (day == 30)
                        {
                            this.fecha = this.fecha.AddDays(15.0);
                        }
                        if (day == 15)
                        {
                            this.fecha = this.fecha.AddDays(15.0);
                        }
                    }
                    else
                    {
                        if (month == 2)
                        {
                            if (DateTime.IsLeapYear(this.fecha.Year))
                            {
                                if (day == 29)
                                {
                                    this.fecha = this.fecha.AddDays(15.0);
                                }
                                if (day == 15)
                                {
                                    this.fecha = this.fecha.AddDays(14.0);
                                }
                            }
                            else
                            {
                                if (day == 28)
                                {
                                    this.fecha = this.fecha.AddDays(15.0);
                                }
                                if (day == 15)
                                {
                                    this.fecha = this.fecha.AddDays(13.0);
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region CALCULA LA FECHA PARA LOS MESES

            if (cmbDiaPago.SelectedIndex == 5)
            {

                fecha = fecha.AddMonths(1);

            }


            #endregion

        }

        public bool ComprobarQuincena()
        {

            // COMPRUEBA LA QUINCENA    

            if (cmbDiaPago.SelectedIndex == 3)
            {
                int mes = dtFechaInicial.Value.Month;
                int dia = dtFechaInicial.Value.Day;

                // MESES CON DIAS 31
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {

                    if (dia != 15 && dia != 31)
                    {

                        MessageBox.Show("Esta fecha no pertenece a una fecha de quincena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return true;

                    }
                    else
                    {

                        return false;
                    }


                }

                 // MESES CON DIAS 30
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia != 15 && dia != 30)
                    {
                        MessageBox.Show("Esta fecha no pertenece a una fecha de quincena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return true;

                    }
                    else
                    {
                        return false;

                    }

                }

                 //MESES CON DIAS 28 0 29
                else if (mes == 2)
                {
                    if (DateTime.IsLeapYear(dtFechaInicial.Value.Year))
                    {

                        if (dia != 15 && dia != 29)
                        {
                            MessageBox.Show("Esta fecha no pertenece a una fecha de quincena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return true;

                        }
                        else
                        {
                            return false;

                        }

                    }
                    else
                    {

                        if (dia != 15 && dia != 28)
                        {
                            MessageBox.Show("Esta fecha no pertenece a una fecha de quincena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return true;

                        }
                        else
                        {
                            return false;

                        }



                    }

                }


            }

            // COMPRUEBA LA QUINCENA ESPECIAL

            if (this.cmbDiaPago.SelectedIndex == 4)
            {
                int mes = this.dtFechaInicial.Value.Month;
                int dia = this.dtFechaInicial.Value.Day;

                // MESES CON DIAS 31
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia != 15 && dia != 30)
                    {
                        MessageBox.Show("Esta fecha no pertenece a una fecha de quincena especial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return true;

                    }
                    return false;

                }
                else
                {
                    // MESES CON DIAS 30
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        if (dia != 15 && dia != 30)
                        {
                            MessageBox.Show("Esta fecha no pertenece a una fecha de quincena especial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return true;

                        }
                        return false;

                    }
                    else
                    {
                        //MESES CON DIAS 28 0 29
                        if (mes == 2)
                        {
                            if (DateTime.IsLeapYear(this.dtFechaInicial.Value.Year))
                            {
                                if (dia != 15 && dia != 29)
                                {
                                    MessageBox.Show("Esta fecha no pertenece a una fecha de quincena especial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return true;

                                }
                                return false;

                            }
                            else
                            {
                                if (dia != 15 && dia != 28)
                                {
                                    MessageBox.Show("Esta fecha no pertenece a una fecha de quincena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return true;

                                }
                                return false;

                            }
                        }
                    }
                }
            }


            return false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    int dia_pago = cmbDiaPago.SelectedIndex + 1;

                    oPrestamos.InsertarPrestamo(numeroPrestamo, dtFecha.Value, cliente, monto, interes, Convert.ToInt32(txtCuotas.Text), saldo, total, false, dia_pago);

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

        private void txtInteres_TextChanged(object sender, EventArgs e)
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

        private void btnGenerarCuotas_Click(object sender, EventArgs e)
        {
            // COMPRUEBA EL VALOR DE LOS CAMPOS
            if (txtInteres.Text == "" || txtMonto.Text == "" || txtCuotas.Text == "")
            {
                MessageBox.Show("LLene los campos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // COMPRUEBA SI EL DIA DE PAGO NO ES QUINCENA
                if (ComprobarQuincena() == false)
                {
                    cuotasGeneradas = new ArrayList();

                    #region Valores de la tabla

                    DataSet oDatos = new DataSet();

                    DataTable oTable = oDatos.Tables.Add();

                    DataColumn oColumn = new DataColumn();

                    oColumn = oTable.Columns.Add("Numero couta");
                    oColumn = oTable.Columns.Add("Fecha de pago");
                    oColumn = oTable.Columns.Add("Monto");
                    oColumn = oTable.Columns.Add("Saldo");

                    #endregion

                    #region Genera las cuotas


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

                            ValidarFechaPago();

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
            ComprobarQuincena();

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

        private void cmbDiaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable oTable = new DataTable();

            DataColumn oColumn = new DataColumn();

            oColumn = oTable.Columns.Add("Numero couta");
            oColumn = oTable.Columns.Add("Fecha de pago");
            oColumn = oTable.Columns.Add("Monto");
            oColumn = oTable.Columns.Add("Saldo");

            dtgCuotas.DataSource = oTable;
        }




    }
}
