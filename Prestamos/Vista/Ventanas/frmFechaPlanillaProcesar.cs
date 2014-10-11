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
    public partial class frmFechaPlanillaProcesar : Form
    {

        #region VARIABLES

        frmCargarPlanilla planillaCargar;

        #endregion


        public frmFechaPlanillaProcesar(frmCargarPlanilla PlanillaCargar)
        {
            InitializeComponent();

            planillaCargar = PlanillaCargar;


        }

        private void btnAceptarFechaPlanilla_Click(object sender, EventArgs e)
        {
            planillaCargar.fechaPago = dtFecha.Value.Date;
            this.Hide();
        }

        private void frmFechaPlanillaProcesar_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }



  




    }
}