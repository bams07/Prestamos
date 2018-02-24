namespace Prestamos.Vista.Ventanas
{
    partial class frmEdicionCuotaFecha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicionCuotaFecha));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNumeroPrestamo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCuotas = new System.Windows.Forms.DataGridView();
            this.NumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPactada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCuotasPrevias = new System.Windows.Forms.DataGridView();
            this.NumeroCuotaPrevio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPagoPrevio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPrevio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoPrevio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCuotas = new System.Windows.Forms.MaskedTextBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiaPago = new System.Windows.Forms.ComboBox();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPrevisualzacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSaldoPrestamo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotasPrevias)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCliente.Location = new System.Drawing.Point(321, 28);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(241, 32);
            this.lblCliente.TabIndex = 35;
            this.lblCliente.Text = "Cliente del prestamo";
            // 
            // lblNumeroPrestamo
            // 
            this.lblNumeroPrestamo.AutoSize = true;
            this.lblNumeroPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPrestamo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNumeroPrestamo.Location = new System.Drawing.Point(292, 86);
            this.lblNumeroPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            this.lblNumeroPrestamo.Size = new System.Drawing.Size(119, 32);
            this.lblNumeroPrestamo.TabIndex = 34;
            this.lblNumeroPrestamo.Text = "00000000";
            this.lblNumeroPrestamo.Click += new System.EventHandler(this.lblNumeroPrestamo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(126, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "N° prestamo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCuotas);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(801, 221);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuotas";
            // 
            // dtgCuotas
            // 
            this.dtgCuotas.AllowUserToAddRows = false;
            this.dtgCuotas.AllowUserToDeleteRows = false;
            this.dtgCuotas.AllowUserToResizeRows = false;
            this.dtgCuotas.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCuota,
            this.FechaPactada,
            this.Cuota,
            this.Saldo,
            this.id_cuota,
            this.id_prestamo,
            this.pago,
            this.FechaPago});
            this.dtgCuotas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgCuotas.Location = new System.Drawing.Point(9, 38);
            this.dtgCuotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgCuotas.MultiSelect = false;
            this.dtgCuotas.Name = "dtgCuotas";
            this.dtgCuotas.ReadOnly = true;
            this.dtgCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCuotas.ShowCellErrors = false;
            this.dtgCuotas.ShowCellToolTips = false;
            this.dtgCuotas.ShowEditingIcon = false;
            this.dtgCuotas.ShowRowErrors = false;
            this.dtgCuotas.Size = new System.Drawing.Size(783, 165);
            this.dtgCuotas.TabIndex = 0;
            this.dtgCuotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCuotas_CellClick);
            // 
            // NumeroCuota
            // 
            this.NumeroCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumeroCuota.DataPropertyName = "num_cuota";
            this.NumeroCuota.HeaderText = "Numero cuota";
            this.NumeroCuota.Name = "NumeroCuota";
            this.NumeroCuota.ReadOnly = true;
            this.NumeroCuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroCuota.Width = 125;
            // 
            // FechaPactada
            // 
            this.FechaPactada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaPactada.DataPropertyName = "fecha_pactada";
            this.FechaPactada.HeaderText = "Fecha pactada";
            this.FechaPactada.Name = "FechaPactada";
            this.FechaPactada.ReadOnly = true;
            this.FechaPactada.Width = 125;
            // 
            // Cuota
            // 
            this.Cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuota.DataPropertyName = "monto";
            this.Cuota.HeaderText = "Monto";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            this.Cuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Saldo.DataPropertyName = "saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Saldo.Width = 110;
            // 
            // id_cuota
            // 
            this.id_cuota.DataPropertyName = "id";
            this.id_cuota.HeaderText = "ID";
            this.id_cuota.Name = "id_cuota";
            this.id_cuota.ReadOnly = true;
            this.id_cuota.Visible = false;
            // 
            // id_prestamo
            // 
            this.id_prestamo.DataPropertyName = "id_prestamos";
            this.id_prestamo.HeaderText = "ID prestamo";
            this.id_prestamo.Name = "id_prestamo";
            this.id_prestamo.ReadOnly = true;
            this.id_prestamo.Visible = false;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Visible = false;
            // 
            // FechaPago
            // 
            this.FechaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaPago.DataPropertyName = "fecha_pago";
            this.FechaPago.HeaderText = "Fecha de pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaPago.Visible = false;
            this.FechaPago.Width = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCuotasPrevias);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 632);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(801, 221);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Previsualización cuotas";
            // 
            // dtgCuotasPrevias
            // 
            this.dtgCuotasPrevias.AllowUserToAddRows = false;
            this.dtgCuotasPrevias.AllowUserToDeleteRows = false;
            this.dtgCuotasPrevias.AllowUserToResizeRows = false;
            this.dtgCuotasPrevias.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgCuotasPrevias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotasPrevias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCuotasPrevias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotasPrevias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCuotaPrevio,
            this.FechaPagoPrevio,
            this.MontoPrevio,
            this.SaldoPrevio});
            this.dtgCuotasPrevias.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgCuotasPrevias.Location = new System.Drawing.Point(9, 38);
            this.dtgCuotasPrevias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgCuotasPrevias.MultiSelect = false;
            this.dtgCuotasPrevias.Name = "dtgCuotasPrevias";
            this.dtgCuotasPrevias.ReadOnly = true;
            this.dtgCuotasPrevias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCuotasPrevias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCuotasPrevias.ShowCellErrors = false;
            this.dtgCuotasPrevias.ShowCellToolTips = false;
            this.dtgCuotasPrevias.ShowEditingIcon = false;
            this.dtgCuotasPrevias.ShowRowErrors = false;
            this.dtgCuotasPrevias.Size = new System.Drawing.Size(783, 165);
            this.dtgCuotasPrevias.TabIndex = 1;
            this.dtgCuotasPrevias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCuotasPrevias_CellClick);
            // 
            // NumeroCuotaPrevio
            // 
            this.NumeroCuotaPrevio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumeroCuotaPrevio.DataPropertyName = "Numero couta";
            this.NumeroCuotaPrevio.HeaderText = "Numero cuota";
            this.NumeroCuotaPrevio.Name = "NumeroCuotaPrevio";
            this.NumeroCuotaPrevio.ReadOnly = true;
            this.NumeroCuotaPrevio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroCuotaPrevio.Width = 125;
            // 
            // FechaPagoPrevio
            // 
            this.FechaPagoPrevio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaPagoPrevio.DataPropertyName = "Fecha de pago";
            this.FechaPagoPrevio.HeaderText = "Fecha pago";
            this.FechaPagoPrevio.Name = "FechaPagoPrevio";
            this.FechaPagoPrevio.ReadOnly = true;
            this.FechaPagoPrevio.Width = 125;
            // 
            // MontoPrevio
            // 
            this.MontoPrevio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MontoPrevio.DataPropertyName = "Monto";
            this.MontoPrevio.HeaderText = "Monto";
            this.MontoPrevio.Name = "MontoPrevio";
            this.MontoPrevio.ReadOnly = true;
            this.MontoPrevio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SaldoPrevio
            // 
            this.SaldoPrevio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SaldoPrevio.DataPropertyName = "Saldo";
            this.SaldoPrevio.HeaderText = "Saldo";
            this.SaldoPrevio.Name = "SaldoPrevio";
            this.SaldoPrevio.ReadOnly = true;
            this.SaldoPrevio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaldoPrevio.Width = 110;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCuotas);
            this.groupBox3.Controls.Add(this.lblCuotas);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbDiaPago);
            this.groupBox3.Controls.Add(this.dtFechaInicial);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(801, 176);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagos";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuotas.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCuotas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotas.HidePromptOnLeave = true;
            this.txtCuotas.Location = new System.Drawing.Point(152, 115);
            this.txtCuotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuotas.Mask = "₡000000000";
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCuotas.Size = new System.Drawing.Size(162, 33);
            this.txtCuotas.TabIndex = 30;
            this.txtCuotas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotas.Location = new System.Drawing.Point(22, 115);
            this.lblCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(130, 28);
            this.lblCuotas.TabIndex = 31;
            this.lblCuotas.Text = "Monto cuota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dia de pago:";
            // 
            // cmbDiaPago
            // 
            this.cmbDiaPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDiaPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiaPago.FormattingEnabled = true;
            this.cmbDiaPago.Items.AddRange(new object[] {
            "Diario",
            "Diario N/Domingos",
            "Semanal",
            "Bisemanal",
            "Quincenal",
            "Quincena especial",
            "Mensual"});
            this.cmbDiaPago.Location = new System.Drawing.Point(597, 49);
            this.cmbDiaPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDiaPago.Name = "cmbDiaPago";
            this.cmbDiaPago.Size = new System.Drawing.Size(180, 36);
            this.cmbDiaPago.TabIndex = 12;
            this.cmbDiaPago.Text = "Diario";
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(152, 49);
            this.dtFechaInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(298, 33);
            this.dtFechaInicial.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Inicial:";
            // 
            // btnGenerarPrevisualzacion
            // 
            this.btnGenerarPrevisualzacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPrevisualzacion.Location = new System.Drawing.Point(273, 564);
            this.btnGenerarPrevisualzacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarPrevisualzacion.Name = "btnGenerarPrevisualzacion";
            this.btnGenerarPrevisualzacion.Size = new System.Drawing.Size(325, 46);
            this.btnGenerarPrevisualzacion.TabIndex = 39;
            this.btnGenerarPrevisualzacion.Text = "Generar previsualización";
            this.btnGenerarPrevisualzacion.UseVisualStyleBackColor = true;
            this.btnGenerarPrevisualzacion.Click += new System.EventHandler(this.btnGenerarPrevisualzacion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(447, 892);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 86);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(249, 892);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 86);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSaldoPrestamo
            // 
            this.lblSaldoPrestamo.AutoSize = true;
            this.lblSaldoPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoPrestamo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSaldoPrestamo.Location = new System.Drawing.Point(651, 86);
            this.lblSaldoPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoPrestamo.Name = "lblSaldoPrestamo";
            this.lblSaldoPrestamo.Size = new System.Drawing.Size(119, 32);
            this.lblSaldoPrestamo.TabIndex = 43;
            this.lblSaldoPrestamo.Text = "00000000";
            this.lblSaldoPrestamo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(452, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "Saldo prestamo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(419, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 32);
            this.label4.TabIndex = 44;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // frmEdicionCuotaFecha
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(892, 995);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldoPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnGenerarPrevisualzacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumeroPrestamo);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdicionCuotaFecha";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prestamos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotasPrevias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumeroPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDiaPago;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPrevisualzacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPactada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridView dtgCuotasPrevias;
        private System.Windows.Forms.MaskedTextBox txtCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuotaPrevio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPagoPrevio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPrevio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoPrevio;
        private System.Windows.Forms.Label lblSaldoPrestamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}