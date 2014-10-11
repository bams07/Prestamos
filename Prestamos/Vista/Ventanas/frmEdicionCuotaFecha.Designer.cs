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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiaPago = new System.Windows.Forms.ComboBox();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPrevisualzacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pactada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestamo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblCliente.Location = new System.Drawing.Point(298, 40);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(170, 21);
            this.lblCliente.TabIndex = 35;
            this.lblCliente.Text = "Luis Miranda Bejarano";
            // 
            // lblNumeroPrestamo
            // 
            this.lblNumeroPrestamo.AutoSize = true;
            this.lblNumeroPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPrestamo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNumeroPrestamo.Location = new System.Drawing.Point(166, 40);
            this.lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            this.lblNumeroPrestamo.Size = new System.Drawing.Size(82, 21);
            this.lblNumeroPrestamo.TabIndex = 34;
            this.lblNumeroPrestamo.Text = "00000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(62, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "N° prestamo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCuotas);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 144);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            this.dtgCuotas.Location = new System.Drawing.Point(6, 24);
            this.dtgCuotas.MultiSelect = false;
            this.dtgCuotas.Name = "dtgCuotas";
            this.dtgCuotas.ReadOnly = true;
            this.dtgCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCuotas.ShowCellErrors = false;
            this.dtgCuotas.ShowCellToolTips = false;
            this.dtgCuotas.ShowEditingIcon = false;
            this.dtgCuotas.ShowRowErrors = false;
            this.dtgCuotas.Size = new System.Drawing.Size(522, 107);
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
            this.groupBox1.Location = new System.Drawing.Point(35, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 144);
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotasPrevias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgCuotasPrevias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotasPrevias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fecha_pactada,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.id,
            this.id_prestamo2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgCuotasPrevias.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgCuotasPrevias.Location = new System.Drawing.Point(6, 24);
            this.dtgCuotasPrevias.MultiSelect = false;
            this.dtgCuotasPrevias.Name = "dtgCuotasPrevias";
            this.dtgCuotasPrevias.ReadOnly = true;
            this.dtgCuotasPrevias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCuotasPrevias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCuotasPrevias.ShowCellErrors = false;
            this.dtgCuotasPrevias.ShowCellToolTips = false;
            this.dtgCuotasPrevias.ShowEditingIcon = false;
            this.dtgCuotasPrevias.ShowRowErrors = false;
            this.dtgCuotasPrevias.Size = new System.Drawing.Size(522, 107);
            this.dtgCuotasPrevias.TabIndex = 1;
            this.dtgCuotasPrevias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCuotasPrevias_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbDiaPago);
            this.groupBox3.Controls.Add(this.dtFechaInicial);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 77);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
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
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.cmbDiaPago.Location = new System.Drawing.Point(393, 29);
            this.cmbDiaPago.Name = "cmbDiaPago";
            this.cmbDiaPago.Size = new System.Drawing.Size(121, 25);
            this.cmbDiaPago.TabIndex = 12;
            this.cmbDiaPago.Text = "Diario";
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(97, 29);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 25);
            this.dtFechaInicial.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Inicial:";
            // 
            // btnGenerarPrevisualzacion
            // 
            this.btnGenerarPrevisualzacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPrevisualzacion.Location = new System.Drawing.Point(187, 346);
            this.btnGenerarPrevisualzacion.Name = "btnGenerarPrevisualzacion";
            this.btnGenerarPrevisualzacion.Size = new System.Drawing.Size(217, 30);
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
            this.btnCancelar.Location = new System.Drawing.Point(302, 560);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 56);
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
            this.btnGuardar.Location = new System.Drawing.Point(170, 560);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 56);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_cuota";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero cuota";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // fecha_pactada
            // 
            this.fecha_pactada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pactada.DataPropertyName = "fecha_pactada";
            this.fecha_pactada.HeaderText = "Fecha pactada";
            this.fecha_pactada.Name = "fecha_pactada";
            this.fecha_pactada.ReadOnly = true;
            this.fecha_pactada.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "saldo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_prestamo2
            // 
            this.id_prestamo2.DataPropertyName = "id_prestamos";
            this.id_prestamo2.HeaderText = "ID prestamo";
            this.id_prestamo2.Name = "id_prestamo2";
            this.id_prestamo2.ReadOnly = true;
            this.id_prestamo2.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pago";
            this.dataGridViewTextBoxColumn7.HeaderText = "pago";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha_pago";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha de pago";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 135;
            // 
            // frmEdicionCuotaFecha
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(595, 647);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pactada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}