using Npgsql;
using NpgsqlTypes;
using Prestamos.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Prestamos.Formatos
{
    public class DPrestamos
    {
        public static DataSet TraerPrestamosClientes(string cliente, string prestamo, string fecha_desde, string fecha_hasta)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select  clientes.cedula,  clientes.nombre, prestamos.id, prestamos.fecha, prestamos.monto,  prestamos.interes,  prestamos.cuotas,  prestamos.saldo,  prestamos.total from clientes,prestamos where clientes.cedula = prestamos.cliente");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(fecha_desde) || !string.IsNullOrEmpty(fecha_hasta))
            {
                stringBuilder.AppendLine(" and fecha between @fecha_desde and @fecha_hasta");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "fecha_desde",
                    NpgsqlDbType = NpgsqlDbType.Date,
                    NpgsqlValue = Convert.ToDateTime(fecha_desde)
                });
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "fecha_hasta",
                    NpgsqlDbType = NpgsqlDbType.Date,
                    NpgsqlValue = Convert.ToDateTime(fecha_hasta)
                });
            }
            if (!string.IsNullOrEmpty(cliente))
            {
                stringBuilder.AppendLine(" and clientes.cedula=@cedula");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "cedula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = cliente
                });
            }
            if (!string.IsNullOrEmpty(prestamo))
            {
                stringBuilder.AppendLine(" and prestamos.id=@id");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = prestamo
                });
            }
            stringBuilder.AppendLine(" order by prestamos.id asc ");

            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }
        public static List<EPrestamos> ObtenerPrestamos(string cliente, string prestamo, string fecha_desde, string fecha_hasta)
        {
            DataSet dataSet = DPrestamos.TraerPrestamosClientes(cliente, prestamo, fecha_desde, fecha_hasta);
            List<EPrestamos> list = new List<EPrestamos>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                list.Add(new EPrestamos
                {
                    clientePrestamo = Convert.ToString(dataRow.ItemArray[0]),
                    nombreCliente = Convert.ToString(dataRow.ItemArray[1]),
                    prestamo = Convert.ToString(dataRow.ItemArray[2]),
                    fechaPrestamo = Convert.ToDateTime(dataRow.ItemArray[3]),
                    montoPrestamo = Convert.ToDouble(dataRow.ItemArray[4]),
                    interesPrestamo = Convert.ToDouble(dataRow.ItemArray[5]),
                    cuotasPrestamos = Convert.ToString(dataRow.ItemArray[6]),
                    saldoPrestamo = Convert.ToDouble(dataRow.ItemArray[7]),
                    totalPrestamo = Convert.ToDouble(dataRow.ItemArray[8])
                });
            }
            return list;
        }
    }
}
