namespace Prestamos.Vista.Ventanas
{
    partial class frmAbonosCuotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonosCuotas));
            this.listAbonosCuotas = new System.Windows.Forms.ListView();
            this.MenuAbonos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarAbonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbonos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAbonosCuotas
            // 
            this.listAbonosCuotas.BackColor = System.Drawing.SystemColors.Control;
            this.listAbonosCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAbonosCuotas.CheckBoxes = true;
            this.listAbonosCuotas.ContextMenuStrip = this.MenuAbonos;
            this.listAbonosCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAbonosCuotas.FullRowSelect = true;
            this.listAbonosCuotas.LabelWrap = false;
            this.listAbonosCuotas.Location = new System.Drawing.Point(0, 0);
            this.listAbonosCuotas.MultiSelect = false;
            this.listAbonosCuotas.Name = "listAbonosCuotas";
            this.listAbonosCuotas.Size = new System.Drawing.Size(301, 295);
            this.listAbonosCuotas.TabIndex = 0;
            this.listAbonosCuotas.UseCompatibleStateImageBehavior = false;
            this.listAbonosCuotas.View = System.Windows.Forms.View.SmallIcon;
            // 
            // MenuAbonos
            // 
            this.MenuAbonos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAbonos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarAbonoToolStripMenuItem});
            this.MenuAbonos.Name = "MenuAbonos";
            this.MenuAbonos.Size = new System.Drawing.Size(204, 48);
            // 
            // eliminarAbonoToolStripMenuItem
            // 
            this.eliminarAbonoToolStripMenuItem.Name = "eliminarAbonoToolStripMenuItem";
            this.eliminarAbonoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarAbonoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.eliminarAbonoToolStripMenuItem.Text = "Eliminar abono";
            this.eliminarAbonoToolStripMenuItem.Click += new System.EventHandler(this.eliminarAbonoToolStripMenuItem_Click);
            // 
            // frmAbonosCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 295);
            this.Controls.Add(this.listAbonosCuotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbonosCuotas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagos adelantados";
            this.MenuAbonos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAbonosCuotas;
        private System.Windows.Forms.ContextMenuStrip MenuAbonos;
        private System.Windows.Forms.ToolStripMenuItem eliminarAbonoToolStripMenuItem;

    }
}