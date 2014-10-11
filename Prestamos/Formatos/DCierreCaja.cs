using Prestamos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
namespace Prestamos.Formatos
{
	public class DCierreCaja
	{
		public static List<ECierreCaja> ObtenerCuotasPagadas(string fecha_desde, string fecha_hasta)
		{
			Prestamos_CuotasCL prestamos_CuotasCL = new Prestamos_CuotasCL();
			DataSet dataSet = prestamos_CuotasCL.TraerPrestamoCuotas_FechaPago(fecha_desde, fecha_hasta);
			List<ECierreCaja> list = new List<ECierreCaja>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				if (Convert.ToInt32(dataRow.ItemArray[10]) == 0)
				{
					list.Add(new ECierreCaja
					{
						id_cuota = Convert.ToInt32(dataRow.ItemArray[0]),
						id_prestamo = Convert.ToInt32(dataRow.ItemArray[1]),
						fecha_pactada_cuota = Convert.ToDateTime(dataRow.ItemArray[2]),
						fecha_pago_cuota = Convert.ToDateTime(dataRow.ItemArray[3]),
						monto_cuota = Convert.ToDouble(dataRow.ItemArray[4]),
						num_cuota = Convert.ToInt32(dataRow.ItemArray[5]),
						pago_cuota = Convert.ToBoolean(dataRow.ItemArray[6]),
						saldo_cuota = Convert.ToDouble(dataRow.ItemArray[7]),
						nombre_cliente = Convert.ToString(dataRow.ItemArray[8]),
						cedula_cliente = Convert.ToString(dataRow.ItemArray[9])
					});
				}
			}
			return list;
		}
	}
}
