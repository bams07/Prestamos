using Prestamos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
namespace Prestamos.Formatos
{
	public class DClientes
	{
		public static List<EClientes> ObtenerClientes()
		{
			ClientesCL clientesCL = new ClientesCL();
			DataSet dataSet = clientesCL.TraerClientes("");
			List<EClientes> list = new List<EClientes>();
			foreach (DataRow dataRow in dataSet.Tables[0].Rows)
			{
				list.Add(new EClientes
				{
					cedula = Convert.ToString(dataRow.ItemArray[0]),
					nombre = Convert.ToString(dataRow.ItemArray[1]),
					direccion = Convert.ToString(dataRow.ItemArray[2]),
					telefono = Convert.ToString(dataRow.ItemArray[3]),
					celular = Convert.ToString(dataRow.ItemArray[4])
				});
			}
			return list;
		}
	}
}
