using System;
using System.Data;
namespace Prestamos.Logica
{
    public interface IFiadoresSQL
    {
        bool IsError
        {
            get;
            set;
        }
        string ErrorDescripcion
        {
            get;
            set;
        }
        string ErrorCode
        {
            get;
            set;
        }
        void insertarFiador(string cliente_cedula, string cedula, string nombre, string telefono, string celular, string direccion, string letra_cambio);
        void editarFiador(string id, string cedula, string nombre, string telefono, string celular, string direccion, string letra_cambio);
        void eliminarFiador(string id);
        DataSet traerFiadores(string cliente_cedula);
    }
}
