using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Logica
{
    public interface INotasSQL
    {
        # region Metodos de la clase
        Boolean IsError { set; get; }

        String ErrorDescripcion { set; get; }

        #endregion

        #region SQL

        void InsertarNota(string nota, DateTime fecha_creacion);

        void EditarNota(int id, string nota, DateTime fecha_edicion);

        void EliminarNota(int id);

        DataSet TraerNotas(int id);

        #endregion

    }
}

