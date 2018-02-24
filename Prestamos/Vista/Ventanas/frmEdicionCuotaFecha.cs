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
using System.Collections;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmEdicionCuotaFecha : Form
    {
        public DataTable _dCuotas;
        public DataTable _dCuotasGeneradas;
        public int _primerNumeroCuota;
        public double _prestamoSaldo;
        public int _prestamoId;
        public double _valorxcuotas;
        public DateTime _fecha;

        public frmEdicionCuotaFecha(int prestamo, string cliente)
        {
            InitializeComponent();

            this._prestamoId = prestamo;

            TraerCuotas(prestamo);

            lblCliente.Text = cliente;

            lblSaldoPrestamo.Text = this._prestamoSaldo.ToString();

            lblNumeroPrestamo.Text = Convert.ToString("00000" + prestamo);

        }


        // CARGAS LAS CUOTSA
        public void TraerCuotas(int prestamo)
        {

            var oCuotas = new Prestamos_CuotasCL();
            var oPrestamo = new PrestamosCL();

            var oDatos = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString());
            var oDatosPrestamo = oPrestamo.TraerPrestamoSaldo(prestamo.ToString());

            _prestamoSaldo = Convert.ToDouble(oDatosPrestamo.Tables[0].Rows[0].ItemArray[0]);

            _dCuotas = oDatos.Tables[0];

            // OBTIENE EL PRIMER NUMERO DE CUOTA
            _primerNumeroCuota = Convert.ToInt32(_dCuotas.Rows[0]["num_cuota"].ToString());

            dtgCuotas.DataSource = _dCuotas;

        }

        // VALIDA LA FECHA DE PAGO PACTADA, ESTABLECE SU FECHA
        public void ValidarFechaPago()
        {

            #region CALCULA LA FECHA PARA DIAS

            if (cmbDiaPago.SelectedIndex == 0)
            {

                _fecha = _fecha.AddDays(1);

            }

            #endregion

            #region CALCULA LA FECHA PARA LA SEMANAS

            if (cmbDiaPago.SelectedIndex == 1)
            {

                _fecha = _fecha.AddDays(7);

            }


            #endregion

            #region CALCULA LA FECHA PARA LAS QUINCENAS

            if (cmbDiaPago.SelectedIndex == 2)
            {
                int mes = _fecha.Month;
                int dia = _fecha.Day;


                // CALCULA LA FECHA PARA ESTOS MESESS


                //MESES CON DIAS 31
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {

                    if (dia == 31)
                    {

                        _fecha = _fecha.AddDays(15);

                    }

                    if (dia == 15)
                    {

                        _fecha = _fecha.AddDays(16);

                    }


                }

                //MESES CON DIAS 30
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia == 30)
                    {
                        _fecha = _fecha.AddDays(15);

                    }

                    if (dia == 15)
                    {
                        _fecha = _fecha.AddDays(15);

                    }

                }

                //MESES CON DIAS 28 O 29 
                else if (mes == 2)
                {
                    if (DateTime.IsLeapYear(_fecha.Year))
                    {
                        if (dia == 29)
                        {
                            _fecha = _fecha.AddDays(15);
                        }

                        if (dia == 15)
                        {
                            _fecha = _fecha.AddDays(14);
                        }

                    }
                    else
                    {

                        if (dia == 28)
                        {
                            _fecha = _fecha.AddDays(15);

                        }

                        if (dia == 15)
                        {

                            _fecha = _fecha.AddDays(13);

                        }

                    }




                }
            }

            #endregion

            #region CALCULA LA FECHA PARA LOS MESES

            if (cmbDiaPago.SelectedIndex == 3)
            {

                _fecha = _fecha.AddMonths(1);

            }


            #endregion

        }

        // COMPRUEBA QUE LA FECHA SEA DE QUINCENA
        public bool ComprobarQuincena()
        {
            if (cmbDiaPago.SelectedIndex == 2)
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

            return false;

        }


        public void GenerarCuotasPrevias()
        {
            // COMPRUEBA EL VALOR DE LOS CAMPOS
            if (txtCuotas.Text == "")
            {
                MessageBox.Show(@"LLene los campos faltantes", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dia = dtFechaInicial.Value.Day;
                var mes = dtFechaInicial.Value.Month;
                var ano = dtFechaInicial.Value.Year;
                var tipo = ValidacionesCL.ValidarDiaPagoIndex(cmbDiaPago.SelectedItem.ToString());
                var validacionQuincena = ValidacionesCL.validarQuincena(dia, mes, ano, tipo);

                // COMPRUEBA SI EL DIA DE PAGO NO ES QUINCENA
                if (validacionQuincena == false)
                {
                    #region COLUMNAS DE LA TABLA

                    _dCuotasGeneradas = new DataTable();

                    _dCuotasGeneradas.Columns.Add("Numero couta");
                    _dCuotasGeneradas.Columns.Add("Fecha de pago");
                    _dCuotasGeneradas.Columns.Add("Monto");
                    _dCuotasGeneradas.Columns.Add("Saldo");

                    #endregion

                    #region GENERA LAS CUOTAS

                    // TOMA LA FECHA INICIAL
                    _fecha = dtFechaInicial.Value;

                    // EL SALDO ES IGUAL AL TOTAL AL PRINCIPIO
                    var saldoCuotas = _prestamoSaldo;

                    // VARIABLE QUE SE ESTABLECE PARA DECIDIR CUANDO TERMINAR DE CALCULAR
                    var terminarGenerarCuotas = true;

                    // EMPIEZA A CONTAR DESDE EL PRIMER NUMERO DE CUOTA
                    var contNumeroCuota = _primerNumeroCuota;
                    var contMeses = 1;

                    if (saldoCuotas > 0)
                    {
                        // ESTABLECE LA FECHA INICIAL
                        ValidacionesCL.fechaInicial = _fecha;

                        while (terminarGenerarCuotas)
                        {

                            if (saldoCuotas >= Convert.ToDouble(txtCuotas.Text))
                            {
                                _valorxcuotas = Convert.ToDouble(txtCuotas.Text);
                            }
                            else
                            {
                                _valorxcuotas = saldoCuotas;
                                terminarGenerarCuotas = false;
                            }

                            saldoCuotas -= _valorxcuotas;

                            var row = _dCuotasGeneradas.Rows.Add();

                            row["Numero couta"] = contNumeroCuota;
                            row["Fecha de pago"] = _fecha.ToShortDateString();
                            row["Monto"] = _valorxcuotas;
                            row["Saldo"] = saldoCuotas;

                            // LLEVA EL CONTROL DE LOS MESES PARA UNA FECHA ESPECIFICA
                            ValidacionesCL.contadorMeses = contMeses;

                            // CONSULTA LA FECHA SIGUIENTE BASADO EN EL DIA PAGO ESCODIGO
                            _fecha = ValidacionesCL.validarFechaPago(_fecha.Day, _fecha.Month, _fecha.Year, _fecha, tipo);

                            contNumeroCuota++;
                            contMeses++;

                            if (saldoCuotas == 0)
                            {
                                break;
                            }
                        }
                    }

                    #endregion

                    dtgCuotasPrevias.DataSource = _dCuotasGeneradas;

                }
            }
        }

        private void btnGenerarPrevisualzacion_Click(object sender, EventArgs e)
        {
            GenerarCuotasPrevias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var dia = dtFechaInicial.Value.Day;
            var mes = dtFechaInicial.Value.Month;
            var ano = dtFechaInicial.Value.Year;
            var tipo = ValidacionesCL.ValidarDiaPagoIndex(cmbDiaPago.SelectedItem.ToString());
            var validacionQuincena = ValidacionesCL.validarQuincena(dia, mes, ano, tipo);

            if (validacionQuincena == false)
            {
                var oCuotas = new Prestamos_CuotasCL();

                foreach (DataRow item in _dCuotas.Rows)
                {
                    var id = item["id"].ToString();

                    // ELIMINA LA CUOTA EXISTENTE CAMBIANDO EL ESTADO ELIMINADO A TRUE
                    oCuotas.EliminarCuota(id);

                    if (oCuotas.IsError)
                    {
                        MessageBox.Show(oCuotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (!oCuotas.IsError)
                {
                    foreach (DataRow item in _dCuotasGeneradas.Rows)
                    {
                        // INSERTA NUEVAS CUOTAS
                        oCuotas.InsertarPrestamo_Cuotas(
                            _prestamoId,
                            Convert.ToInt32(item["Numero couta"].ToString()),
                            Convert.ToDateTime(item["Fecha de pago"].ToString()),
                            Convert.ToDouble(item["Monto"].ToString()),
                            Convert.ToDouble(item["Saldo"].ToString()));

                        if (oCuotas.IsError)
                        {
                            MessageBox.Show(oCuotas.ErrorDescripcion, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
        }

        private void dtgCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCuotasPrevias.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    dtgCuotasPrevias.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dtgCuotasPrevias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCuotasPrevias.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    dtgCuotas.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

    }
}
