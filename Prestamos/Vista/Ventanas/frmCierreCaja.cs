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
    public partial class frmCierreCaja : Form
    {

        public frmCierreCaja()
        {

            InitializeComponent();


        }



        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ckGastos.Checked == true)
            {

                frmReportes oReportes = new frmReportes();

                oReportes.Show();

                oReportes.CierreCaja(dtFechaDesde.Value.ToShortDateString(), dtFechaHasta.Value.ToShortDateString());
            }
            else
            {

                frmReportes oReportes = new frmReportes();

                oReportes.Show();

                oReportes.CierreCaja_SinGastos(dtFechaDesde.Value.ToShortDateString(), dtFechaHasta.Value.ToShortDateString());

            }




        }




    }
}
