using Prestamos.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.Vista.Ventanas
{
    public partial class frmRFiltroCuentaCobrar : Form
    {


        public frmRFiltroCuentaCobrar()
        {
            InitializeComponent();
        }

        // COMPRUEBA LOS PRESTAMOS Y LOS CARGA
        public bool ComprobarPrestamos()
        {
            PrestamosCL oPrestamos = new PrestamosCL();

            DataSet oDatos = oPrestamos.TraerPrestamo(txtCliente.Text, true, false);


            if (oDatos.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Este cliente no presenta prestamos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarTabla();
                return false;
            }
            else
            {
                dtgPrestamos.DataSource = oDatos.Tables[0];
                return true;
            }

        }


        // LIMPIA EL DATAGRID DE PRESTAMOS
        public void LimpiarTabla()
        {

            int Cfilas = dtgPrestamos.Rows.Count;

            for (int n = 0; n < Cfilas; n++)
            {
                if (dtgPrestamos.Rows[0].IsNewRow == false)
                    dtgPrestamos.Rows.RemoveAt(0);
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes oClientes = new frmListaClientes(this);
            oClientes.ShowDialog();

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            frmReportes oReportes = new frmReportes();


            if (ckTodosPrestamos.Checked == true)
            {
                oReportes.Show();
                oReportes.CuentasCobrar("", "", dtFechaDesde.Value.ToShortDateString(), dtFechaHasta.Value.ToShortDateString());

            }
            else
            {
                if (string.IsNullOrEmpty(txtCliente.Text))
                {

                    MessageBox.Show("Debes seleccionar un cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {


                    if (dtgPrestamos.Rows.Count == 0)
                    {

                        MessageBox.Show("Debes seleccionar un prestamo que procesar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        //COMPRUEBA QUE SI LAS FILAS SELECIONADAS SON IGUALES A LA CANTIDAD DE FILAS EN LA TABLA
                        if (dtgPrestamos.SelectedRows.Count == dtgPrestamos.Rows.Count)
                        {
                            oReportes.Show();
                            oReportes.CuentasCobrar(txtCliente.Text, "", dtFechaDesde.Value.ToShortDateString(), dtFechaHasta.Value.ToShortDateString());

                        }
                        else
                        {
                            oReportes.Show();
                            oReportes.CuentasCobrar(txtCliente.Text, dtgPrestamos.CurrentRow.Cells["Numero"].Value.ToString(), dtFechaDesde.Value.ToShortDateString(), dtFechaHasta.Value.ToShortDateString());

                        }
                    }
                }
            }

        }

        private void selecionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //COMPRUEBA QUE SI EL MENU DE TODAS LAS FILAS ESTA CON CHECK
            if (selecionarTodoToolStripMenuItem.CheckState == CheckState.Checked)
            {
                txtCliente.Enabled = false;
                btnClientes.Enabled = false;
                dtgPrestamos.Enabled = false;
                lblClientes.Enabled = false;

            }
            else
            {
                selecionarTodoToolStripMenuItem.Checked = true;
                dtgPrestamos.MultiSelect = true;
                dtgPrestamos.SelectAll();
                dtgPrestamos.Rows[0].Selected = true;


            }


        }

        private void dtgPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //COMPRUEBA QUE SI LAS FILAS SELECIONADAS SON IGUALES A LA CANTIDAD DE FILAS EN LA TABLA
            if (dtgPrestamos.SelectedRows.Count != dtgPrestamos.Rows.Count)
            {
                selecionarTodoToolStripMenuItem.Checked = false;
                dtgPrestamos.MultiSelect = false;

                dtgPrestamos.Rows[dtgPrestamos.CurrentRow.Index].Selected = true;
            }


        }

        private void ckTodosPrestamos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTodosPrestamos.Checked == true)
            {
                txtCliente.Enabled = false;
                btnClientes.Enabled = false;
                dtgPrestamos.Enabled = false;
                lblClientes.Enabled = false;

                txtCliente.Text = string.Empty;

                LimpiarTabla();
            }
            else
            {

                txtCliente.Enabled = true;
                btnClientes.Enabled = true;
                dtgPrestamos.Enabled = true;
                lblClientes.Enabled = true;

            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ComprobarPrestamos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
