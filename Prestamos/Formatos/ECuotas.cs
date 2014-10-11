using System;
namespace Prestamos.Formatos
{
	public class ECuotas
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
		public string fecha_pactada_cuota
		{
			get;
			set;
		}
		public string fecha_pago_cuota
		{
			get;
			set;
		}
		public double monto_cuota
		{
			get;
			set;
		}
		public int numero_cuota
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
		public int total_abonos
		{
			get;
			set;
		}
	}
}
