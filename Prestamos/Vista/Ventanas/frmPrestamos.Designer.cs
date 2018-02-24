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
            this.montoRecargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dia_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckBoxMostrarEliminados = new System.Windows.Forms.CheckBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrestamoMonto = new System.Windows.Forms.Label();
            this.lblTotalPrestamoGanancia = new System.Windows.Forms.Label();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalRecargos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.restaurarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1.Text = "Descripción:";
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
            this.montoRecargo,
            this.Recargo,
            this.Dia_Pago,
            this.Eliminado});
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
            this.dtgPrestamos.Size = new System.Drawing.Size(895, 232);
            this.dtgPrestamos.TabIndex = 13;
            this.dtgPrestamos.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Número";
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
            this.Interes.HeaderText = "Interés";
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
            // montoRecargo
            // 
            this.montoRecargo.DataPropertyName = "montoRecargo";
            this.montoRecargo.HeaderText = "M. Recargo";
            this.montoRecargo.Name = "montoRecargo";
            this.montoRecargo.ReadOnly = true;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            this.Recargo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Dia_Pago
            // 
            this.Dia_Pago.DataPropertyName = "dia_pago";
            this.Dia_Pago.HeaderText = "Dia pago";
            this.Dia_Pago.Name = "Dia_Pago";
            this.Dia_Pago.ReadOnly = true;
            this.Dia_Pago.Visible = false;
            // 
            // Eliminado
            // 
            this.Eliminado.DataPropertyName = "eliminado";
            this.Eliminado.HeaderText = "Eliminado";
            this.Eliminado.Name = "Eliminado";
            this.Eliminado.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckBoxMostrarEliminados);
            this.panel1.Controls.Add(this.ckRecargos);
            this.panel1.Controls.Add(this.MenuPrestamo);
            this.panel1.Location = new System.Drawing.Point(8, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 35);
            this.panel1.TabIndex = 14;
            // 
            // ckBoxMostrarEliminados
            // 
            this.ckBoxMostrarEliminados.AutoSize = true;
            this.ckBoxMostrarEliminados.BackColor = System.Drawing.SystemColors.Control;
            this.ckBoxMostrarEliminados.Checked = true;
            this.ckBoxMostrarEliminados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxMostrarEliminados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxMostrarEliminados.Location = new System.Drawing.Point(338, 7);
            this.ckBoxMostrarEliminados.Name = "ckBoxMostrarEliminados";
            this.ckBoxMostrarEliminados.Size = new System.Drawing.Size(141, 21);
            this.ckBoxMostrarEliminados.TabIndex = 32;
            this.ckBoxMostrarEliminados.Text = "Mostrar eliminados";
            this.ckBoxMostrarEliminados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ckBoxMostrarEliminados.UseVisualStyleBackColor = false;
            this.ckBoxMostrarEliminados.CheckStateChanged += new System.EventHandler(this.ckBoxMostrarEliminados_CheckStateChanged);
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
            this.eliminarToolStripMenuItem,
            this.restaurarPrestamoToolStripMenuItem});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total prestamos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total ganancia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrestamoMonto
            // 
            this.lblTotalPrestamoMonto.AutoSize = true;
            this.lblTotalPrestamoMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrestamoMonto.Location = new System.Drawing.Point(124, 98);
            this.lblTotalPrestamoMonto.Name = "lblTotalPrestamoMonto";
            this.lblTotalPrestamoMonto.Size = new System.Drawing.Size(57, 17);
            this.lblTotalPrestamoMonto.TabIndex = 19;
            this.lblTotalPrestamoMonto.Text = "0000000";
            // 
            // lblTotalPrestamoGanancia
            // 
            this.lblTotalPrestamoGanancia.AutoSize = true;
            this.lblTotalPrestamoGanancia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrestamoGanancia.Location = new System.Drawing.Point(322, 98);
            this.lblTotalPrestamoGanancia.Name = "lblTotalPrestamoGanancia";
            this.lblTotalPrestamoGanancia.Size = new System.Drawing.Size(57, 17);
            this.lblTotalPrestamoGanancia.TabIndex = 20;
            this.lblTotalPrestamoGanancia.Text = "0000000";
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos.Location = new System.Drawing.Point(512, 98);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(57, 17);
            this.lblTotalSaldos.TabIndex = 22;
            this.lblTotalSaldos.Text = "0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total saldos:";
            // 
            // lblTotalRecargos
            // 
            this.lblTotalRecargos.AutoSize = true;
            this.lblTotalRecargos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecargos.Location = new System.Drawing.Point(721, 98);
            this.lblTotalRecargos.Name = "lblTotalRecargos";
            this.lblTotalRecargos.Size = new System.Drawing.Size(57, 17);
            this.lblTotalRecargos.TabIndex = 24;
            this.lblTotalRecargos.Text = "0000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total recargos:";
            // 
            // restaurarPrestamoToolStripMenuItem
            // 
            this.restaurarPrestamoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.restaurarPrestamoToolStripMenuItem.Name = "restaurarPrestamoToolStripMenuItem";
            this.restaurarPrestamoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.restaurarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.restaurarPrestamoToolStripMenuItem.Text = "Restaurar prestamo";
            this.restaurarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.restaurarPrestamoToolStripMenuItem_Click);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(910, 428);
            this.Controls.Add(this.lblTotalRecargos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalSaldos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalPrestamoGanancia);
            this.Controls.Add(this.lblTotalPrestamoMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrestamoMonto;
        private System.Windows.Forms.Label lblTotalPrestamoGanancia;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalRecargos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoRecargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminado;
        private System.Windows.Forms.CheckBox ckBoxMostrarEliminados;
        private System.Windows.Forms.ToolStripMenuItem restaurarPrestamoToolStripMenuItem;
    }
}