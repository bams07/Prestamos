namespace Prestamos.Vista.Ventanas
{
    partial class frmPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            this.lblClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dia_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckRecargos = new System.Windows.Forms.CheckBox();
            this.MenuPrestamo = new System.Windows.Forms.MenuStrip();
            this.nuevoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPrestamoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFechasCuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.panel1.SuspendLayout();
            this.MenuPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(12, 26);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(50, 17);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripcion:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(100, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(178, 17);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "----------------------------------";
            this.lblDescripcion.Visible = false;
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.AllowUserToResizeColumns = false;
            this.dtgPrestamos.AllowUserToResizeRows = false;
            this.dtgPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dtgPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.Fecha,
            this.Monto,
            this.Interes,
            this.Cuotas,
            this.Saldo,
            this.Total,
            this.Recargo,
            this.Dia_Pago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPrestamos.Location = new System.Drawing.Point(8, 168);
            this.dtgPrestamos.MultiSelect = false;
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamos.ShowCellErrors = false;
            this.dtgPrestamos.ShowCellToolTips = false;
            this.dtgPrestamos.ShowEditingIcon = false;
            this.dtgPrestamos.ShowRowErrors = false;
            this.dtgPrestamos.Size = new System.Drawing.Size(795, 232);
            this.dtgPrestamos.TabIndex = 13;
            this.dtgPrestamos.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Numero";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "cliente";
            this.Client.HeaderText = "Cliente";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Interes.DataPropertyName = "interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Width = 75;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuotas.DataPropertyName = "cuotas";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Width = 75;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            // 
            // Dia_Pago
            // 
            this.Dia_Pago.DataPropertyName = "dia_pago";
            this.Dia_Pago.HeaderText = "Dia pago";
            this.Dia_Pago.Name = "Dia_Pago";
            this.Dia_Pago.ReadOnly = true;
            this.Dia_Pago.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckRecargos);
            this.panel1.Controls.Add(this.MenuPrestamo);
            this.panel1.Location = new System.Drawing.Point(8, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 35);
            this.panel1.TabIndex = 14;
            // 
            // ckRecargos
            // 
            this.ckRecargos.AutoSize = true;
            this.ckRecargos.BackColor = System.Drawing.SystemColors.Control;
            this.ckRecargos.Checked = true;
            this.ckRecargos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRecargos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRecargos.Location = new System.Drawing.Point(190, 7);
            this.ckRecargos.Name = "ckRecargos";
            this.ckRecargos.Size = new System.Drawing.Size(130, 21);
            this.ckRecargos.TabIndex = 31;
            this.ckRecargos.Text = "Mostrar recargos";
            this.ckRecargos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ckRecargos.UseVisualStyleBackColor = false;
            this.ckRecargos.CheckStateChanged += new System.EventHandler(this.ckRecargos_CheckStateChanged);
            // 
            // MenuPrestamo
            // 
            this.MenuPrestamo.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPrestamo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrestamo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestamoToolStripMenuItem,
            this.abonosToolStripMenuItem});
            this.MenuPrestamo.Location = new System.Drawing.Point(0, 0);
            this.MenuPrestamo.Name = "MenuPrestamo";
            this.MenuPrestamo.Size = new System.Drawing.Size(593, 35);
            this.MenuPrestamo.TabIndex = 0;
            this.MenuPrestamo.Text = "menuStrip1";
            // 
            // nuevoPrestamoToolStripMenuItem
            // 
            this.nuevoPrestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestamoToolStripMenuItem1,
            this.editarFechasCuotasToolStripMenuItem,
            this.recargoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.nuevoPrestamoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoPrestamoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoPrestamoToolStripMenuItem.Image")));
            this.nuevoPrestamoToolStripMenuItem.Name = "nuevoPrestamoToolStripMenuItem";
            this.nuevoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(94, 31);
            this.nuevoPrestamoToolStripMenuItem.Text = "Prestamo";
            // 
            // nuevoPrestamoToolStripMenuItem1
            // 
            this.nuevoPrestamoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoPrestamoToolStripMenuItem1.Name = "nuevoPrestamoToolStripMenuItem1";
            this.nuevoPrestamoToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevoPrestamoToolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.nuevoPrestamoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nuevoPrestamoToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.nuevoPrestamoToolStripMenuItem1.Text = "Nuevo prestamo";
            this.nuevoPrestamoToolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.nuevoPrestamoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoPrestamoToolStripMenuItem1_Click);
            // 
            // editarFechasCuotasToolStripMenuItem
            // 
            this.editarFechasCuotasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarFechasCuotasToolStripMenuItem.Name = "editarFechasCuotasToolStripMenuItem";
            this.editarFechasCuotasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editarFechasCuotasToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.editarFechasCuotasToolStripMenuItem.Text = "Editar fechas cuotas";
            this.editarFechasCuotasToolStripMenuItem.Click += new System.EventHandler(this.editarFechasCuotasToolStripMenuItem_Click);
            // 
            // recargoToolStripMenuItem
            // 
            this.recargoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recargoToolStripMenuItem.Name = "recargoToolStripMenuItem";
            this.recargoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.recargoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.recargoToolStripMenuItem.Text = "Recargo prestamo";
            this.recargoToolStripMenuItem.Click += new System.EventHandler(this.recargoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar prestamo";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // abonosToolStripMenuItem
            // 
            this.abonosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abonosToolStripMenuItem.Image")));
            this.abonosToolStripMenuItem.Name = "abonosToolStripMenuItem";
            this.abonosToolStripMenuItem.Size = new System.Drawing.Size(83, 31);
            this.abonosToolStripMenuItem.Text = "Abonos";
            this.abonosToolStripMenuItem.Click += new System.EventHandler(this.abonosToolStripMenuItem_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(284, 23);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(48, 25);
            this.btnClientes.TabIndex = 15;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(100, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(178, 25);
            this.txtCliente.TabIndex = 16;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(819, 428);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgPrestamos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuPrestamo.ResumeLayout(false);
            this.MenuPrestamo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MenuPrestamo;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrestamoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abonosToolStripMenuItem;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.DataGridView dtgPrestamos;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ToolStripMenuItem recargoToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckRecargos;
        private System.Windows.Forms.ToolStripMenuItem editarFechasCuotasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Pago;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}