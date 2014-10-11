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
    public class Abonos_CuotasPostgres : IAbonos_CuotasSQL
    {

        public bool IsError { get; set; }

        public string ErrorDescripcion { get; set; }

        public void InsertarAbono_Cuotas(int id_cuota, double monto, DateTime fecha_abono)
        {

            var sql = new StringBuilder();
            sql.AppendLine("insert into abonos_cuotas (id_cuota, monto, fecha_abono) values (@id_cuota,@monto,@fecha_abono)");

            var parametros = new List<NpgsqlParameter>
            {  
                new NpgsqlParameter
                {
                    ParameterName = "id_cuota",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_cuota
                },
                new NpgsqlParameter
                {
                    ParameterName = "monto",
                    NpgsqlDbType = NpgsqlDbType.Double,
                    NpgsqlValue = monto
                },
                new NpgsqlParameter
                {
                    ParameterName = "fecha_abono",
                    NpgsqlDbType = NpgsqlDbType.Date,
                    NpgsqlValue = fecha_abono
                }
               
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }


        }

        public void EliminarAbono_Cuotas_Id(string id)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from abonos_cuotas where id=@id");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id
                },
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        public void EliminarAbono_Cuotas_Id_Cuota(string id_cuota)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from abonos_cuotas where id_cuota=@id_cuota");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id_cuota",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_cuota
                },
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        public DataSet TraerAbono_Cuotas(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select * from abonos_cuotas");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine(" where id_cuota=@id_cuota order by id asc");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id_cuota",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;


        }


        public DataSet TraerCantidad_Abonos(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select count('id') from abonos_cuotas");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine(" where id_cuota=@id_cuota");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id_cuota",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;


        }


        public DataSet TraerSuma_Abonos(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select sum(monto) from abonos_cuotas");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine(" where id_cuota=@id_cuota");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id_cuota",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;


        }


        public DataSet TraerAbonos_Cuotas_RangoFechas(string fecha_desde, string fecha_hasta)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select abonos_cuotas.id AS id_abono, " +
                            "abonos_cuotas.id_cuota AS id_cuota, " +
                            "abonos_cuotas.monto AS monto_abono, " +
                            "abonos_cuotas.fecha_abono, " +
                            "prestamos_cuotas.num_cuota, " +
                            "prestamos.id AS id_prestamo, " +
                            "clientes.cedula AS cedula_cliente, " +
                            "clientes.nombre AS nombre_cliente " +
                            "from abonos_cuotas,prestamos_cuotas,prestamos,clientes");

            if (!string.IsNullOrEmpty(fecha_desde) || !string.IsNullOrEmpty(fecha_hasta))
            {
                sql.AppendLine(" where abonos_cuotas.id_cuota = prestamos_cuotas.id AND " +
                                "prestamos_cuotas.id_prestamos = prestamos.id AND " +
                                "prestamos.cliente = clientes.cedula AND " +
                                "abonos_cuotas.fecha_abono between @fecha_desde and @fecha_hasta");
            }
            var parametros = new List<NpgsqlParameter>
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

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;

        }








    }
}
