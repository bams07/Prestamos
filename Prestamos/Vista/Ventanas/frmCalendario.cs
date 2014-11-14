using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos.Formatos;
using Prestamos.Logica;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();

            OrdenarColumnas();

            TraerPrestamos();
        }

        #region METODOS

        public void OrdenarColumnas()
        {
            // ESTABLE EL ORDEN DE LAS COLUMNAS
            dtgPrestamos.Columns["cedulaCliente"].DisplayIndex = 0;
            dtgPrestamos.Columns["nombreCliente"].DisplayIndex = 1;
            dtgPrestamos.Columns["idPrestamo"].DisplayIndex = 2;
            dtgPrestamos.Columns["saldoPrestamo"].DisplayIndex = 3;
            dtgPrestamos.Columns["totalPrestamo"].DisplayIndex = 4;
            dtgPrestamos.Columns["fechaInicialPrestamo"].DisplayIndex = 5;
            dtgPrestamos.Columns["fechaFinalPrestamo"].DisplayIndex = 6;
            dtgPrestamos.Columns["montoPrestamo"].DisplayIndex = 7;
            dtgPrestamos.Columns["cuotasMontoPrestamo"].DisplayIndex = 8;
            dtgPrestamos.Columns["interesPrestamo"].DisplayIndex = 9;

        }

        // TRAE LOS PRESTAMOS Y LOS MUESTRA EN LA TABLA
        public void TraerPrestamos()
        {
            DataSet oDatos = DPrestamos.TraerPrestamosClientes(null, null, null, null);

            dtgPrestamos.DataSource = oDatos.Tables[0];


        }

        // TRAE LA FECHA FINAL DEL PRESTAMO
        public void TraerFechaFinal()
        {
            PrestamosCL oPrestamos = new PrestamosCL();

            // CICLO QUE RECORRE LAS FILAS DEL DATAGRID
            foreach (DataGridViewRow row in dtgPrestamos.Rows)
            {
                DataSet oDatos = oPrestamos.TraerFechaFinalPrestamo(row.Cells["idPrestamo"].Value.ToString());

                DateTime fechaFinal = Convert.ToDateTime(oDatos.Tables[0].Rows[0].ItemArray.GetValue(0));

                row.Cells["fechaFinalPrestamo"].Value = fechaFinal.ToShortDateString();

                // CAMBIA DE COLOR DE COLOR LAS FILAS ROJO = VENCIDAS - VERDE: NO VENCIDAS

                if (fechaFinal < DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }

            }

            OrdenarColumnas();
                
            
        }
        
        // ESTABLECE LAS FECHA EN EL CALENDARIO
        public void FechasCalendario()
        {

            DateTime[] fechasPrestamos = new DateTime[dtgPrestamos.Rows.Count];

            foreach (DataGridViewRow item in dtgPrestamos.Rows)
            {
                fechasPrestamos[item.Index] = Convert.ToDateTime(item.Cells["fechaFinalPrestamo"].Value.ToString());
            }

            calendario.BoldedDates = fechasPrestamos;

        }

        // MARCA LAS FECHAS SELECCIONADAS EN EL DATAGRID
        public void SelecionarFechas(string fecha)
        {
           
            foreach (DataGridViewRow item in dtgPrestamos.Rows)
            {

                string fechaFinal = item.Cells["fechaFinalPrestamo"].Value.ToString();

                if (fechaFinal == fecha)
                {
                    item.Selected = true;
                }else
                {
                    item.Selected = false;
                }



            }

        }

        #endregion

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            TraerFechaFinal();

            FechasCalendario();

        }

        private void dtgPrestamos_Sorted(object sender, EventArgs e)
        {
            TraerFechaFinal();
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {

            DateTime fechaMarcada = e.Start;

            SelecionarFechas(fechaMarcada.ToShortDateString());
            


        }
    }
}