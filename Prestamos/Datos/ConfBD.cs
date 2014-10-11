using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Npgsql;


namespace Prestamos.Datos
{
    public class ConfBD
    {
        

        public  DataSet ComprobarBD()
        {
            AccesoDatosComprobacion oComprobacion = new AccesoDatosComprobacion();

            string query = "SELECT datname FROM pg_database WHERE datname='Prestamos' or  datname='prestamos';";

            var odatos = oComprobacion.EjecutarConsultaSQL(query);
            return odatos;

        }

        public Boolean ExisteBD()
        {


            if (ComprobarBD().Tables[0].Rows.Count > 0)
            {

                return true;


            }
            else
            {
                AccesoDatosComprobacion oComprobacion = new AccesoDatosComprobacion();

                string query = "Create database prueba;";

                var odatos = oComprobacion.EjecutarConsultaSQL(query);
                return false;

            }

        }
       






    }
}
