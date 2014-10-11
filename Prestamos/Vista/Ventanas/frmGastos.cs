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
    public partial class frmGastos : Form
    {
        public frmGastos()
        {
            InitializeComponent();
        }

        public void LimpiarCajas()
        {
            txtGasto.Text = string.Empty;
            txtMonto.Text = string.Empty;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGasto.Text) || !string.IsNullOrEmpty(txtMonto.Text))
            {
                GastosCL oGastos = new GastosCL();

                oGastos.InsertarGasto(txtGasto.Text, Convert.ToDouble(txtMonto.Text), dtFecha.Value);

                if (oGastos.IsError)
                {
                    MessageBox.Show(oGastos.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MessageBox.Show("Gasto ingresado con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCajas();

                }
            }
            else
            {
                MessageBox.Show("Faltan campos que llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
