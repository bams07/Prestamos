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
    public class NotasCL
    {
        public Boolean IsError { set; get; }

        public String ErrorDescripcion { set; get; }

        public INotasSQL ObtenerInstancia()
        {
            INotasSQL NotasSQL = null;
            switch (AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.PostgreSql:
                    NotasSQL = new NotasPostgres();
                    break;

                default:
                    break;
            }
            return NotasSQL;
        }

        public void InsertarNota(string nota, DateTime fecha_creacion)
        {
            INotasSQL NotasSQL = this.ObtenerInstancia();
            NotasSQL.InsertarNota(nota, fecha_creacion);
            if (NotasSQL.IsError)
            {
                this.IsError = NotasSQL.IsError;
                this.ErrorDescripcion = NotasSQL.ErrorDescripcion;
            }
        }



        public void EditarNota(int id, string nota, DateTime fecha_edicion)
        {
            INotasSQL NotasSQL = this.ObtenerInstancia();
            NotasSQL.EditarNota(id, nota, fecha_edicion);
            if (NotasSQL.IsError)
            {
                this.IsError = NotasSQL.IsError;
                this.ErrorDescripcion = NotasSQL.ErrorDescripcion;
            }
        }


        public void EliminarNota(int id)
        {
            INotasSQL NotasSQL = this.ObtenerInstancia();
            NotasSQL.EliminarNota(id);
            if (NotasSQL.IsError)
            {
                this.IsError = NotasSQL.IsError;
                this.ErrorDescripcion = NotasSQL.ErrorDescripcion;
            }
        }

        public DataSet TraerNotas(int id)
        {
            INotasSQL NotasSQL = this.ObtenerInstancia();
            DataSet datos = NotasSQL.TraerNotas(id);

            if (NotasSQL.IsError)
            {
                this.IsError = NotasSQL.IsError;
                this.ErrorDescripcion = NotasSQL.ErrorDescripcion;
            }
            return datos;
        }
    }
}