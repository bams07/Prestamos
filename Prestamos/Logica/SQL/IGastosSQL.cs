using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Logica
{
    public interface IGastosSQL
    {
        # region Metodos de la clase
        Boolean IsError { set; get; }

        String ErrorDescripcion { set; get; }

        #endregion

        #region SQL

        void InsertarGasto(string descripcion, double monto, DateTime fecha);

        void EditarGasto(int id, string descripcion);

        void EliminarGasto(string filtro);

        DataSet TraerGasto(string filtro);

        DataSet TraerGastoRangoFecha(string fecha_desde,string fecha_hasta);

        #endregion

    }
}

