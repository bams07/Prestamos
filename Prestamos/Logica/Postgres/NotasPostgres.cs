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
    public class NotasPostgres : INotasSQL
    {

        public bool IsError { get; set; }

        public string ErrorDescripcion { get; set; }

        public void InsertarNota(string nota, DateTime fecha_creacion)
        {

            var sql = new StringBuilder();
            sql.AppendLine("insert into notas (nota,fecha_creacion) values (@nota,@fecha_creacion)");

            var parametros = new List<NpgsqlParameter>
            {  
                new NpgsqlParameter
                {
                    ParameterName = "nota",
                    NpgsqlDbType = NpgsqlDbType.Text,
                    NpgsqlValue = nota
                },
                  new NpgsqlParameter
                {
                    ParameterName = "fecha_creacion",
                    NpgsqlDbType = NpgsqlDbType.Timestamp,
                    NpgsqlValue = fecha_creacion
                }
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }


        }

        public void EditarNota(int id, string nota, DateTime fecha_edicion)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update notas set nota=@nota,fecha_edicion=@fecha_edicion where id=@id");


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
                    ParameterName = "nota",
                    NpgsqlDbType = NpgsqlDbType.Text,
                    NpgsqlValue = nota
                },
                 new NpgsqlParameter
                {
                    ParameterName = "fecha_edicion",
                    NpgsqlDbType = NpgsqlDbType.Timestamp,
                    NpgsqlValue = fecha_edicion
                }
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        public void EliminarNota(int id)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from notas where id=@id");

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

        public DataSet TraerNotas(int id)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select * from notas ");

            var parametros = new List<NpgsqlParameter>();

            if (id != 0)
            {
                sql.AppendLine("where id=@id ");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = id
                    });
            }

            sql.AppendLine("order by fecha_creacion desc");

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;



        }
    }
}
