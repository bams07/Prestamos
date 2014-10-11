using Prestamos.Datos;
using Prestamos.Logica.Postgres;
using System;
using System.Data;
namespace Prestamos.Logica
{
	public class PrestamosCL
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
		public IPrestamosSQL ObtenerInstancia()
		{
			IPrestamosSQL result = null;
			ContextDataBase contextDataBase = AccesoDatos.Instance.accesoDatos.ContextDataBase;
			if (contextDataBase == ContextDataBase.PostgreSql)
			{
				result = new PrestamosPostgres();
			}
			return result;
		}
		public void InsertarPrestamo(int prestamo, DateTime fecha, string cliente, double monto, double interes, int cuotas, double saldo, double total, bool recargo, int dia_pago)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			prestamosSQL.InsertarPrestamo(prestamo, fecha, cliente, monto, interes, cuotas, saldo, total, recargo, dia_pago);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
		}
		public void EditarPrestamo(int id, double saldo)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			prestamosSQL.EditarPrestamo(id, saldo);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
		}
		public void EditarPrestamo_Recargo(int id, double saldo, double totalPrestamo, bool recargo)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			prestamosSQL.EditarPrestamo_Recargo(id, saldo, totalPrestamo, recargo);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
		}
		public void EditarPrestamo_DiaPago(int id, int dia_pago)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			prestamosSQL.EditarPrestamo_DiaPago(id, dia_pago);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
		}
		public void EliminarPrestamo(string filtro)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			prestamosSQL.EliminarPrestamo(filtro);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
		}
		public DataSet TraerPrestamo(string cliente, bool recargo)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			DataSet result = prestamosSQL.TraerPrestamo(cliente, recargo);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamo_planilla(string cliente, string prestamo, bool recargo)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			DataSet result = prestamosSQL.TraerPrestamo_planilla(cliente, prestamo, recargo);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerPrestamoSaldo(string filtro)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			DataSet result = prestamosSQL.TraerPrestamoSaldo(filtro);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerSecuencia()
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			DataSet result = prestamosSQL.TraerSecuencia();
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
			return result;
		}
		public DataSet TraerFechaFinalPrestamo(string filtro)
		{
			IPrestamosSQL prestamosSQL = this.ObtenerInstancia();
			DataSet result = prestamosSQL.TraerFechaFinalPrestamo(filtro);
			if (prestamosSQL.IsError)
			{
				this.IsError = prestamosSQL.IsError;
				this.ErrorDescripcion = prestamosSQL.ErrorDescripcion;
			}
			return result;
		}
	}
}
