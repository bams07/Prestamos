using System;
using System.Data;
namespace Prestamos.Logica
{
	public interface IPrestamosSQL
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
		void InsertarPrestamo(int prestamo, DateTime fecha, string cliente, double monto, double interes, int cuotas, double saldo, double total, bool recargo, int dia_pago);
		void EditarPrestamo(int id, double saldo);
		void EditarPrestamo_Recargo(int id, double saldo, double totlaPrestamo, bool recargo);
		void EditarPrestamo_DiaPago(int id, int dia_pago);
		void EliminarPrestamo(string filtro);
		DataSet TraerPrestamo(string cliente, bool recargo);
		DataSet TraerPrestamo_planilla(string cliente, string prestamo, bool recargo);
		DataSet TraerPrestamoSaldo(string filtro);
        DataSet TraerPrestamoSaldoTotal();
		DataSet TraerFechaFinalPrestamo(string filtro);
		DataSet TraerSecuencia();
        DataSet TraerPrestamosNoCancelados();
	}
}
