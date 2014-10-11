using Prestamos.Datos;
using Prestamos.Logica.Postgres;
using System;
using System.Data;
namespace Prestamos.Logica
{
	public class Prestamos_CuotasCL
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
		public IPrestamos_CuotasSQL ObtenerInstancia()
		{
			IPrestamos_CuotasSQL result = null;
			ContextDataBase contextDataBase = AccesoDatos.Instance.accesoDatos.ContextDataBase;
			if (contextDataBase == ContextDataBase.PostgreSql)
			{
				result = new Prestamos_CuotasPostgres();
			}
			return result;
		}
		public void InsertarPrestamo_Cuotas(int prestamo, int num_Cuota, DateTime fecha_pactada, double monto, double saldo)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			prestamos_CuotasSQL.InsertarPrestamo_Cuotas(prestamo, num_Cuota, fecha_pactada, monto, saldo);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
		}
		public void EditarPrestamoCuotas(int id, DateTime fecha_pago, bool pago, string opcion)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			prestamos_CuotasSQL.EditarPrestamoCuotas(id, fecha_pago, pago, opcion);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
		}
		public void EditarPrestamoCuotas_RecargoPrestamo(int id, double monto, double saldo)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			prestamos_CuotasSQL.EditarPrestamoCuotas_RecargoPrestamo(id, monto, saldo);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
		}
		public void EditarPrestamoCuotas_FechaPactada(int id, DateTime fecha_pactada)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			prestamos_CuotasSQL.EditarPrestamoCuotas_FechaPactada(id, fecha_pactada);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
		}
		public void EliminarPrestamo(string filtro)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			prestamos_CuotasSQL.EliminarPrestamo(filtro);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
		}
		public DataSet TraerPrestamoCuotas(string filtro)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerPrestamoCuotas(filtro);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamoCuotas_Pago(string filtro)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerPrestamoCuotas_Pago(filtro);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamoCuotas_NoPago(string filtro)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerPrestamoCuotas_NoPago(filtro);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerSecuencia()
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerSecuencia();
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamoCuotas_Filtros(string fecha)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerPrestamoCuotas_FechaPactada(fecha);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamoCuotas_FechaPago(string fecha_desde, string fecha_hasta)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerPrestamoCuotas_FechaPago(fecha_desde, fecha_hasta);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamoCuotas_Cliente_Prestamo(string cedula, string prestamo)
		{
			IPrestamos_CuotasSQL prestamos_CuotasSQL = this.ObtenerInstancia();
			DataSet result = prestamos_CuotasSQL.TraerPrestamoCuotas_Cliente_Prestamo(cedula, prestamo);
			if (prestamos_CuotasSQL.IsError)
			{
				this.IsError = prestamos_CuotasSQL.IsError;
				this.ErrorDescripcion = prestamos_CuotasSQL.ErrorDescripcion;
			}
			return result;
		}
	}
}
