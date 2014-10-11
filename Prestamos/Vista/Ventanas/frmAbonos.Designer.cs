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
            this.btnEliminarAbono = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImprimirTicket = new System.Drawing.Printing.PrintDocument();
            this.NumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprimirPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).BeginInit();
            this.menuCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // dtgCuotas
            // 
            this.dtgCuotas.AllowUserToAddRows = false;
            this.dtgCuotas.AllowUserToDeleteRows = false;
            this.dtgCuotas.AllowUserToResizeRows = false;
            this.dtgCuotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCuotas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCuotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCuotas.EnableHeadersVisualStyles = false;
            this.dtgCuotas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgCuotas.Location = new System.Drawing.Point(17, 26);
            this.dtgCuotas.MultiSelect = false;
            this.dtgCuotas.Name = "dtgCuotas";
            this.dtgCuotas.ReadOnly = true;
            this.dtgCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dtgCuotas.Size = new System.Drawing.Size(798, 157);
            this.dtgCuotas.TabIndex = 17;
            this.dtgCuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCuotas_CellContentClick);
            // 
            // num_cuota
            // 
            this.num_cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.num_cuota.DataPropertyName = "num_cuota";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.num_cuota.DefaultCellStyle = dataGridViewCellStyle2;
            this.num_cuota.HeaderText = "Numero cuota";
            this.num_cuota.Name = "num_cuota";
            this.num_cuota.ReadOnly = true;
            this.num_cuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.num_cuota.Width = 125;
            // 
            // fecha_pactada
            // 
            this.fecha_pactada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pactada.DataPropertyName = "fecha_pactada";
            this.fecha_pactada.HeaderText = "Fecha pactada";
            this.fecha_pactada.Name = "fecha_pactada";
            this.fecha_pactada.ReadOnly = true;
            this.fecha_pactada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fecha_pactada.Width = 125;
            // 
            // fecha_pago
            // 
            this.fecha_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pago.DataPropertyName = "fecha_pago";
            this.fecha_pago.HeaderText = "Fecha pago";
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.ReadOnly = true;
            this.fecha_pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fecha_pago.Width = 125;
            // 
            // monto_cuota
            // 
            this.monto_cuota.DataPropertyName = "monto";
            this.monto_cuota.HeaderText = "Monto";
            this.monto_cuota.Name = "monto_cuota";
            this.monto_cuota.ReadOnly = true;
            this.monto_cuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_prestamos
            // 
            this.id_prestamos.DataPropertyName = "id_prestamos";
            this.id_prestamos.HeaderText = "id_prestamo";
            this.id_prestamos.Name = "id_prestamos";
            this.id_prestamos.ReadOnly = true;
            this.id_prestamos.Visible = false;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // abonos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.abonos.DefaultCellStyle = dataGridViewCellStyle3;
            this.abonos.HeaderText = "Abonos";
            this.abonos.Name = "abonos";
            this.abonos.ReadOnly = true;
            this.abonos.Text = "Abonos";
            this.abonos.Width = 80;
            // 
            // menuCuotas
            // 
            this.menuCuotas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCuotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoAbono,
            this.btnReimprimir,
            this.imprimirPreliminarToolStripMenuItem,
            this.btnEliminarAbono});
            this.menuCuotas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuCuotas.Name = "menuCuotas";
            this.menuCuotas.Size = new System.Drawing.Size(228, 114);
            // 
            // btnNuevoAbono
            // 
            this.btnNuevoAbono.Name = "btnNuevoAbono";
            this.btnNuevoAbono.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.btnNuevoAbono.Size = new System.Drawing.Size(227, 22);
            this.btnNuevoAbono.Text = "Realizar abono";
            this.btnNuevoAbono.Click += new System.EventHandler(this.btnNuevoAbono_Click);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.btnReimprimir.Size = new System.Drawing.Size(227, 22);
            this.btnReimprimir.Text = "Reimprimir abono";
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            this.btnEliminarAbono.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.btnEliminarAbono.Size = new System.Drawing.Size(227, 22);
            this.btnEliminarAbono.Text = "Eliminar abono";
            this.btnEliminarAbono.Click += new System.EventHandler(this.btnEliminarAbono_Click);
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.monto,
            this.fechaPrestamo,
            this.client,
            this.Interes,
            this.dataGridViewTextBoxColumn4,
            this.saldoPrestamo,
            this.Total1,
            this.Recargo});
            this.dtgPrestamos.EnableHeadersVisualStyles = false;
            this.dtgPrestamos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgPrestamos.Location = new System.Drawing.Point(9, 32);
            this.dtgPrestamos.MultiSelect = false;
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamos.ShowCellErrors = false;
            this.dtgPrestamos.ShowCellToolTips = false;
            this.dtgPrestamos.ShowEditingIcon = false;
            this.dtgPrestamos.ShowRowErrors = false;
            this.dtgPrestamos.Size = new System.Drawing.Size(694, 135);
            this.dtgPrestamos.TabIndex = 18;
            this.dtgPrestamos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgPrestamos_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Visible = false;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaPrestamo.DataPropertyName = "fecha";
            this.fechaPrestamo.HeaderText = "Fecha";
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.ReadOnly = true;
            // 
            // client
            // 
            this.client.DataPropertyName = "cliente";
            this.client.HeaderText = "Cliente";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Visible = false;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cuotas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cuotas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // saldoPrestamo
            // 
            this.saldoPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.saldoPrestamo.DataPropertyName = "saldo";
            this.saldoPrestamo.HeaderText = "Saldo";
            this.saldoPrestamo.Name = "saldoPrestamo";
            this.saldoPrestamo.ReadOnly = true;
            this.saldoPrestamo.Width = 125;
            // 
            // Total1
            // 
            this.Total1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total1.DataPropertyName = "total";
            this.Total1.HeaderText = "Total";
            this.Total1.Name = "Total1";
            this.Total1.ReadOnly = true;
            this.Total1.Width = 150;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCuotas);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 301);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 193);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuotas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPrestamos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 182);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamos";
            // 
            // ImprimirTicket
            // 
            this.ImprimirTicket.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirTicket_PrintPage);
            // 
            // NumeroCuota
            // 
            this.NumeroCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumeroCuota.DataPropertyName = "num_cuota";
            this.NumeroCuota.HeaderText = "Numero cuota";
            this.NumeroCuota.Name = "NumeroCuota";
            this.NumeroCuota.Width = 117;
            // 
            // imprimirPreliminarToolStripMenuItem
            // 
            this.imprimirPreliminarToolStripMenuItem.Name = "imprimirPreliminarToolStripMenuItem";
            this.imprimirPreliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.imprimirPreliminarToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.imprimirPreliminarToolStripMenuItem.Text = "Imprimir preliminar";
            this.imprimirPreliminarToolStripMenuItem.Click += new System.EventHandler(this.imprimirPreliminarToolStripMenuItem_Click);
            // 
            // frmAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(866, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).EndInit();
            this.menuCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recargo;
        private System.Windows.Forms.ToolStripMenuItem imprimirPreliminarToolStripMenuItem;
    }
}