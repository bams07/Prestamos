using Prestamos.Logica;
using System;
using System.Configuration;
using System.Data;
using System.Globalization;
namespace Prestamos.Formatos
{
    public class EPrestamos
    {

        #region VARIABLES

        public NumberFormatInfo Moneda()
        {
            NumberFormatInfo moneda = new CultureInfo(ConfigurationManager.AppSettings["DefaultCulture"], false).NumberFormat;

            return moneda;
        }

        public DateTime fechaAbono
        {
            get;
            set;
        }
        public int numeroCuota
        {
            get;
            set;
        }
        public int idCuota
        {
            get;
            set;
        }
        public double montoAbono
        {
            get;
            set;
        }
        public DateTime fechaPactada
        {
            get;
            set;
        }
        public string prestamo
        {
            get;
            set;
        }
        public string clientePrestamo
        {
            get;
            set;
        }
        public string nombreCliente
        {
            get;
            set;
        }
        public string telefonoCliente
        {
            get;
            set;
        }
        public string direccionCliente
        {
            get;
            set;
        }
        public DateTime fechaPrestamo
        {
            get;
            set;
        }
        public double montoPrestamo
        {
            get;
            set;
        }
        public double interesPrestamo
        {
            get;
            set;
        }
        public string cuotasPrestamos
        {
            get;
            set;
        }
        public double saldoPrestamo
        {
            get;
            set;
        }
        public double totalPrestamo
        {
            get;
            set;
        }
        public double saldoPretamoAnterior
        {
            get;
            set;
        }
        public DateTime fechaFinalPrestamo
        {
            get;
            set;
        }
        public string abonosCuota
        {
            get;
            set;
        }
        public string encabezado
        {
            get;
            set;
        }

        #endregion

        public string ticket
        {
            get
            {
                string result;
                if (this.Abonos() == "")
                {
                    result = string.Concat(new object[]
					{
                        this.mensajeEncabezado(),
						"Fecha: ",
						this.fechaAbono.ToShortDateString(),
						"\nNombre: ",
						this.nombreCliente,
						"\nTel: ",
						this.telefonoCliente,
						"\nCedula: ",
						this.clientePrestamo,
						"\nDirección: ",
						this.direccionCliente,
						"\nDocumento : 00000",
						this.prestamo,
						"\nFecha final documento: ",
						string.Format("{0:d}", Convert.ToDateTime(this.fechaFinalPrestamo)),
						"\nCuota: ",
						this.numeroCuota,
						"   Fecha cuota: ",
						string.Format("{0:d}", Convert.ToDateTime(this.fechaPactada)),
						"\nTotal : ",
						this.totalPrestamo.ToString("C",Moneda()),
						"\nSaldo anterior: ",
						this.saldoPretamoAnterior.ToString("C",Moneda()),
						"\nMonto: ",
						this.montoAbono.ToString("C",Moneda()),
						"\nSaldo actual: ",
						this.saldoPrestamo.ToString("C",Moneda()),
					});
                }
                else
                {
                    result = string.Concat(new object[]
					{
						this.mensajeEncabezado(),
                        "Fecha: ",
						this.fechaAbono.ToShortDateString(),
						"\nNombre: ",
						this.nombreCliente,
						"\nTel: ",
						this.telefonoCliente,
						"\nCedula: ",
						this.clientePrestamo,
						"\nDirección: ",
						this.direccionCliente,
						"\nDocumento : 00000",
						this.prestamo,
						"\nFecha final documento: ",
						string.Format("{0:d}", Convert.ToDateTime(this.fechaFinalPrestamo)),
						"\nCuota: ",
						this.numeroCuota,
						"   Fecha cuota: ",
						string.Format("{0:d}", Convert.ToDateTime(this.fechaPactada)),
						"\nTotal : ",
						this.totalPrestamo.ToString("C",Moneda()),
						"\nSaldo anterior: ",
						this.saldoPretamoAnterior.ToString("C",Moneda()),
						"\nMonto: ",
						this.montoAbono.ToString("C",Moneda()),
						"\nSaldo actual: ",
						this.saldoPrestamo.ToString("C",Moneda()),
						"\nAbonos a la cuota---------------- \n",
						this.abonosCuota
					});
                }
                return result;
            }
        }

        public string Abonos()
        {
            Abonos_CuotasCL abonos_CuotasCL = new Abonos_CuotasCL();

            DataTable dataTable = abonos_CuotasCL.TraerAbono_Cuotas(this.idCuota.ToString()).Tables[0];

            string result;
            double totalAbonosCuota = 0;

            if (dataTable.Rows.Count == 0)
            {
                return result = "";
            }
            else
            {
                // CICLO QUE RECORRE LOS ABONOS DE LAS CUTOAS 
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    this.saldoPrestamo -= Convert.ToDouble(dataRow["monto"].ToString());

                    totalAbonosCuota += Convert.ToDouble(dataRow["monto"].ToString());


                    this.abonosCuota = string.Concat(new string[]
					{
                        this.abonosCuota,
						Convert.ToDateTime(dataRow["fecha_abono"].ToString()).ToShortDateString(),
						" - ",
                        Convert.ToDouble(dataRow["monto"].ToString()).ToString("C",Moneda()),
						"\n"
					});
                }

                // EN EL CASO DE QUE EXISTAN ABONOS SE VEA REFLEJADO EL SALDO DE LA CUOTA EXISTENTE
                this.saldoPrestamo = this.saldoPretamoAnterior - totalAbonosCuota;

                return result = this.abonosCuota;
            }
            return result;
        }

        public string mensajeEncabezado()
        {
            if (!string.IsNullOrEmpty(encabezado))
            {             
                this.encabezado = string.Format("----------{0}---------- \n", this.encabezado.ToUpper());
            }

            return encabezado;
        }
    }
}
