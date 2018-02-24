using Npgsql;
using NpgsqlTypes;
using Prestamos.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Prestamos.Logica.Postgres
{
    public class Prestamos_CuotasPostgres : IPrestamos_CuotasSQL
    {
        public bool IsError
        {
            get;
            set;
        }
        public string ErrorDescripcion
        {
            get;
            set;
        }
        public void InsertarPrestamo_Cuotas(int prestamo, int num_Cuota, DateTime fecha_pactada, double monto, double saldo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("insert into prestamos_cuotas (id_prestamos, num_Cuota, fecha_pactada, monto, saldo) values (@id_prestamos,@num_Cuota,@fecha_pactada,@monto,@saldo)");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id_prestamos",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = prestamo
				},
				new NpgsqlParameter
				{
					ParameterName = "num_Cuota",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = num_Cuota
				},
				new NpgsqlParameter
				{
					ParameterName = "fecha_pactada",
					NpgsqlDbType = NpgsqlDbType.Timestamp,
					NpgsqlValue = fecha_pactada
				},
				new NpgsqlParameter
				{
					ParameterName = "monto",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = monto
				},
				new NpgsqlParameter
				{
					ParameterName = "saldo",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = saldo
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EditarPrestamoCuotas(int id, DateTime fecha_pago, bool pago, string opcion)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos_cuotas set fecha_pago=@fecha_pago, pago=@pago where id=@id");
            if (!string.IsNullOrEmpty(opcion))
            {
                stringBuilder.Replace("@fecha_pago", "null");
            }
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = id
				},
				new NpgsqlParameter
				{
					ParameterName = "fecha_pago",
					NpgsqlDbType = NpgsqlDbType.Timestamp,
					NpgsqlValue = fecha_pago
				},
				new NpgsqlParameter
				{
					ParameterName = "pago",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = pago
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EditarPrestamoCuotas_RecargoPrestamo(int id, double monto, double saldo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos_cuotas set monto=@monto, saldo=@saldo where id=@id");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = id
				},
				new NpgsqlParameter
				{
					ParameterName = "monto",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = monto
				},
				new NpgsqlParameter
				{
					ParameterName = "saldo",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = saldo
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EditarPrestamoCuotas_FechaPactada(int id, DateTime fecha_pactada)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos_cuotas set fecha_pactada=@fecha_pactada where id=@id");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = id
				},
				new NpgsqlParameter
				{
					ParameterName = "fecha_pactada",
					NpgsqlDbType = NpgsqlDbType.Date,
					NpgsqlValue = fecha_pactada
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EliminarPrestamo(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("delete from prestamos_cuotas where id_prestamos=@id");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = filtro
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EliminarCuota(string id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos_cuotas set eliminado=@eliminado where id=@id");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = id
				},
                 new NpgsqlParameter
				{
					ParameterName = "eliminado",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = true
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void CancelarCuotasPrestamo(int prestamoId)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos_cuotas set pago=@pago, saldo=@saldo where id_prestamos=@prestamoId");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
	        {
	            new NpgsqlParameter
	            {
	                ParameterName = "prestamoId",
	                NpgsqlDbType = NpgsqlDbType.Integer,
	                NpgsqlValue = prestamoId
	            },
	            new NpgsqlParameter
	            {
	                ParameterName = "saldo",
	                NpgsqlDbType = NpgsqlDbType.Integer,
	                NpgsqlValue = 0
	            },
	            new NpgsqlParameter
	            {
	                ParameterName = "pago",
	                NpgsqlDbType = NpgsqlDbType.Boolean,
	                NpgsqlValue = true
	            }
	        };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public DataSet TraerPrestamoCuotas(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from prestamos_cuotas");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(filtro))
            {
                stringBuilder.AppendLine("where id_prestamos=@id_prestamos order by num_cuota asc");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "id_prestamos",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = filtro
                });
            }
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }
        public DataSet TraerPrestamoCuotas_Pago(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from prestamos_cuotas");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(filtro))
            {
                stringBuilder.AppendLine("where id_prestamos=@id_prestamos and pago=true order by num_cuota asc ");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "id_prestamos",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = filtro
                });
            }
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }
        public DataSet TraerPrestamoCuotas_NoPago(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from prestamos_cuotas");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(filtro))
            {
                stringBuilder.AppendLine(" where id_prestamos=@id_prestamos and pago=false order by num_cuota asc ");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "id_prestamos",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = filtro
                });
            }
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }
        public DataSet TraerSecuencia()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Concat(new object[]
			{
				"SELECT  nextval('",
				'"',
				"Prestamo_id_seq",
				'"',
				"')"
			}));
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString());
        }
        public DataSet TraerPrestamoCuotas_FechaPactada(string fecha)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select cl.cedula,cl.nombre,pre.id as id_prestamo,pc.id as pc_id,pc.num_cuota,pc.fecha_pactada,pc.monto,pc.saldo ");
            stringBuilder.AppendLine(" from prestamos_cuotas as pc,clientes as cl,prestamos as pre ");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(fecha))
            {
                stringBuilder.AppendLine(" where ");
                stringBuilder.AppendLine("cl.cedula=pre.cliente and pc.id_prestamos=pre.id and cl.moroso=false ");
                stringBuilder.AppendLine(" and fecha_pactada<=@fecha_pactada and pago=false and (pre.eliminado=false or pre.eliminado IS NULL) order by id_prestamo,num_cuota asc ");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "fecha_pactada",
                    NpgsqlDbType = NpgsqlDbType.Timestamp,
                    NpgsqlValue = Convert.ToDateTime(fecha)
                });
            }
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }
        public DataSet TraerPrestamoCuotas_FechaPago(string fecha_desde, string fecha_hasta)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT prestamos_cuotas.id AS id_cuota, prestamos_cuotas.id_prestamos AS id_prestamo, prestamos_cuotas.fecha_pactada AS fecha_pactada_cuota, prestamos_cuotas.fecha_pago AS fecha_pago_cuota, prestamos_cuotas.monto AS monto_cuota, prestamos_cuotas.num_cuota, prestamos_cuotas.pago AS pago_cuota, prestamos_cuotas.saldo AS saldo_cuota, clientes.nombre AS nombre_cliente, clientes.cedula AS cedula_cliente, (Select count('id') from abonos_cuotas  where id_cuota=prestamos_cuotas.id) as total FROM prestamos_cuotas,prestamos,clientes");
            if (!string.IsNullOrEmpty(fecha_desde) || !string.IsNullOrEmpty(fecha_hasta))
            {
                stringBuilder.AppendLine(" where prestamos_cuotas.id_prestamos=prestamos.id and prestamos.cliente = clientes.cedula and  prestamos_cuotas.fecha_pago between @fecha_desde and @fecha_hasta order by prestamos_cuotas.fecha_pago asc");
            }
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "fecha_desde",
					NpgsqlDbType = NpgsqlDbType.Date,
					NpgsqlValue = Convert.ToDateTime(fecha_desde)
				},
				new NpgsqlParameter
				{
					ParameterName = "fecha_hasta",
					NpgsqlDbType = NpgsqlDbType.Date,
					NpgsqlValue = Convert.ToDateTime(fecha_hasta)
				}
			};
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), parametros);
        }
        public DataSet TraerPrestamoCuotas_Cliente_Prestamo(string cedula, string prestamo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT prestamos_cuotas.id AS id_cuota, prestamos_cuotas.id_prestamos AS id_prestamo, prestamos_cuotas.fecha_pactada AS fecha_pactada_cuota, prestamos_cuotas.fecha_pago AS fecha_pago_cuota, prestamos_cuotas.monto AS monto_cuota, prestamos_cuotas.num_cuota, prestamos_cuotas.pago AS pago_cuota, prestamos_cuotas.saldo AS saldo_cuota, clientes.nombre AS nombre_cliente, clientes.cedula AS cedula_cliente, (Select count('id') from abonos_cuotas  where id_cuota=prestamos_cuotas.id) as total_abonos FROM prestamos_cuotas,prestamos,clientes");
            stringBuilder.AppendLine(" where prestamos_cuotas.id_prestamos = prestamos.id AND prestamos.cliente = clientes.cedula ");
            if (!string.IsNullOrEmpty(cedula))
            {
                stringBuilder.AppendLine("and clientes.cedula = @cedula ");
            }
            if (!string.IsNullOrEmpty(prestamo))
            {
                stringBuilder.AppendLine("and prestamos_cuotas.id_prestamos = @oPrestamo ");
            }
            stringBuilder.AppendLine(" order by  prestamos_cuotas.id_prestamos,prestamos_cuotas.num_cuota asc");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "cedula",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = cedula
				},
				new NpgsqlParameter
				{
					ParameterName = "oPrestamo",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = prestamo
				}
			};
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), parametros);
        }
    }
}
