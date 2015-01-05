using Npgsql;
using NpgsqlTypes;
using Prestamos.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Prestamos.Logica.Postgres
{
    public class PrestamosPostgres : IPrestamosSQL
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
        public void InsertarPrestamo(int prestamo, DateTime fecha, string cliente, double monto, double interes, int cuotas, double saldo, double total, bool recargo, int dia_pago)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("insert into prestamos (id, fecha, cliente, monto, interes, cuotas, saldo,total,recargo,dia_pago) values (@id,@fecha,@cliente,@monto,@interes,@cuotas,@saldo,@total,@recargo,@dia_pago)");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = prestamo
				},
				new NpgsqlParameter
				{
					ParameterName = "fecha",
					NpgsqlDbType = NpgsqlDbType.Timestamp,
					NpgsqlValue = fecha
				},
				new NpgsqlParameter
				{
					ParameterName = "cliente",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = cliente
				},
				new NpgsqlParameter
				{
					ParameterName = "monto",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = monto
				},
				new NpgsqlParameter
				{
					ParameterName = "interes",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = interes
				},
				new NpgsqlParameter
				{
					ParameterName = "cuotas",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = cuotas
				},
				new NpgsqlParameter
				{
					ParameterName = "saldo",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = saldo
				},
				new NpgsqlParameter
				{
					ParameterName = "total",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = total
				},
				new NpgsqlParameter
				{
					ParameterName = "recargo",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = recargo
				},
				new NpgsqlParameter
				{
					ParameterName = "dia_pago",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = dia_pago
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EditarPrestamo(int id, double saldo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos set saldo=@saldo where id=@id");
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
        public void EditarPrestamo_Recargo(int id, double saldo, double totalPrestamo, bool recargo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos set saldo=@saldo, total=@total, recargo=@recargo where id=@id");
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
					ParameterName = "saldo",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = saldo
				},
				new NpgsqlParameter
				{
					ParameterName = "total",
					NpgsqlDbType = NpgsqlDbType.Double,
					NpgsqlValue = totalPrestamo
				},
				new NpgsqlParameter
				{
					ParameterName = "recargo",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = recargo
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EditarPrestamo_DiaPago(int id, int dia_pago)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update prestamos set dia_pago=@dia_pago where id=@id");
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
					ParameterName = "dia_pago",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = dia_pago
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
            stringBuilder.AppendLine("delete from prestamos where id=@id");
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
        public DataSet TraerPrestamo(string cliente, bool recargo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from prestamos");
            stringBuilder.AppendLine("where cliente=@cliente and (recargo=false or recargo=@recargo) order by id asc");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "cliente",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = cliente
				},
				new NpgsqlParameter
				{
					ParameterName = "recargo",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = recargo
				}
			};
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), parametros);
        }
        public DataSet TraerPrestamo_planilla(string cliente, string prestamo, bool recargo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from prestamos");
            stringBuilder.AppendLine("where cliente=@cliente and id=@prestamo and (recargo=false or recargo=@recargo) order by id asc");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "cliente",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = cliente
				},
				new NpgsqlParameter
				{
					ParameterName = "prestamo",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = prestamo
				},
				new NpgsqlParameter
				{
					ParameterName = "recargo",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = recargo
				}
			};
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), parametros);
        }
        public DataSet TraerPrestamoSaldo(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select saldo from prestamos");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(filtro))
            {
                stringBuilder.AppendLine("where id=@id");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = Convert.ToInt32(filtro)
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

        // TRAE TODOS LOS PRESTAMOS NO CANCELADOS CON LA INFORMACION RESPECTIVA DEL CLIENTE
        public DataSet TraerPrestamosNoCancelados()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT clientes.cedula,  clientes.nombre, prestamos.id, prestamos.fecha, prestamos.monto,  prestamos.interes,  prestamos.cuotas,  prestamos.saldo,  prestamos.total from clientes,prestamos ");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();

            stringBuilder.AppendLine("WHERE clientes.cedula = prestamos.cliente AND prestamos.saldo > 0 ");

            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }

        // TRAE LA FECHA FINAL DEL PRESTAMO
        public DataSet TraerFechaFinalPrestamo(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select fecha_pactada from prestamos_cuotas");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(filtro))
            {
                stringBuilder.AppendLine("where id_prestamos=@id order by id desc limit 1 ");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = Convert.ToInt32(filtro)
                });
            }
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }


        public DataSet TraerPrestamoSaldoTotal()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT SUM(saldo) FROM prestamos");

            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString());
        }
    }
}
