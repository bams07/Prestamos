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
    public partial class frmFechaPreliminarPagoCuota : Form
    {

        #region VARIABLES

        frmAbonos abonos;

        #endregion


        public frmFechaPreliminarPagoCuota(frmAbonos oAbonos)
        {
            InitializeComponent();

            abonos = oAbonos;


        }

        private void btnAceptarFechaPreliminarPago_Click(object sender, EventArgs e)
        {
            abonos.fechaPreliminarPago = dtFecha.Value.Date;
            this.Hide();
        }




    }
}