using System;
namespace Prestamos.Formatos
{
	public class EAbonos
	{
		public int id_abono
		{
			get;
			set;
		}
		public int id_cuota
		{
			get;
			set;
		}
		public double monto_abono
		{
			get;
			set;
		}
		public DateTime fecha_abono
		{
			get;
			set;
		}
		public int num_cuota
		{
			get;
			set;
		}
		public int id_prestamo
		{
			get;
			set;
		}
		public string cedula_cliente
		{
			get;
			set;
		}
		public string nombre_cliente
		{
			get;
			set;
		}
	}
}
