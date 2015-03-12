using Npgsql;
using NpgsqlTypes;
using Prestamos.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Prestamos.Logica.Postgres
{
    public class FiadoresPostgres : IFiadoresSQL
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
        public string ErrorCode
        {
            get;
            set;
        }

        public void insertarFiador(string cliente_cedula, string cedula, string nombre, string telefono, string celular, string direccion, string letra_cambio)
        {

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("insert into fiadores (cliente_cedula,cedula, nombre, telefono,celular,direccion,letra_cambio) values (@cliente_cedula,@cedula,@nombre,@telefono,@celular,@direccion,@letra_cambio)");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
                new NpgsqlParameter
				{
					ParameterName = "cliente_cedula",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = cliente_cedula
				},
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
					ParameterName = "telefono",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = telefono
				},
				new NpgsqlParameter
				{
					ParameterName = "celular",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = celular
				},
				new NpgsqlParameter
				{
					ParameterName = "direccion",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = direccion
				},
                	new NpgsqlParameter
				{
					ParameterName = "letra_cambio",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = letra_cambio
				}
				
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
                this.ErrorCode = AccesoDatos.Instance.accesoDatos.ErrorCode;
            }

        }

        public void editarFiador(string id, string cedula, string nombre, string telefono, string celular, string direccion, string letra_cambio)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update fiadores  set cedula=@cedula,nombre=@nombre,telefono=@telefono,celular=@celular,direccion=@direccion,letra_cambio=@letra_cambio where id=@id");
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
					ParameterName = "telefono",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = telefono
				},
				new NpgsqlParameter
				{
					ParameterName = "celular",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = celular
				},
				new NpgsqlParameter
				{
					ParameterName = "direccion",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = direccion
				},
                  	new NpgsqlParameter
				{
					ParameterName = "letra_cambio",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = letra_cambio
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void eliminarFiador(string id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("delete from fiadores where id=@id");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "id",
					NpgsqlDbType = NpgsqlDbType.Integer,
					NpgsqlValue = id

				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
                this.ErrorCode = AccesoDatos.Instance.accesoDatos.ErrorCode;
            }
        }

        public DataSet traerFiadores(string cliente_cedula)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from fiadores");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(cliente_cedula))
            {
                stringBuilder.AppendLine(" where cliente_cedula=@cliente_cedula");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "cliente_cedula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = cliente_cedula
                });
            }
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }
    }
}
