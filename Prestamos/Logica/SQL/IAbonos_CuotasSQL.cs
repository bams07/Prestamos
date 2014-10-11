using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Logica
{
    public interface IAbonos_CuotasSQL
    {
        # region Metodos de la clase
        Boolean IsError { set; get; }

        String ErrorDescripcion { set; get; }

        #endregion

        #region SQL

        void InsertarAbono_Cuotas(int id_cuota, double monto, DateTime fecha_abono);

        void EliminarAbono_Cuotas_Id(string id);

        void EliminarAbono_Cuotas_Id_Cuota(string id_cuota);

        DataSet TraerAbono_Cuotas(string filtro);

        DataSet TraerCantidad_Abonos(string filtro);

        DataSet TraerSuma_Abonos(string filtro);

        DataSet TraerAbonos_Cuotas_RangoFechas(string fecha_desde, string fecha_hasta);

        #endregion

    }
}

