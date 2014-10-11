using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Logica
{
    public interface IUsuariosSQL
    {
        # region Metodos de la clase
        Boolean IsError { set; get; }

        String ErrorDescripcion { set; get; }

        #endregion

        #region SQL

        void InsertarUsuario(string cedula, string nombre, string usuario, string contrasena);

        void EditarUsuario(string cedula, string nombre, string usuario, string contrasena);

        void EliminarUsuario(string filtro);

        DataSet Login(string usuario, string contrasena);

        DataSet TraerUsuarios(string filtro);

        #endregion

    }
}

