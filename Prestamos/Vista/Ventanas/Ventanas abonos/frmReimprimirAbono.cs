using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prestamos.Logica;
using Prestamos.Formatos;

namespace Prestamos.Vista.Ventanas.Ventanas_abonos
{
    public partial class frmReimprimirAbono : Form
    {

        #region Variables
        public string encabezado;
        public bool cancelar;
        #endregion

        public frmReimprimirAbono(string tituloVentana)
        {
            InitializeComponent();

            this.Text = tituloVentana;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            encabezado = txtMensaje.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
        }

    }
}
