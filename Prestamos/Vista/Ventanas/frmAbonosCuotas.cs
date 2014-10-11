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
    public partial class frmAbonosCuotas : Form
    {

        #region VARIABLES

        DataTable lAbonos;
        int cuota;
        int prestamo;
        frmAbonos abonos;

        #endregion


        public frmAbonosCuotas(int id_cuota, int id_prestamo, frmAbonos oAbonos)
        {
            InitializeComponent();

            // ID DE LA CUOTA
            cuota = id_cuota;
            // ID DEL PRESAMO
            prestamo = id_prestamo;
            // INSTANCIA DE FRMABONOS
            abonos = oAbonos;


            CargarAbonos(cuota);
        }


        public frmAbonosCuotas(int id_cuota)
        {
            InitializeComponent();

            CargarAbonos(id_cuota);

            eliminarAbonoToolStripMenuItem.Enabled = false;


        }


        public void CargarAbonos(int id_cuota)
        {
            // INSTANCIAS
            Abonos_CuotasCL oAbonosCuotas = new Abonos_CuotasCL();

            // TRAE LOS ABONOS DE CUOTAS Y LOS GUARDA EN DATATABLE
            DataTable oTable = oAbonosCuotas.TraerAbono_Cuotas(Convert.ToString(id_cuota)).Tables[0];

            lAbonos = oTable;

            //CICLO QUE RECORRE LOS ROWS
            foreach (DataRow item in oTable.Rows)
            {
                // CREAR UN GRUPO 
                ListViewGroup grupo = new ListViewGroup(item["fecha_abono"].ToString());

                // CREAR UN ITEM DE GRUPO
                ListViewItem item_grupo = new ListViewItem("MONTO: ₡" + item["monto"].ToString(), grupo);

                // AGREGAR EL GRUPO
                listAbonosCuotas.Groups.Add(grupo);

                // AGREGAR EL ITEM
                listAbonosCuotas.Items.Add(item_grupo);

            }


        }

        // LIMPIA LOS VALORES DE LA LISTA
        public void LimpiarValores()
        {

            listAbonosCuotas.Clear();

            if (listAbonosCuotas.Items.Count == 0)
            {
                this.Dispose();
            }

        }

        public void EditarSaldoPrestamo(double saldo)
        {
            PrestamosCL oPrestamos = new PrestamosCL();

            DataSet oDatos = oPrestamos.TraerPrestamoSaldo(prestamo.ToString());

            double saldoPrestamo = Convert.ToDouble(oDatos.Tables[0].Rows[0].ItemArray[0]) + saldo;

            oPrestamos.EditarPrestamo(prestamo, saldoPrestamo);



        }

        private void eliminarAbonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listAbonosCuotas.CheckedItems.Count == 0)
            {

                MessageBox.Show("Debes marcar en la casila los abonos que deseas eliminar", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {

                DialogResult opcion = MessageBox.Show("Desea eliminar los siguientes abonos marcados", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                double saldo = 0;

                // ELIMINA LOS ABONOS MARCADS CON EL CHECK
                if (opcion == DialogResult.OK)
                {
                    Abonos_CuotasCL oAbonos = new Abonos_CuotasCL();

                    Prestamos_CuotasCL oCuotas = new Prestamos_CuotasCL();

                    oCuotas.EditarPrestamoCuotas(cuota, Convert.ToDateTime(null), false, "eliminar");



                    foreach (ListViewItem item in listAbonosCuotas.Items)
                    {
                        if (item.Checked)
                        {
                            oAbonos.EliminarAbono_Cuotas_Id(lAbonos.Rows[item.Index].ItemArray[0].ToString());

                            saldo += Convert.ToDouble(lAbonos.Rows[item.Index].ItemArray[2]);

                        }
                    }

                }

                EditarSaldoPrestamo(saldo);

                LimpiarValores();

                CargarAbonos(cuota);

                abonos.CargarPrestamos();



            }

        }

    }
}
