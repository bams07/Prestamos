using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Datos;

namespace Prestamos.Logica.Postgres
{
    public class GastosPostgres : IGastosSQL
    {

        public bool IsError { get; set; }

        public string ErrorDescripcion { get; set; }

        public void InsertarGasto(string descripcion, double monto, DateTime fecha)
        {

            var sql = new StringBuilder();
            sql.AppendLine("insert into gastos (descripcion,monto,fecha) values (@descripcion,@monto,@fecha)");

            var parametros = new List<NpgsqlParameter>
            {  
                new NpgsqlParameter
                {
                    ParameterName = "descripcion",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = descripcion
                },
                  new NpgsqlParameter
                {
                    ParameterName = "monto",
                    NpgsqlDbType = NpgsqlDbType.Double,
                    NpgsqlValue = monto
                },
                  new NpgsqlParameter
                {
                    ParameterName = "fecha",
                    NpgsqlDbType = NpgsqlDbType.Timestamp,
                    NpgsqlValue = fecha
                }
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }


        }

        public void EditarGasto(int id, string descripcion)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update gastos set descripcion=@descripcion where id=@id");


            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id
                },
                new NpgsqlParameter
                {
                    ParameterName = "descripcion",
                    NpgsqlDbType = NpgsqlDbType.Double,
                    NpgsqlValue = descripcion
                }
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        public void EliminarGasto(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from gastos where id=@id");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = filtro
                },
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }



        }

        public DataSet TraerGasto(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select * from gastos ");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where id=@id ");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;



        }


        public DataSet TraerGastoRangoFecha(string fecha_desde, string fecha_hasta)
        {
            var sql = new StringBuilder();

            sql.AppendLine("Select * from gastos");

            if (!string.IsNullOrEmpty(fecha_desde) || !string.IsNullOrEmpty(fecha_hasta))
            {
                sql.AppendLine(" where fecha between @fecha_desde and @fecha_hasta ");
            }

            var parametros = new List<NpgsqlParameter>
            {

                 new NpgsqlParameter
                    {
                        ParameterName = "fecha_desde",
                        NpgsqlDbType = NpgsqlDbType.Timestamp,
                        NpgsqlValue = Convert.ToDateTime(fecha_desde)
                    },

                    new NpgsqlParameter
                    {
                        ParameterName = "fecha_hasta",
                        NpgsqlDbType = NpgsqlDbType.Timestamp,
                        NpgsqlValue = Convert.ToDateTime(fecha_hasta)
                    }

            };

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;

        }



    }
}
