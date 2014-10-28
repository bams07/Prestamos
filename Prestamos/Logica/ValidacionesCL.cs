using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prestamos.Logica
{
    public static class ValidacionesCL
    {

        #region VALIDACION FECHAS

        // COMPRUEBA LA QUINCENA Y DEVUELVE UN FALSE SI LA FECHA NO ES DE TIPO QUINCENA O QUINCENA ESPECIAL
        public static bool validarQuincena(int dia, int mes, int ano, int tipo)
        {

            #region COMPRUEBA LA QUINCENA

            if (tipo == 3)
            {

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
                    if (DateTime.IsLeapYear(ano))
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

            #endregion

            #region COMPRUEBA LA QUINCENA ESPECIAL

            if (tipo == 4)
            {

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
                            if (DateTime.IsLeapYear(ano))
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

            #endregion

            return false;

        }

        // DEVUELVE ELVALOR EN DIAS DE CADA FORMA DE PAGO YA SEA DIARIO = 1 DIA, SEMANAL = 7 DIAS, MENSUAL = 1 MES 
        public static DateTime validarFechaPago(int dia, int mes, int ano, DateTime fecha, int tipo)
        {

            #region CALCULA LA FECHA PARA DIAS

            if (tipo == 0)
            {

                return fecha.AddDays(1);

            }

            #endregion

            #region CALCULA LA FECHA PARA DIAS EXCLUYE EL DOMINGO

            if (tipo == 6)
            {
                if (fecha.DayOfWeek.ToString() == "Saturday")
                {
                    return fecha.AddDays(2);

                }
                else
                {

                    return fecha.AddDays(1);

                }


            }

            #endregion

            #region CALCULA LA FECHA PARA LA SEMANAS

            if (tipo == 1)
            {
                return fecha.AddDays(7);
            }


            #endregion

            #region CALCULA LA FEHCA BISEMANAL

            if (tipo == 2)
            {
                return fecha.AddDays(14);
            }

            #endregion

            #region CALCULA LA FECHA PARA LAS QUINCENAS

            if (tipo == 3)
            {

                // CALCULA LA FECHA PARA ESTOS MESESS


                //MESES CON DIAS 31
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {

                    if (dia == 31)
                    {

                        return fecha.AddDays(15);

                    }

                    if (dia == 15)
                    {

                        return fecha.AddDays(16);

                    }


                }
                //MESES CON DIAS 30
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia == 30)
                    {
                        return fecha.AddDays(15);

                    }

                    if (dia == 15)
                    {
                        return fecha.AddDays(15);

                    }

                }
                //MESES CON DIAS 28 O 29 
                else if (mes == 2)
                {
                    if (DateTime.IsLeapYear(ano))
                    {
                        if (dia == 29)
                        {
                            return fecha.AddDays(15);
                        }

                        if (dia == 15)
                        {
                            return fecha.AddDays(14);
                        }

                    }
                    else
                    {

                        if (dia == 28)
                        {
                            return fecha.AddDays(15);

                        }

                        if (dia == 15)
                        {

                            return fecha.AddDays(13);

                        }

                    }


                }
            }
            #endregion

            #region CALCULA LA FECHA PARA LAS QUINCENAS ESPECIALES

            if (tipo == 4)
            {

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia == 30)
                    {
                        return fecha.AddDays(16);
                    }
                    if (dia == 15)
                    {
                        return fecha.AddDays(15);
                    }
                }
                else
                {
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        if (dia == 30)
                        {
                            return fecha.AddDays(15);
                        }
                        if (dia == 15)
                        {
                            return fecha.AddDays(15);
                        }
                    }
                    else
                    {
                        if (mes == 2)
                        {
                            if (DateTime.IsLeapYear(ano))
                            {
                                if (dia == 29)
                                {
                                    return fecha.AddDays(15);
                                }
                                if (dia == 15)
                                {
                                    return fecha.AddDays(14);
                                }
                            }
                            else
                            {
                                if (dia == 28)
                                {
                                    return fecha.AddDays(15);
                                }
                                if (dia == 15)
                                {
                                    return fecha.AddDays(13);
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region CALCULA LA FECHA PARA LOS MESES

            if (tipo == 5)
            {


                return fecha.AddMonths(1);

            }

            #endregion

            return fecha.AddDays(1);

        }


        // VALIDA EL DIA PAGO Y DEVUELVE UN INDEX RESPECTIVO CON ESTE DIA PAGO DIARIO = 0 , SEMANAL = 1 ...
        public static int ValidarDiaPagoIndex(string dia_pago)
        {

            if (dia_pago == "Diario")
            {

                return 0;
            }

            if (dia_pago == "Semanal")
            {

                return 1;
            }

            if (dia_pago == "Bisemanal")
            {

                return 2;
            }

            if (dia_pago == "Quincenal")
            {

                return 3;
            }

            if (dia_pago == "Quincena especial")
            {
                return 4;
            }

            if (dia_pago == "Mensual")
            {

                return 5;
            }
            if (dia_pago == "Diario N/Domingos")
            {

                return 6;
            }



            return 0;


        }

        #endregion

        #region VALIDACION CAMPOS TEXTO

        // VALIDA SOLO NUMEROS Y COMAS EN LOS CAMPOS DE TEXTO
        public static bool ValidarSoloNumeros(string valor)
        {
            Regex soloNumeros = new Regex("^[0-9 ,]*$");

            if (soloNumeros.IsMatch(valor))
            {
                return true;
            }

            return false;
        }


        #endregion

    }
}
