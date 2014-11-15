using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Datos;
using Prestamos.Logica.Postgres;
using Prestamos.Logica.SQL;


namespace Prestamos.Logica
{
    public class PlanillaCL
    {
        public Boolean IsError { set; get; }

        public String ErrorDescripcion { set; get; }

        public IPlanillaSQL ObtenerInstancia()
        {
            IPlanillaSQL IPlanillaSQL = null;
            switch (AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.PostgreSql:
                    IPlanillaSQL = new PlanillaPostgres();
                    break;

                default:
                    break;
            }
            return IPlanillaSQL;
        }

        public void InsertarPlanilla(int id_planilla, DateTime fecha, string detalle, bool procesada)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            IPlanillaSQL.InsertarPlanilla(id_planilla, fecha, detalle, procesada);
            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
        }


        public void EditarPlanilla(int id_planilla, bool procesada)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            IPlanillaSQL.EditarPlanilla(id_planilla, procesada);
            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
        }

        public void InsertarPlanillaDetalle(int id_planilla, int id_cuota)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            IPlanillaSQL.InsertarPlanillaDetalle(id_planilla, id_cuota);
            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
        }

        public void EliminarPlanilla(string filtro)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            IPlanillaSQL.EliminarPlanilla(filtro);
            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
        }

        public void EliminarPlanillaDetalle(string idCuota, string idPlanilla)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            IPlanillaSQL.EliminarPlanillaDetalle(idCuota, idPlanilla);
            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
        }

        public DataSet TraerPlanilla(string filtro)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            DataSet datos = IPlanillaSQL.TraerPlanilla(filtro);

            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
            return datos;
        }

        public DataSet TraerPlanillaDetalle(string filtro)
        {
            IPlanillaSQL IPlanillaSQL = this.ObtenerInstancia();
            DataSet datos = IPlanillaSQL.TraerPlanillaDetalle(filtro);

            if (IPlanillaSQL.IsError)
            {
                this.IsError = IPlanillaSQL.IsError;
                this.ErrorDescripcion = IPlanillaSQL.ErrorDescripcion;
            }
            return datos;
        }




    }
}