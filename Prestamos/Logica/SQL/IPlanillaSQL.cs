using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Prestamos.Logica.SQL
{
    public interface IPlanillaSQL
    {
        # region Metodos de la clase

        Boolean IsError { set; get; }

        String ErrorDescripcion { set; get; }

        #endregion

        #region SQL

        void InsertarPlanilla(int id_planilla, DateTime fecha, string detalle, bool procesada);

        void EditarPlanilla(int id_planilla, bool procesada);

        void InsertarPlanillaDetalle(int id_planilla, int id_cuota);

        void EliminarPlanilla(string filtro);

        void EliminarPlanillaDetalle(string filtro);

        DataSet TraerPlanilla(string filtro);

        DataSet TraerPlanillaDetalle(string filtro);

        #endregion


    }
}
