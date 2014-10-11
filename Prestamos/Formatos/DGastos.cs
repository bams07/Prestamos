using Prestamos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
namespace Prestamos.Formatos
{
	public class DGastos
	{
		public static List<EGastos> ObtenerGastos()
		{
			GastosCL gastosCL = new GastosCL();
			DataSet dataSet = gastosCL.TraerGasto("");
			List<EGastos> list = new List<EGastos>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				list.Add(new EGastos
				{
					id = Convert.ToInt32(dataRow.ItemArray[0]),
					descripcion = Convert.ToString(dataRow.ItemArray[1]),
					monto = Convert.ToDouble(dataRow.ItemArray[2]),
					fecha = Convert.ToDateTime(dataRow.ItemArray[3])
				});
			}
			return list;
		}
		public static List<EGastos> ObtenerGastos_RangoFecha(string fecha_desde, string fecha_hasta)
		{
			GastosCL gastosCL = new GastosCL();
			DataSet dataSet = gastosCL.TraerGastoRangoFecha(fecha_desde, fecha_hasta);
			List<EGastos> list = new List<EGastos>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				list.Add(new EGastos
				{
					id = Convert.ToInt32(dataRow.ItemArray[0]),
					descripcion = Convert.ToString(dataRow.ItemArray[1]),
					monto = Convert.ToDouble(dataRow.ItemArray[2]),
					fecha = Convert.ToDateTime(dataRow.ItemArray[3])
				});
			}
			return list;
		}
	}
}
