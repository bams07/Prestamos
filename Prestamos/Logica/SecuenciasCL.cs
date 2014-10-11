using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Datos;

namespace Prestamos.Logica
{
    public class SecuenciasCL
    {
  
        public static DataSet TraerSecuenciaPrestamo()
        {
            var sql = new StringBuilder();
            sql.AppendLine("SELECT id FROM Prestamos ORDER BY id DESC LIMIT 1 ;");
            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString());
            return odatos;
        }

        public static DataSet TraerSecuenciaPlanilla()
        {
            var sql = new StringBuilder();
            sql.AppendLine("SELECT id_planilla FROM planilla_cobro ORDER BY id_planilla DESC LIMIT 1 ;");
            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString());
            return odatos;
        }



 

    }
}
