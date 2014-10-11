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
    public class UsuariosCL
    {
        public Boolean IsError { set; get; }

        public String ErrorDescripcion { set; get; }

        public IUsuariosSQL ObtenerInstancia()
        {
            IUsuariosSQL usuariosSQL = null;
            switch (AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.PostgreSql:
                    usuariosSQL = new UsuariosPostgres();
                    break;

                default:
                    break;
            }
            return usuariosSQL;
        }

        public void InsertarUsuario(string cedula, string nombre, string usuario, string contrasena)
        {
            IUsuariosSQL usuariosSQL = this.ObtenerInstancia();
            usuariosSQL.InsertarUsuario(cedula, nombre, usuario, contrasena);
            if (usuariosSQL.IsError)
            {
                this.IsError = usuariosSQL.IsError;
                this.ErrorDescripcion = usuariosSQL.ErrorDescripcion;
            }
        }



        public void EditarUsuario(string cedula, string nombre, string usuario, string contrasena)
        {
            IUsuariosSQL usuariosSQL = this.ObtenerInstancia();
            usuariosSQL.EditarUsuario(cedula, nombre, usuario, contrasena);
            if (usuariosSQL.IsError)
            {
                this.IsError = usuariosSQL.IsError;
                this.ErrorDescripcion = usuariosSQL.ErrorDescripcion;
            }
        }


        public void EliminarUsuario(string filtro)
        {
            IUsuariosSQL usuariosSQL = this.ObtenerInstancia();
            usuariosSQL.EliminarUsuario(filtro);
            if (usuariosSQL.IsError)
            {
                this.IsError = usuariosSQL.IsError;
                this.ErrorDescripcion = usuariosSQL.ErrorDescripcion;
            }
        }


        public DataSet Login(string usuario, string contrasena)
        {
            IUsuariosSQL usuariosSQL = this.ObtenerInstancia();
            DataSet datos = usuariosSQL.Login(usuario, contrasena);

            if (usuariosSQL.IsError)
            {
                this.IsError = usuariosSQL.IsError;
                this.ErrorDescripcion = usuariosSQL.ErrorDescripcion;
            }
            return datos;
        }



        public DataSet TraerUsuarios(string filtro)
        {
            IUsuariosSQL usuariosSQL = this.ObtenerInstancia();
            DataSet datos = usuariosSQL.TraerUsuarios(filtro);

            if (usuariosSQL.IsError)
            {
                this.IsError = usuariosSQL.IsError;
                this.ErrorDescripcion = usuariosSQL.ErrorDescripcion;
            }
            return datos;
        }









    }
}