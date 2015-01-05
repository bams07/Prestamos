using System;
using System.Data;
namespace Prestamos.Logica
{
	public interface IClientesSQL
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
		void InsertarCliente(string cedula, string nombre, string telefono, string celular, string direccion, bool moroso);
		void EditarCliente(string cedula, string nombre, string telefono, string celular, string direccion, bool moroso);
		void EliminarCliente(string filtro);
		DataSet TraerClientes(string filtro);
        DataSet TraerTotalClientes();
	}
}
