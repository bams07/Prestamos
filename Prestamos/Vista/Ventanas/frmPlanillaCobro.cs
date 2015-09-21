using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;



namespace Prestamos.Vista.Ventanas
{
    public partial class frmPlanillaCobro : Form
    {

        public frmPlanillaCobro()
        {

            InitializeComponent();
            CargarPlanilla(null);


        }

        // CARGAR LAS PLANILLAS 
        public void CargarPlanilla(string fecha)
        {
            PlanillaCL oPlanilla = new PlanillaCL();

            DataSet oDatos;

            oDatos = oPlanilla.TraerPlanilla(fecha);


            // ASIGNA LOS DATOS AL DATAGRID
            dtgPlanilla.DataSource = oDatos.Tables[0];

            OrdenarColumnas();

        }

        // ORDENA LAS COLUMNAS
        public void OrdenarColumnas()
        {
            dtgPlanilla.Columns["Planilla"].DisplayIndex = 0;
            dtgPlanilla.Columns["Fecha"].DisplayIndex = 1;
            dtgPlanilla.Columns["Detalle"].DisplayIndex = 2;
            dtgPlanilla.Columns["Cuotas"].DisplayIndex = 3;
            dtgPlanilla.Columns["Procesada"].DisplayIndex = 4;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPlanilla(dtFecha.Value.ToShortDateString());
        }

        // LLAMA A LA VENTANA CREAR PLANILLA PARA SU RESPECTIVA CREACION
        private void btnCrear_Click(object sender, EventArgs e)
        {
            DataSet oDatos = SecuenciasCL.TraerSecuenciaPlanilla();

            DataTable oTable = oDatos.Tables[0];

            int pSecuencia;

            if (oTable.Rows.Count > 0)
            {
                pSecuencia = Convert.ToInt32(oTable.Rows[0].ItemArray.GetValue(0)) + 1;

            }
            else
            {
                pSecuencia = 1;

            }

            frmCrearPlanilla oCrearPlanilla = new frmCrearPlanilla(pSecuencia, this, dtFecha.Value.ToShortDateString());

            oCrearPlanilla.Show();
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarPlanilla(dtFecha.Value.ToShortDateString());


        }

        // SE EJECUTA CUANDO SE SELECIONA EL BOTON DE LA CANTIDAD DE CUOTAS
        private void dtgPlanilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (Convert.ToBoolean(dtgPlanilla.CurrentRow.Cells[3].Value.ToString()))
                {

                    frmCargarPlanillaProcesada oPlanilla = new frmCargarPlanillaProcesada(
                         dtgPlanilla.CurrentRow.Cells[0].Value.ToString(),
                         this,
                         dtgPlanilla.CurrentRow.Cells[1].Value.ToString(),
                         dtgPlanilla.CurrentRow.Cells[2].Value.ToString());

                    oPlanilla.Show();

                }
                else
                {

                    frmCargarPlanilla oPlanilla = new frmCargarPlanilla(
                  dtgPlanilla.CurrentRow.Cells[0].Value.ToString(),
                  this,
                  dtgPlanilla.CurrentRow.Cells[1].Value.ToString(),
                  dtgPlanilla.CurrentRow.Cells[2].Value.ToString(),
                  Convert.ToBoolean(dtgPlanilla.CurrentRow.Cells[3].Value.ToString()));

                    oPlanilla.Show();

                }
            }


        }

        // SE EJECUTA CUANDO DA DOBLE CLICK A LA CELLDA
        private void dtgPlanilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dtgPlanilla.CurrentRow.Cells[3].Value.ToString()))
            {

                frmCargarPlanillaProcesada oPlanilla = new frmCargarPlanillaProcesada(
                     dtgPlanilla.CurrentRow.Cells[0].Value.ToString(),
                     this,
                     dtgPlanilla.CurrentRow.Cells[1].Value.ToString(),
                     dtgPlanilla.CurrentRow.Cells[2].Value.ToString());

                oPlanilla.Show();


            }

            else
            {

              frmCargarPlanilla oPlanilla = new frmCargarPlanilla(
              dtgPlanilla.CurrentRow.Cells[0].Value.ToString(),
              this,
              dtgPlanilla.CurrentRow.Cells[1].Value.ToString(),
              dtgPlanilla.CurrentRow.Cells[2].Value.ToString(),
              Convert.ToBoolean(dtgPlanilla.CurrentRow.Cells[3].Value.ToString()));

                oPlanilla.Show();

            }

        }

        private void btnCargarPlanillas_Click(object sender, EventArgs e)
        {
            CargarPlanilla(null);
        }

        private void eliminarPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idPlanilla = dtgPlanilla.CurrentRow.Cells[0].Value.ToString();

            PlanillaCL oPlanilla = new PlanillaCL();

            oPlanilla.EliminarPlanillaTodas(idPlanilla);

            oPlanilla.EliminarPlanilla(idPlanilla);

            if (oPlanilla.IsError)
            {
                MessageBox.Show(oPlanilla.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                MessageBox.Show("Planilla eliminada con exito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPlanilla(null);
            }


        }







    }
}
