namespace Prestamos.Vista.Ventanas
{
    partial class frmAbonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtgCuotas = new System.Windows.Forms.DataGridView();
            this.num_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pactada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.abonos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuCuotas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNuevoAbono = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimirPreliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarAbono = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimirCuotas = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImprimirTicket = new System.Drawing.Printing.PrintDocument();
            this.NumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPrestamo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancelarPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DiaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).BeginInit();
            this.menuCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            resources.ApplyResources(this.lblClientes, "lblClientes");
            this.lblClientes.Name = "lblClientes";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblDescripcion
            // 
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // btnClientes
            // 
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtCliente
            // 
            resources.ApplyResources(this.txtCliente, "txtCliente");
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // dtgCuotas
            // 
            this.dtgCuotas.AllowUserToAddRows = false;
            this.dtgCuotas.AllowUserToDeleteRows = false;
            this.dtgCuotas.AllowUserToResizeRows = false;
            this.dtgCuotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_cuota,
            this.fecha_pactada,
            this.fecha_pago,
            this.monto_cuota,
            this.saldo,
            this.id,
            this.id_prestamos,
            this.pago,
            this.abonos});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCuotas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCuotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCuotas.EnableHeadersVisualStyles = false;
            this.dtgCuotas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.dtgCuotas, "dtgCuotas");
            this.dtgCuotas.Name = "dtgCuotas";
            this.dtgCuotas.ReadOnly = true;
            this.dtgCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dtgCuotas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCuotas.RowTemplate.ContextMenuStrip = this.menuCuotas;
            this.dtgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCuotas.ShowCellToolTips = false;
            this.dtgCuotas.ShowEditingIcon = false;
            this.dtgCuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCuotas_CellContentClick);
            // 
            // num_cuota
            // 
            this.num_cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.num_cuota.DataPropertyName = "num_cuota";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.num_cuota.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.num_cuota, "num_cuota");
            this.num_cuota.Name = "num_cuota";
            this.num_cuota.ReadOnly = true;
            this.num_cuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha_pactada
            // 
            this.fecha_pactada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pactada.DataPropertyName = "fecha_pactada";
            resources.ApplyResources(this.fecha_pactada, "fecha_pactada");
            this.fecha_pactada.Name = "fecha_pactada";
            this.fecha_pactada.ReadOnly = true;
            this.fecha_pactada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha_pago
            // 
            this.fecha_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pago.DataPropertyName = "fecha_pago";
            resources.ApplyResources(this.fecha_pago, "fecha_pago");
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.ReadOnly = true;
            this.fecha_pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monto_cuota
            // 
            this.monto_cuota.DataPropertyName = "monto";
            resources.ApplyResources(this.monto_cuota, "monto_cuota");
            this.monto_cuota.Name = "monto_cuota";
            this.monto_cuota.ReadOnly = true;
            this.monto_cuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            resources.ApplyResources(this.saldo, "saldo");
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // id_prestamos
            // 
            this.id_prestamos.DataPropertyName = "id_prestamos";
            resources.ApplyResources(this.id_prestamos, "id_prestamos");
            this.id_prestamos.Name = "id_prestamos";
            this.id_prestamos.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            resources.ApplyResources(this.pago, "pago");
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // abonos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.abonos.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.abonos, "abonos");
            this.abonos.Name = "abonos";
            this.abonos.ReadOnly = true;
            this.abonos.Text = "Abonos";
            // 
            // menuCuotas
            // 
            resources.ApplyResources(this.menuCuotas, "menuCuotas");
            this.menuCuotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoAbono,
            this.btnReimprimir,
            this.btnImprimirPreliminar,
            this.btnEliminarAbono,
            this.btnImprimirCuotas});
            this.menuCuotas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuCuotas.Name = "menuCuotas";
            this.menuCuotas.Opening += new System.ComponentModel.CancelEventHandler(this.menuCuotas_Opening);
            // 
            // btnNuevoAbono
            // 
            this.btnNuevoAbono.Name = "btnNuevoAbono";
            resources.ApplyResources(this.btnNuevoAbono, "btnNuevoAbono");
            this.btnNuevoAbono.Click += new System.EventHandler(this.btnNuevoAbono_Click);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Name = "btnReimprimir";
            resources.ApplyResources(this.btnReimprimir, "btnReimprimir");
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // btnImprimirPreliminar
            // 
            this.btnImprimirPreliminar.Name = "btnImprimirPreliminar";
            resources.ApplyResources(this.btnImprimirPreliminar, "btnImprimirPreliminar");
            this.btnImprimirPreliminar.Click += new System.EventHandler(this.btnImprimirPreliminar_Click);
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            resources.ApplyResources(this.btnEliminarAbono, "btnEliminarAbono");
            this.btnEliminarAbono.Click += new System.EventHandler(this.btnEliminarAbono_Click);
            // 
            // btnImprimirCuotas
            // 
            this.btnImprimirCuotas.Name = "btnImprimirCuotas";
            resources.ApplyResources(this.btnImprimirCuotas, "btnImprimirCuotas");
            this.btnImprimirCuotas.Click += new System.EventHandler(this.btnImprimirCuotas_Click);
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrestamo,
            this.monto,
            this.fechaPrestamo,
            this.client,
            this.Interes,
            this.dataGridViewTextBoxColumn4,
            this.saldoPrestamo,
            this.Total1,
            this.Recargo,
            this.DiaPago,
            this.Eliminado});
            this.dtgPrestamos.EnableHeadersVisualStyles = false;
            this.dtgPrestamos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.dtgPrestamos, "dtgPrestamos");
            this.dtgPrestamos.MultiSelect = false;
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamos.ShowCellErrors = false;
            this.dtgPrestamos.ShowCellToolTips = false;
            this.dtgPrestamos.ShowEditingIcon = false;
            this.dtgPrestamos.ShowRowErrors = false;
            this.dtgPrestamos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgPrestamos_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCuotas);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPrestamos);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ImprimirTicket
            // 
            this.ImprimirTicket.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirTicket_PrintPage);
            // 
            // NumeroCuota
            // 
            this.NumeroCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumeroCuota.DataPropertyName = "num_cuota";
            resources.ApplyResources(this.NumeroCuota, "NumeroCuota");
            this.NumeroCuota.Name = "NumeroCuota";
            // 
            // menuPrestamo
            // 
            resources.ApplyResources(this.menuPrestamo, "menuPrestamo");
            this.menuPrestamo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelarPrestamo});
            this.menuPrestamo.Name = "menuPrestamo";
            this.menuPrestamo.Opening += new System.ComponentModel.CancelEventHandler(this.menuPrestamo_Opening);
            // 
            // btnCancelarPrestamo
            // 
            this.btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            resources.ApplyResources(this.btnCancelarPrestamo, "btnCancelarPrestamo");
            this.btnCancelarPrestamo.Click += new System.EventHandler(this.btnCancelarPrestamo_Click);
            // 
            // idPrestamo
            // 
            this.idPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idPrestamo.ContextMenuStrip = this.menuPrestamo;
            this.idPrestamo.DataPropertyName = "id";
            resources.ApplyResources(this.idPrestamo, "idPrestamo");
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.ContextMenuStrip = this.menuPrestamo;
            this.monto.DataPropertyName = "monto";
            resources.ApplyResources(this.monto, "monto");
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaPrestamo.ContextMenuStrip = this.menuPrestamo;
            this.fechaPrestamo.DataPropertyName = "fecha";
            resources.ApplyResources(this.fechaPrestamo, "fechaPrestamo");
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.ReadOnly = true;
            // 
            // client
            // 
            this.client.ContextMenuStrip = this.menuPrestamo;
            this.client.DataPropertyName = "cliente";
            resources.ApplyResources(this.client, "client");
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.ContextMenuStrip = this.menuPrestamo;
            this.Interes.DataPropertyName = "interes";
            resources.ApplyResources(this.Interes, "Interes");
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.ContextMenuStrip = this.menuPrestamo;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cuotas";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // saldoPrestamo
            // 
            this.saldoPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.saldoPrestamo.ContextMenuStrip = this.menuPrestamo;
            this.saldoPrestamo.DataPropertyName = "saldo";
            resources.ApplyResources(this.saldoPrestamo, "saldoPrestamo");
            this.saldoPrestamo.Name = "saldoPrestamo";
            this.saldoPrestamo.ReadOnly = true;
            // 
            // Total1
            // 
            this.Total1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total1.ContextMenuStrip = this.menuPrestamo;
            this.Total1.DataPropertyName = "total";
            resources.ApplyResources(this.Total1, "Total1");
            this.Total1.Name = "Total1";
            this.Total1.ReadOnly = true;
            // 
            // Recargo
            // 
            this.Recargo.ContextMenuStrip = this.menuPrestamo;
            this.Recargo.DataPropertyName = "recargo";
            resources.ApplyResources(this.Recargo, "Recargo");
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            // 
            // DiaPago
            // 
            this.DiaPago.ContextMenuStrip = this.menuPrestamo;
            this.DiaPago.DataPropertyName = "dia_pago";
            resources.ApplyResources(this.DiaPago, "DiaPago");
            this.DiaPago.Name = "DiaPago";
            this.DiaPago.ReadOnly = true;
            // 
            // Eliminado
            // 
            this.Eliminado.ContextMenuStrip = this.menuPrestamo;
            this.Eliminado.DataPropertyName = "eliminado";
            resources.ApplyResources(this.Eliminado, "Eliminado");
            this.Eliminado.Name = "Eliminado";
            this.Eliminado.ReadOnly = true;
            // 
            // frmAbonos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbonos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).EndInit();
            this.menuCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuPrestamo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip menuCuotas;
        private System.Windows.Forms.ToolStripMenuItem btnNuevoAbono;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarAbono;
        public System.Windows.Forms.DataGridView dtgCuotas;
        public System.Windows.Forms.DataGridView dtgPrestamos;
        private System.Windows.Forms.ToolStripMenuItem btnReimprimir;
        private System.Drawing.Printing.PrintDocument ImprimirTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pactada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewButtonColumn abonos;
        private System.Windows.Forms.ToolStripMenuItem btnImprimirPreliminar;
        private System.Windows.Forms.ToolStripMenuItem btnImprimirCuotas;
        private System.Windows.Forms.ContextMenuStrip menuPrestamo;
        private System.Windows.Forms.ToolStripMenuItem btnCancelarPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminado;
    }
}