using System;
namespace Prestamos.Formatos
{
	public class ECierreCaja
	{
		public int id_cuota
		{
			get;
			set;
		}
		public int id_prestamo
		{
			get;
			set;
		}
		public DateTime fecha_pactada_cuota
		{
			get;
			set;
		}
		public DateTime fecha_pago_cuota
		{
			get;
			set;
		}
		public double monto_cuota
		{
			get;
			set;
		}
		public int num_cuota
		{
			get;
			set;
		}
		public bool pago_cuota
		{
			get;
			set;
		}
		public double saldo_cuota
		{
			get;
			set;
		}
		public string nombre_cliente
		{
			get;
			set;
		}
		public string cedula_cliente
		{
			get;
			set;
		}
	}
}
