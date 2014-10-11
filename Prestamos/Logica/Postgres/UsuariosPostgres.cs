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
    public class UsuariosPostgres : IUsuariosSQL
    {

        public bool IsError { get; set; }

        public string ErrorDescripcion { get; set; }

        public void InsertarUsuario(string cedula, string nombre, string usuario, string contrasena)
        {

            var sql = new StringBuilder();
            sql.AppendLine("insert into usuarios (cedula, nombre, usuario, contrasena) values (@cedula,@nombre,@usuario,@contrasena)");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "cedula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = cedula
                },
                new NpgsqlParameter
                {
                    ParameterName = "nombre",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = nombre
                },
                new NpgsqlParameter
                {
                    ParameterName = "usuario",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = usuario
                },
                new NpgsqlParameter
                {
                    ParameterName = "contrasena",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = contrasena
                }
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarUsuario(string cedula, string nombre, string usuario, string contrasena)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update usuarios set nombre=@nombre,usuario=@usuario,contrasena=@contrasena where cedula=@cedula");


            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "cedula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = cedula
                },
                new NpgsqlParameter
                {
                    ParameterName = "nombre",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = nombre
                },
                new NpgsqlParameter
                {
                    ParameterName = "usuario",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = usuario
                },
                new NpgsqlParameter
                {
                    ParameterName = "contrasena",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = contrasena
                }
               };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void EliminarUsuario(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from usuarios where cedula=@cedula");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "cedula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
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

        public DataSet Login(string usuario, string contrasena)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from usuarios");

            sql.AppendLine(" where usuario=@usuario and contrasena=@contrasena ");


            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "usuario",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = usuario
                },
                new NpgsqlParameter
                {
                    ParameterName = "contrasena",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = contrasena
                }
               };

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;

        }

        public DataSet TraerUsuarios(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("Select * from usuarios");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine(" where cedula=@cedula");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "cedula",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;



        }
    }
}
