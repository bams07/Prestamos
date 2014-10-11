using System;
namespace Prestamos.Logica
{
	public class ErroresCl
	{
		private string mensaje;
		public string VentanaErrores(string code_error, string ventana_origen)
		{
			if (code_error == "23505")
			{
				if (ventana_origen == "clientes")
				{
					this.mensaje = "Este cliente ya ha sido ingresado";
				}
			}
			if (code_error == "23503")
			{
				if (ventana_origen == "clientes")
				{
					this.mensaje = "Este cliente presenta prestamos a su nombre";
				}
			}
			return this.mensaje;
		}
	}
}
