using Prestamos.Datos;
using Prestamos.Logica.Postgres;
using System;
using System.Data;
namespace Prestamos.Logica
{
    public class FiadoresCL
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
        public IFiadoresSQL ObtenerInstancia()
        {
            IFiadoresSQL result = null;
            ContextDataBase contextDataBase = AccesoDatos.Instance.accesoDatos.ContextDataBase;
            if (contextDataBase == ContextDataBase.PostgreSql)
            {
                result = new FiadoresPostgres();
            }
            return result;
        }
        public void insertarFiador(string cliente_cedula, string cedula, string nombre, string telefono, string celular, string direccion, string letra_cambio)
        {
            IFiadoresSQL fiadoresSQL = this.ObtenerInstancia();
            fiadoresSQL.insertarFiador(cliente_cedula, cedula, nombre, telefono, celular, direccion, letra_cambio);
            if (fiadoresSQL.IsError)
            {
                this.IsError = fiadoresSQL.IsError;
                this.ErrorDescripcion = fiadoresSQL.ErrorDescripcion;
                this.ErrorCode = fiadoresSQL.ErrorCode;
            }
        }
        public void editarFiador(string id, string cedula, string nombre, string telefono, string celular, string direccion, string letra_cambio)
        {
            IFiadoresSQL fiadoresSQL = this.ObtenerInstancia();
            fiadoresSQL.editarFiador(id, cedula, nombre, telefono, celular, direccion, letra_cambio);
            if (fiadoresSQL.IsError)
            {
                this.IsError = fiadoresSQL.IsError;
                this.ErrorDescripcion = fiadoresSQL.ErrorDescripcion;
            }
        }
        public void eliminarFiador(string id)
        {
            IFiadoresSQL fiadoresSQL = this.ObtenerInstancia();
            fiadoresSQL.eliminarFiador(id);
            if (fiadoresSQL.IsError)
            {
                this.IsError = fiadoresSQL.IsError;
                this.ErrorDescripcion = fiadoresSQL.ErrorDescripcion;
                this.ErrorCode = fiadoresSQL.ErrorCode;
            }
        }
        public DataSet traerFiadores(string cliente_cedula)
        {
            IFiadoresSQL fiadoresSQL = this.ObtenerInstancia();
            DataSet result = fiadoresSQL.traerFiadores(cliente_cedula);
            if (fiadoresSQL.IsError)
            {
                this.IsError = fiadoresSQL.IsError;
                this.ErrorDescripcion = fiadoresSQL.ErrorDescripcion;
            }
            return result;
        }

    }
}
