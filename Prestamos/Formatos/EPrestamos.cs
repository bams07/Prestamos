using Prestamos.Logica;
using System;
using System.Data;
namespace Prestamos.Formatos
{
	public class EPrestamos
	{
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
		public string ticket
		{
			get
			{
				string result;
				if (this.Abonos() == "")
				{
					result = string.Concat(new object[]
					{
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
						"\nTotal : ¢",
						this.totalPrestamo,
						"\nSaldo anterior: ¢",
						Convert.ToDouble(this.saldoPretamoAnterior),
						"\nMonto: ¢",
						Convert.ToDouble(this.montoAbono),
						"\nSaldo actual: ¢",
						Convert.ToDouble(this.saldoPrestamo)
					});
				}
				else
				{
					result = string.Concat(new object[]
					{
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
						"\nTotal : ¢",
						this.totalPrestamo,
						"\nSaldo anterior: ¢",
						Convert.ToDouble(this.saldoPretamoAnterior),
						"\nMonto: ¢",
						Convert.ToDouble(this.montoAbono),
						"\nSaldo actual: ¢",
						Convert.ToDouble(this.saldoPrestamo),
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
			if (dataTable.Rows.Count == 0)
			{
				result = "";
			}
			else
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					string abonosCuota = this.abonosCuota;
					this.abonosCuota = string.Concat(new string[]
					{
						abonosCuota,
						Convert.ToDateTime(dataRow.ItemArray.GetValue(3).ToString()).ToShortDateString(),
						" - ¢",
						dataRow.ItemArray.GetValue(2).ToString(),
						"\n"
					});
				}
				result = this.abonosCuota;
			}
			return result;
		}
	}
}
