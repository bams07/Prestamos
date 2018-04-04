using System;
using System.Data;
namespace Prestamos.Logica
{
	public interface IPrestamos_CuotasSQL
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
		void InsertarPrestamo_Cuotas(int prestamo, int num_Cuota, DateTime fecha_pactada, double monto, double saldo);
		void EditarPrestamoCuotas(int id, DateTime fecha_pago, bool pago, string opcion);
		void EditarPrestamoCuotas_RecargoPrestamo(int id, double monto, double saldo);
		void EditarPrestamoCuotas_FechaPactada(int id, DateTime fecha_pactada);
		void EliminarPrestamo(string filtro);
        void EliminarCuota(string id);
        void CancelarCuotasPrestamo(int prestamoId, DateTime fecha_pago);
		DataSet TraerPrestamoCuotas(string filtro);
		DataSet TraerPrestamoCuotas_Pago(string filtro);
		DataSet TraerPrestamoCuotas_NoPago(string filtro);
		DataSet TraerPrestamoCuotas_FechaPactada(string fecha);
		DataSet TraerPrestamoCuotas_FechaPago(string fecha_desde, string fecha_hasta);
		DataSet TraerPrestamoCuotas_Cliente_Prestamo(string cedula, string prestamo);
		DataSet TraerSecuencia();
    }
}
