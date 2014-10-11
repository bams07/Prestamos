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
    public partial class frmEdicionCuotaFecha : Form
    {
        DataTable dCuotas;
        DateTime fecha;

        public frmEdicionCuotaFecha(int prestamo, string cliente)
        {
            InitializeComponent();

            TraerCuotas(prestamo);

            lblCliente.Text = cliente;

            lblNumeroPrestamo.Text = Convert.ToString("00000" + prestamo);

        }


        // CARGAS LAS CUOTSA
        public void TraerCuotas(int prestamo)
        {

            Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

            DataSet oDatos = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString());

            dCuotas = oDatos.Tables[0];

            dtgCuotas.DataSource = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString()).Tables[0];

        }

        // VALIDA LA FECHA DE PAGO PACTADA, ESTABLECE SU FECHA
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

            #region CALCULA LA FECHA PARA LAS QUINCENAS

            if (cmbDiaPago.SelectedIndex == 2)
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

            if (cmbDiaPago.SelectedIndex == 3)
            {

                fecha = fecha.AddMonths(1);

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
            if (ComprobarQuincena() == false)
            {
                fecha = dtFechaInicial.Value;

                foreach (DataRow item in dCuotas.Rows)
                {
                    item["fecha_pactada"] = fecha.ToShortDateString();

                    ValidarFechaPago();


                }

                dtgCuotasPrevias.DataSource = dCuotas;
            }
        }

        private void btnGenerarPrevisualzacion_Click(object sender, EventArgs e)
        {
            GenerarCuotasPrevias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarQuincena() == false)
            {
                Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

                foreach (DataRow item in dCuotas.Rows)
                {
                    string id = item["id"].ToString();
                    string fecha_pactada = item["fecha_pactada"].ToString();



                    oCuotas.EditarPrestamoCuotas_FechaPactada(Convert.ToInt32(id), Convert.ToDateTime(fecha_pactada));

                }

                if (oCuotas.IsError)
                {
                    MessageBox.Show(oCuotas.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MessageBox.Show("Cuotas modificas con exito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
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

    }
}
