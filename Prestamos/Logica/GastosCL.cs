using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Datos;
using Prestamos.Logica.Postgres;


namespace Prestamos.Logica
{
    public class GastosCL
    {
        public Boolean IsError { set; get; }

        public String ErrorDescripcion { set; get; }

        public IGastosSQL ObtenerInstancia()
        {
            IGastosSQL GastosSQL = null;
            switch (AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.PostgreSql:
                    GastosSQL = new GastosPostgres();
                    break;

                default:
                    break;
            }
            return GastosSQL;
        }

        public void InsertarGasto(string descripcion, double monto, DateTime fecha)
        {
            IGastosSQL GastosSQL = this.ObtenerInstancia();
            GastosSQL.InsertarGasto(descripcion, monto, fecha);
            if (GastosSQL.IsError)
            {
                this.IsError = GastosSQL.IsError;
                this.ErrorDescripcion = GastosSQL.ErrorDescripcion;
            }
        }



        public void EditarGasto(int id, string descripcion)
        {
            IGastosSQL GastosSQL = this.ObtenerInstancia();
            GastosSQL.EditarGasto(id, descripcion);
            if (GastosSQL.IsError)
            {
                this.IsError = GastosSQL.IsError;
                this.ErrorDescripcion = GastosSQL.ErrorDescripcion;
            }
        }


        public void EliminarGasto(string filtro)
        {
            IGastosSQL GastosSQL = this.ObtenerInstancia();
            GastosSQL.EliminarGasto(filtro);
            if (GastosSQL.IsError)
            {
                this.IsError = GastosSQL.IsError;
                this.ErrorDescripcion = GastosSQL.ErrorDescripcion;
            }
        }

        public DataSet TraerGasto(string filtro)
        {
            IGastosSQL GastosSQL = this.ObtenerInstancia();
            DataSet datos = GastosSQL.TraerGasto(filtro);

            if (GastosSQL.IsError)
            {
                this.IsError = GastosSQL.IsError;
                this.ErrorDescripcion = GastosSQL.ErrorDescripcion;
            }
            return datos;
        }

        public DataSet TraerGastoRangoFecha(string fecha_desde, string fecha_hasta)
        {
            IGastosSQL GastosSQL = this.ObtenerInstancia();
            DataSet datos = GastosSQL.TraerGastoRangoFecha(fecha_desde, fecha_hasta);

            if (GastosSQL.IsError)
            {
                this.IsError = GastosSQL.IsError;
                this.ErrorDescripcion = GastosSQL.ErrorDescripcion;
            }
            return datos;
        }



    }
}