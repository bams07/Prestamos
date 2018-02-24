using Npgsql;
using NpgsqlTypes;
using Prestamos.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Prestamos.Logica.Postgres
{
    public class ClientesPostgres : IClientesSQL
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
        public void InsertarCliente(string cedula, string nombre, string telefono, string celular, string direccion, bool moroso)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("insert into clientes ( cedula, nombre, telefono,celular,direccion,moroso) values (@cedula,@nombre,@telefono,@celular,@direccion,@moroso)");
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
					ParameterName = "moroso",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = moroso
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
        public void EditarCliente(string cedula, string nombre, string telefono, string celular, string direccion, bool moroso)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("update clientes set nombre=@nombre, telefono=@telefono,celular=@celular,direccion=@direccion,moroso=@moroso where cedula=@cedula");
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
					ParameterName = "moroso",
					NpgsqlDbType = NpgsqlDbType.Boolean,
					NpgsqlValue = moroso
				}
			};
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(stringBuilder.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public void EliminarCliente(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("delete from clientes where cedula=@cedula");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
			{
				new NpgsqlParameter
				{
					ParameterName = "cedula",
					NpgsqlDbType = NpgsqlDbType.Varchar,
					NpgsqlValue = filtro
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
        public DataSet TraerClientes(string filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Select * from clientes");
            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            if (!string.IsNullOrEmpty(filtro))
            {
                stringBuilder.AppendLine(" where cedula=@cedula");
                list.Add(new NpgsqlParameter
                {
                    ParameterName = "cedula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = filtro
                });
            }
            stringBuilder.AppendLine(" order by nombre");
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString(), list);
        }


        // TRAE EL TOTAL DE CLIENTES
        public DataSet TraerTotalClientes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT count(*) FROM clientes");
            return AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(stringBuilder.ToString());
        }
    }
}
