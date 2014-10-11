namespace Prestamos.Vista.Ventanas
{
    partial class frmRecargoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecargoPrestamo));
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
            this.num_cuotaPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pactadaPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestamoPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pagoPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPrevisualzacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.lblMonto = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.id_prestamo.HeaderText = "ID oPrestamo";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCuotasPrevias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCuotasPrevias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotasPrevias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_cuotaPre,
            this.fecha_pactadaPre,
            this.montoPre,
            this.saldoPre,
            this.idPre,
            this.id_prestamoPre,
            this.pagoPre,
            this.fecha_pagoPre});
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
            // 
            // num_cuotaPre
            // 
            this.num_cuotaPre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.num_cuotaPre.DataPropertyName = "num_cuota";
            this.num_cuotaPre.HeaderText = "Numero cuota";
            this.num_cuotaPre.Name = "num_cuotaPre";
            this.num_cuotaPre.ReadOnly = true;
            this.num_cuotaPre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.num_cuotaPre.Width = 125;
            // 
            // fecha_pactadaPre
            // 
            this.fecha_pactadaPre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pactadaPre.DataPropertyName = "fecha_pactada";
            this.fecha_pactadaPre.HeaderText = "Fecha pactada";
            this.fecha_pactadaPre.Name = "fecha_pactadaPre";
            this.fecha_pactadaPre.ReadOnly = true;
            this.fecha_pactadaPre.Width = 125;
            // 
            // montoPre
            // 
            this.montoPre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.montoPre.DataPropertyName = "monto";
            this.montoPre.HeaderText = "Monto";
            this.montoPre.Name = "montoPre";
            this.montoPre.ReadOnly = true;
            this.montoPre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saldoPre
            // 
            this.saldoPre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.saldoPre.DataPropertyName = "saldo";
            this.saldoPre.HeaderText = "Saldo";
            this.saldoPre.Name = "saldoPre";
            this.saldoPre.ReadOnly = true;
            this.saldoPre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.saldoPre.Width = 110;
            // 
            // idPre
            // 
            this.idPre.DataPropertyName = "id";
            this.idPre.HeaderText = "ID";
            this.idPre.Name = "idPre";
            this.idPre.ReadOnly = true;
            this.idPre.Visible = false;
            // 
            // id_prestamoPre
            // 
            this.id_prestamoPre.DataPropertyName = "id_prestamos";
            this.id_prestamoPre.HeaderText = "ID oPrestamo";
            this.id_prestamoPre.Name = "id_prestamoPre";
            this.id_prestamoPre.ReadOnly = true;
            this.id_prestamoPre.Visible = false;
            // 
            // pagoPre
            // 
            this.pagoPre.DataPropertyName = "pago";
            this.pagoPre.HeaderText = "pago";
            this.pagoPre.Name = "pagoPre";
            this.pagoPre.ReadOnly = true;
            this.pagoPre.Visible = false;
            // 
            // fecha_pagoPre
            // 
            this.fecha_pagoPre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_pagoPre.DataPropertyName = "fecha_pago";
            this.fecha_pagoPre.HeaderText = "Fecha de pago";
            this.fecha_pagoPre.Name = "fecha_pagoPre";
            this.fecha_pagoPre.ReadOnly = true;
            this.fecha_pagoPre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fecha_pagoPre.Visible = false;
            this.fecha_pagoPre.Width = 135;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMonto);
            this.groupBox3.Controls.Add(this.lblMonto);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 77);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recargo";
            // 
            // txtMonto
            // 
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.HidePromptOnLeave = true;
            this.txtMonto.Location = new System.Drawing.Point(206, 33);
            this.txtMonto.Mask = "₡000000000000";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.Size = new System.Drawing.Size(177, 25);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(100, 36);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(100, 17);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto recargo:";
            // 
            // frmRecargoPrestamo
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
            this.Name = "frmRecargoPrestamo";
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_cuotaPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pactadaPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamoPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pagoPre;
    }
}