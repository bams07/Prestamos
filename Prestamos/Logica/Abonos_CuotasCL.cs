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
    public class Abonos_CuotasCL
    {
        public Boolean IsError { set; get; }

        public String ErrorDescripcion { set; get; }

        public IAbonos_CuotasSQL ObtenerInstancia()
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = null;
            switch (AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.PostgreSql:
                    Abonos_CuotasSQL = new Abonos_CuotasPostgres();
                    break;

                default:
                    break;
            }
            return Abonos_CuotasSQL;
        }

        public void InsertarAbono_Cuotas(int id_cuota, double monto, DateTime fecha_abono)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            Abonos_CuotasSQL.InsertarAbono_Cuotas(id_cuota, monto, fecha_abono);
            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }
        }



        public void EliminarAbono_Cuotas_Id(string id)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            Abonos_CuotasSQL.EliminarAbono_Cuotas_Id(id);
            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }
        }

        public void EliminarAbono_Cuotas_Id_Cuota(string id_cuota)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            Abonos_CuotasSQL.EliminarAbono_Cuotas_Id_Cuota(id_cuota);
            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }

        }

        public DataSet TraerAbono_Cuotas(string filtro)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            DataSet datos = Abonos_CuotasSQL.TraerAbono_Cuotas(filtro);

            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }
            return datos;
        }

        public DataSet TraerCantidad_Abonos(string filtro)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            DataSet datos = Abonos_CuotasSQL.TraerAbono_Cuotas(filtro);

            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }
            return datos;
        }

        public DataSet TraerSuma_Abonos(string filtro)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            DataSet datos = Abonos_CuotasSQL.TraerSuma_Abonos(filtro);

            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }
            return datos;
        }

        public DataSet TraerAbonos_Cuotas_RangoFechas(string fecha_desde, string fecha_hasta)
        {
            IAbonos_CuotasSQL Abonos_CuotasSQL = this.ObtenerInstancia();
            DataSet datos = Abonos_CuotasSQL.TraerAbonos_Cuotas_RangoFechas(fecha_desde, fecha_hasta);

            if (Abonos_CuotasSQL.IsError)
            {
                this.IsError = Abonos_CuotasSQL.IsError;
                this.ErrorDescripcion = Abonos_CuotasSQL.ErrorDescripcion;
            }
            return datos;
        }

    }
}