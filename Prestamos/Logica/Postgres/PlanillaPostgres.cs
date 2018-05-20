using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Datos;
using Prestamos.Logica.SQL;

namespace Prestamos.Logica.Postgres
{
    public class PlanillaPostgres : IPlanillaSQL
    {

        public bool IsError { get; set; }

        public string ErrorDescripcion { get; set; }

        public void InsertarPlanilla(int id_planilla, DateTime fecha, string detalle, bool procesada)
        {

            var sql = new StringBuilder();
            sql.AppendLine("insert into planilla_cobro (id_planilla,fecha_planilla, detalle_planilla,procesada_planilla) values (@id_planilla,@fecha_planilla,@detalle_planilla,@procesada_planilla)");

            var parametros = new List<NpgsqlParameter>
            {  
                new NpgsqlParameter
                {
                    ParameterName = "id_planilla",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_planilla
                },

               new NpgsqlParameter
                {
                    ParameterName = "fecha_planilla",
                    NpgsqlDbType = NpgsqlDbType.Timestamp,
                    NpgsqlValue = fecha
                },
                new NpgsqlParameter
                {
                    ParameterName = "detalle_planilla",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = detalle
                },
                 new NpgsqlParameter
                {
                    ParameterName = "procesada_planilla",
                    NpgsqlDbType = NpgsqlDbType.Boolean,
                    NpgsqlValue = procesada
                }
                 
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }


        public void EditarPlanilla(int id_planilla, bool procesada)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update planilla_cobro set procesada_planilla=@procesada_planilla where id_planilla=@id_planilla ");

            var parametros = new List<NpgsqlParameter>
            {  
                new NpgsqlParameter
                {
                    ParameterName = "id_planilla",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_planilla
                },             
                 new NpgsqlParameter
                {
                    ParameterName = "procesada_planilla",
                    NpgsqlDbType = NpgsqlDbType.Boolean,
                    NpgsqlValue = procesada
                }
                 
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }


        public void InsertarPlanillaDetalle(int id_planilla, int id_cuota)
        {

            var sql = new StringBuilder();
            sql.AppendLine("insert into planilla_cobro_detalle (id_planilla, id_cuota) values (@id_planilla,@id_cuota)");

            var parametros = new List<NpgsqlParameter>
            {  
                new NpgsqlParameter
                {
                    ParameterName = "id_planilla",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_planilla
                },
                new NpgsqlParameter
                {
                    ParameterName = "id_cuota",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_cuota
                }
                 
            };
            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }


        }

        public void EliminarPlanilla(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from planilla_cobro where id_planilla=@id_planilla");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id_planilla",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = filtro
                },
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }


        }

        // ELIMINA TODAS LAS CUOTAS DE UNA PLANILLA EN ESPECIFICO
        public void EliminarPlanillaDetalleTodas(string idPlanilla)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from planilla_cobro_detalle where id_planilla=@id_planilla");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id_planilla",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = idPlanilla
                },
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }


        }


        // ELIMINA UNA CUOTA EN ESPECIFICO DE UNA PLANILLA
        public void EliminarPlanillaDetalle(string idCuota, string idPlanilla)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from planilla_cobro_detalle where id_cuota=@id_cuota and id_planilla=@id_planilla");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id_cuota",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = idCuota
                },
                new NpgsqlParameter
                {
                    ParameterName = "id_planilla",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = idPlanilla
                },
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        // ELIMINA UNA CUOTA EN ESPECIFICO DE UNA PLANILLA
        public void EliminarPlanillaDetalle(string idCuota)
        {

            var sql = new StringBuilder();
            sql.AppendLine("delete from planilla_cobro_detalle where id_cuota=@id_cuota");

            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter
                {
                    ParameterName = "id_cuota",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = idCuota
                }
            };

            AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }

        }

        public DataSet TraerPlanilla(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("SELECT planilla_cobro.id_planilla, planilla_cobro.fecha_planilla,");
            sql.AppendLine("planilla_cobro.detalle_planilla,planilla_cobro.procesada_planilla,count(planilla_cobro_detalle.id_cuota) as cantidad FROM ");
            sql.AppendLine("planilla_cobro,planilla_cobro_detalle ");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where planilla_cobro.fecha_planilla=@fecha_planilla ");
                sql.AppendLine("and planilla_cobro_detalle.id_planilla=planilla_cobro.id_planilla group by planilla_cobro.id_planilla ");
                sql.AppendLine("order by planilla_cobro.id_planilla asc");
                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "fecha_planilla",
                        NpgsqlDbType = NpgsqlDbType.Timestamp,
                        NpgsqlValue = Convert.ToDateTime(filtro)
                    });
            }
            else
            {
                sql.AppendLine(" where planilla_cobro_detalle.id_planilla=planilla_cobro.id_planilla group by  planilla_cobro.id_planilla");
                sql.AppendLine(" order by planilla_cobro.id_planilla asc ");
            }
            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;

        }

        public DataSet TraerPlanillaDetalle(string filtro)
        {

            var sql = new StringBuilder();
            sql.AppendLine("select clientes.nombre as nombre,clientes.cedula as cedula,prestamos_cuotas.num_cuota as num_cuota,");
            sql.AppendLine("prestamos.id as id_prestamo,prestamos_cuotas.fecha_pactada as fecha_pactada,planilla_cobro_detalle.id_cuota as pc_id,");
            sql.AppendLine("prestamos_cuotas.monto,prestamos_cuotas.saldo ");
            sql.AppendLine(" from planilla_cobro_detalle,planilla_cobro,prestamos,prestamos_cuotas,clientes ");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where planilla_cobro.id_planilla=@id_planilla and planilla_cobro_detalle.id_cuota = prestamos_cuotas.id and ");
                sql.AppendLine("planilla_cobro.id_planilla=planilla_cobro_detalle.id_planilla and ");
                sql.AppendLine("prestamos.cliente = clientes.cedula and prestamos_cuotas.id_prestamos = prestamos.id order by id_prestamo,num_cuota asc");
                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id_planilla",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;

        }

    }
}
