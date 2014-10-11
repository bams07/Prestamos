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

    public partial class frmPrestamos : Form
    {

        string cliente;
        string nombre;

        public frmPrestamos()
        {
            InitializeComponent();
        }


        public void CargarClientes()
        {

            ClientesCL oClientes = new ClientesCL();

            DataSet oDatos = oClientes.TraerClientes(txtCliente.Text);


            if (oDatos.Tables[0].Rows.Count == 0)
            {

                MessageBox.Show("Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cliente = null;
            }
            else
            {
                cliente = oDatos.Tables[0].Rows[0].ItemArray[0].ToString();
                nombre = oDatos.Tables[0].Rows[0].ItemArray[1].ToString();
                lblDescripcion.Text = oDatos.Tables[0].Rows[0].ItemArray[1].ToString();
                lblDescripcion.Visible = true;
            }



        }

        public void CargarPrestamos()
        {
            PrestamosCL oPrestamos = new PrestamosCL();

            DataSet oDatos;

            if (ckRecargos.Checked == true)
            {

                oDatos = oPrestamos.TraerPrestamo(txtCliente.Text, true);

            }
            else
            {

                oDatos = oPrestamos.TraerPrestamo(txtCliente.Text, false);
            }




            if (cliente != null)
            {

                dtgPrestamos.DataSource = oDatos.Tables[0];

            }

        }


        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarClientes();
                CargarPrestamos();
            }
        }

        private void nuevoPrestamoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (cliente == null)
            {

                MessageBox.Show("Debes elegir algun cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                DialogResult dialogResult = new frmNuevoPrestamo(this, cliente, nombre).ShowDialog();


            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes oClientes = new frmListaClientes(this);
            oClientes.ShowDialog();


        }

        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbonos oAbonos = new frmAbonos();

            oAbonos.ShowDialog();

            this.Dispose();
        }

        private void recargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {

                MessageBox.Show("Debes elegir algun cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                cliente = lblDescripcion.Text;
                int prestramo = Convert.ToInt32(dtgPrestamos.CurrentRow.Cells["ID"].Value);
                double montoCuota = Convert.ToDouble(dtgPrestamos.CurrentRow.Cells["Cuotas"].Value);
                double saldo = Convert.ToDouble(dtgPrestamos.CurrentRow.Cells["Saldo"].Value);

                DialogResult dialogResult = new frmRecargoPrestamo(this, prestramo, montoCuota,saldo,1,cliente).ShowDialog();


            }
        }

        private void ckRecargos_CheckStateChanged(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        private void editarFechasCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgPrestamos.SelectedRows.Count > 0)
            {

                int prestamo = Convert.ToInt32(dtgPrestamos.CurrentRow.Cells["ID"].Value);

                Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

                DataSet oDatos = oCuotas.TraerPrestamoCuotas_NoPago(prestamo.ToString());

                if (oDatos.Tables[0].Rows.Count > 0)
                {

                    frmEdicionCuotaFecha oEfecha = new frmEdicionCuotaFecha(prestamo, lblDescripcion.Text);

                    oEfecha.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Este prestamo no presenta cuotas pendientes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar algun prestamo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dtgPrestamos.SelectedRows.Count > 0)
            {
                PrestamosCL prestamosCL = new PrestamosCL();
                Prestamos_CuotasCL prestamos_CuotasCL = new Prestamos_CuotasCL();

                DataTable dataTable = prestamosCL.TraerPrestamoSaldo(this.dtgPrestamos.CurrentRow.Cells["ID"].Value.ToString()).Tables[0];

                string a = this.dtgPrestamos.CurrentRow.Cells["Total"].Value.ToString();

                if (a == dataTable.Rows[0].ItemArray.GetValue(0).ToString())
                {
                    prestamos_CuotasCL.EliminarPrestamo(this.dtgPrestamos.CurrentRow.Cells["ID"].Value.ToString());

                    prestamosCL.EliminarPrestamo(this.dtgPrestamos.CurrentRow.Cells["ID"].Value.ToString());
                    if (prestamosCL.IsError || prestamos_CuotasCL.IsError)
                    {
                        MessageBox.Show(prestamosCL.ErrorDescripcion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MessageBox.Show(prestamos_CuotasCL.ErrorDescripcion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Prestamo eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.CargarPrestamos();
                    }
                }
                else
                {
                    MessageBox.Show("Este prestamo no se puede eliminar ya que presenta cuotas pagadas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar algun prestamo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }




    }
}
