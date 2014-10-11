using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Datos;

namespace Prestamos.Logica
{
    public class RespaldoCL
    {

        public bool IsError { get; set; }

        public string ErrorDescripcion { get; set; }

        public void insertarConfiguracion(int id, string postgre_direccion, string gdrive_client_id, string gdrive_client_secret)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into respaldo_configuracion (id,postgre_direccion, gdrive_client_id, gdrive_client_secret) " +
                "values (@id, @pdireccion, @client_id , @client_secret) ;");

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
                    ParameterName = "pdireccion",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = postgre_direccion
                },
                new NpgsqlParameter
                {
                    ParameterName = "client_id",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = gdrive_client_id
                },
                new NpgsqlParameter
                {
                    ParameterName = "client_secret",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = gdrive_client_secret
                }
               
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }


        public void editarConfiguracion(int id, string postgre_direccion, string gdrive_client_id, string gdrive_client_secret)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update respaldo_configuracion set postgre_direccion=@pdireccion, gdrive_client_id=@client_id, gdrive_client_secret=@client_secret where id=@id ");

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
                    ParameterName = "pdireccion",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = postgre_direccion
                },
                new NpgsqlParameter
                {
                    ParameterName = "client_id",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = gdrive_client_id
                },
                new NpgsqlParameter
                {
                    ParameterName = "client_secret",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = gdrive_client_secret
                }
               
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        public DataSet TraerConfiguracion()
        {
            var sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM respaldo_configuracion  ;");


     
            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString());
            return odatos;
        }





    }
}
