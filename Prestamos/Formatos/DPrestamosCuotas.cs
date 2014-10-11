using Prestamos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
namespace Prestamos.Formatos
{
	public class DPrestamosCuotas
	{
		public static List<ECuotas> ObtenerCuotas(string cedula, string prestamo)
		{
			Prestamos_CuotasCL prestamos_CuotasCL = new Prestamos_CuotasCL();
			DataSet dataSet = prestamos_CuotasCL.TraerPrestamoCuotas_Cliente_Prestamo(cedula, prestamo);
			List<ECuotas> list = new List<ECuotas>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				if (Convert.ToString(dataRow.ItemArray[3]) == "")
				{
					list.Add(new ECuotas
					{
						id_cuota = Convert.ToInt32(dataRow.ItemArray[0]),
						id_prestamo = Convert.ToInt32(dataRow.ItemArray[1]),
						fecha_pactada_cuota = string.Format("{0:d}", Convert.ToDateTime(Convert.ToDateTime(dataRow.ItemArray[2]))),
						fecha_pago_cuota = Convert.ToString(dataRow.ItemArray[3]),
						monto_cuota = Convert.ToDouble(dataRow.ItemArray[4]),
						numero_cuota = Convert.ToInt32(dataRow.ItemArray[5]),
						pago_cuota = Convert.ToBoolean(dataRow.ItemArray[6]),
						saldo_cuota = Convert.ToDouble(dataRow.ItemArray[7]),
						nombre_cliente = Convert.ToString(dataRow.ItemArray[8]),
						cedula_cliente = Convert.ToString(dataRow.ItemArray[9]),
						total_abonos = Convert.ToInt32(dataRow.ItemArray[10])
					});
				}
				else
				{
					list.Add(new ECuotas
					{
						id_cuota = Convert.ToInt32(dataRow.ItemArray[0]),
						id_prestamo = Convert.ToInt32(dataRow.ItemArray[1]),
						fecha_pactada_cuota = string.Format("{0:d}", Convert.ToDateTime(Convert.ToDateTime(dataRow.ItemArray[2]))),
						fecha_pago_cuota = string.Format("{0:d}", Convert.ToDateTime(Convert.ToDateTime(dataRow.ItemArray[3]))),
						monto_cuota = Convert.ToDouble(dataRow.ItemArray[4]),
						numero_cuota = Convert.ToInt32(dataRow.ItemArray[5]),
						pago_cuota = Convert.ToBoolean(dataRow.ItemArray[6]),
						saldo_cuota = Convert.ToDouble(dataRow.ItemArray[7]),
						nombre_cliente = Convert.ToString(dataRow.ItemArray[8]),
						cedula_cliente = Convert.ToString(dataRow.ItemArray[9]),
						total_abonos = Convert.ToInt32(dataRow.ItemArray[10])
					});
				}
			}
			return list;
		}
	}
}
