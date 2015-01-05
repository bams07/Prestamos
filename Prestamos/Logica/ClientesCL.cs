using Prestamos.Datos;
using Prestamos.Logica.Postgres;
using System;
using System.Data;
namespace Prestamos.Logica
{
    public class ClientesCL
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
        public IClientesSQL ObtenerInstancia()
        {
            IClientesSQL result = null;
            ContextDataBase contextDataBase = AccesoDatos.Instance.accesoDatos.ContextDataBase;
            if (contextDataBase == ContextDataBase.PostgreSql)
            {
                result = new ClientesPostgres();
            }
            return result;
        }
        public void InsertarCliente(string cedula, string nombre, string telefono, string celular, string direccion, bool moroso)
        {
            IClientesSQL clientesSQL = this.ObtenerInstancia();
            clientesSQL.InsertarCliente(cedula, nombre, telefono, celular, direccion, moroso);
            if (clientesSQL.IsError)
            {
                this.IsError = clientesSQL.IsError;
                this.ErrorDescripcion = clientesSQL.ErrorDescripcion;
                this.ErrorCode = clientesSQL.ErrorCode;
            }
        }
        public void EditarCliente(string cedula, string nombre, string telefono, string celular, string direccion, bool moroso)
        {
            IClientesSQL clientesSQL = this.ObtenerInstancia();
            clientesSQL.EditarCliente(cedula, nombre, telefono, celular, direccion, moroso);
            if (clientesSQL.IsError)
            {
                this.IsError = clientesSQL.IsError;
                this.ErrorDescripcion = clientesSQL.ErrorDescripcion;
            }
        }
        public void EliminarCliente(string filtro)
        {
            IClientesSQL clientesSQL = this.ObtenerInstancia();
            clientesSQL.EliminarCliente(filtro);
            if (clientesSQL.IsError)
            {
                this.IsError = clientesSQL.IsError;
                this.ErrorDescripcion = clientesSQL.ErrorDescripcion;
                this.ErrorCode = clientesSQL.ErrorCode;
            }
        }
        public DataSet TraerClientes(string filtro)
        {
            IClientesSQL clientesSQL = this.ObtenerInstancia();
            DataSet result = clientesSQL.TraerClientes(filtro);
            if (clientesSQL.IsError)
            {
                this.IsError = clientesSQL.IsError;
                this.ErrorDescripcion = clientesSQL.ErrorDescripcion;
            }
            return result;
        }

        public DataSet TraerTotalClientes()
        {
            IClientesSQL clientesSQL = this.ObtenerInstancia();
            DataSet result = clientesSQL.TraerTotalClientes();
            if (clientesSQL.IsError)
            {
                this.IsError = clientesSQL.IsError;
                this.ErrorDescripcion = clientesSQL.ErrorDescripcion;
            }
            return result;
        }
    }
}
