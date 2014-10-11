using Prestamos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
namespace Prestamos.Formatos
{
	public class DAbonos
	{
		public static List<EAbonos> ObtenerAbonos(string id_cuota)
		{
			Abonos_CuotasCL abonos_CuotasCL = new Abonos_CuotasCL();
			DataSet dataSet = abonos_CuotasCL.TraerAbono_Cuotas(id_cuota);
			List<EAbonos> list = new List<EAbonos>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				list.Add(new EAbonos
				{
					id_abono = Convert.ToInt32(dataRow.ItemArray[0]),
					id_cuota = Convert.ToInt32(dataRow.ItemArray[1]),
					monto_abono = Convert.ToDouble(dataRow.ItemArray[2]),
					fecha_abono = Convert.ToDateTime(dataRow.ItemArray[3])
				});
			}
			return list;
		}
		public static List<EAbonos> ObtenerAbonos_RangoFecha(string fecha_desde, string fecha_hasta)
		{
			Abonos_CuotasCL abonos_CuotasCL = new Abonos_CuotasCL();
			DataSet dataSet = abonos_CuotasCL.TraerAbonos_Cuotas_RangoFechas(fecha_desde, fecha_hasta);
			List<EAbonos> list = new List<EAbonos>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				list.Add(new EAbonos
				{
					id_abono = Convert.ToInt32(dataRow.ItemArray[0]),
					id_cuota = Convert.ToInt32(dataRow.ItemArray[1]),
					monto_abono = Convert.ToDouble(dataRow.ItemArray[2]),
					fecha_abono = Convert.ToDateTime(dataRow.ItemArray[3]),
					num_cuota = Convert.ToInt32(dataRow.ItemArray[4]),
					id_prestamo = Convert.ToInt32(dataRow.ItemArray[5]),
					cedula_cliente = Convert.ToString(dataRow.ItemArray[6]),
					nombre_cliente = Convert.ToString(dataRow.ItemArray[7])
				});
			}
			return list;
		}
	}
}
