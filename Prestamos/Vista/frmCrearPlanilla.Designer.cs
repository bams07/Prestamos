namespace Prestamos.Vista.Ventanas
{
    partial class frmCargarPlanillaProcesada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarPlanillaProcesada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.menuCuotas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimirCuotas = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ImprimirTickets = new System.Drawing.Printing.PrintDocument();
            this.lblTotalCuotasSeleccionadas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCuotas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPrestamosCuotas = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamos_cuotas_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_pactada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuCuotas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamosCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(435, 47);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 56);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(313, 47);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(116, 56);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Tag = "1";
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(12, 68);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(51, 17);
            this.lblDetalle.TabIndex = 13;
            this.lblDetalle.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(69, 47);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(238, 56);
            this.txtDetalle.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFecha.Location = new System.Drawing.Point(129, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 21);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "20/05/2014";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(557, 47);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 56);
            this.btnImprimir.TabIndex = 35;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // menuCuotas
            // 
            this.menuCuotas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCuotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirCuotas});
            this.menuCuotas.Name = "menuCuotas";
            this.menuCuotas.Size = new System.Drawing.Size(208, 26);
            // 
            // imprimirCuotas
            // 
            this.imprimirCuotas.Name = "imprimirCuotas";
            this.imprimirCuotas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.imprimirCuotas.Size = new System.Drawing.Size(207, 22);
            this.imprimirCuotas.Text = "Imprimir cuotas";
            this.imprimirCuotas.Click += new System.EventHandler(this.imprimirCuotas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(662, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 56);
            this.panel1.TabIndex = 36;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(62, 19);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(59, 21);
            this.lblValorTotal.TabIndex = 22;
            this.lblValorTotal.Text = "₡ 0000";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(15, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 21);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // ImprimirTickets
            // 
            this.ImprimirTickets.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirTickets_PrintPage);
            // 
            // lblTotalCuotasSeleccionadas
            // 
            this.lblTotalCuotasSeleccionadas.AutoSize = true;
            this.lblTotalCuotasSeleccionadas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCuotasSeleccionadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalCuotasSeleccionadas.Location = new System.Drawing.Point(350, 123);
            this.lblTotalCuotasSeleccionadas.Name = "lblTotalCuotasSeleccionadas";
            this.lblTotalCuotasSeleccionadas.Size = new System.Drawing.Size(55, 21);
            this.lblTotalCuotasSeleccionadas.TabIndex = 45;
            this.lblTotalCuotasSeleccionadas.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(187, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cuotas selecionadas:";
            // 
            // lblTotalCuotas
            // 
            this.lblTotalCuotas.AutoSize = true;
            this.lblTotalCuotas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCuotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalCuotas.Location = new System.Drawing.Point(120, 123);
            this.lblTotalCuotas.Name = "lblTotalCuotas";
            this.lblTotalCuotas.Size = new System.Drawing.Size(55, 21);
            this.lblTotalCuotas.TabIndex = 43;
            this.lblTotalCuotas.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total cuotas:";
            // 
            // dtgPrestamosCuotas
            // 
            this.dtgPrestamosCuotas.AllowUserToAddRows = false;
            this.dtgPrestamosCuotas.AllowUserToDeleteRows = false;
            this.dtgPrestamosCuotas.AllowUserToResizeRows = false;
            this.dtgPrestamosCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPrestamosCuotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrestamosCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPrestamosCuotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrestamosCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrestamosCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamosCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Prestamo,
            this.Prestamos_cuotas_id,
            this.Numero_cuota,
            this.Fecha_pactada,
            this.Monto,
            this.Saldo,
            this.Abonos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrestamosCuotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPrestamosCuotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgPrestamosCuotas.EnableHeadersVisualStyles = false;
            this.dtgPrestamosCuotas.Location = new System.Drawing.Point(13, 153);
            this.dtgPrestamosCuotas.Margin = new System.Windows.Forms.Padding(13);
            this.dtgPrestamosCuotas.Name = "dtgPrestamosCuotas";
            this.dtgPrestamosCuotas.ReadOnly = true;
            this.dtgPrestamosCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPrestamosCuotas.RowTemplate.ContextMenuStrip = this.menuCuotas;
            this.dtgPrestamosCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamosCuotas.ShowCellToolTips = false;
            this.dtgPrestamosCuotas.ShowEditingIcon = false;
            this.dtgPrestamosCuotas.Size = new System.Drawing.Size(949, 290);
            this.dtgPrestamosCuotas.TabIndex = 46;
            this.dtgPrestamosCuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrestamosCuotas_CellContentClick);
            this.dtgPrestamosCuotas.SelectionChanged += new System.EventHandler(this.dtgPrestamosCuotas_SelectionChanged_1);
            this.dtgPrestamosCuotas.Sorted += new System.EventHandler(this.dtgPrestamosCuotas_Sorted);
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Prestamo
            // 
            this.Prestamo.DataPropertyName = "id_prestamo";
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.ReadOnly = true;
            // 
            // Prestamos_cuotas_id
            // 
            this.Prestamos_cuotas_id.DataPropertyName = "pc_id";
            this.Prestamos_cuotas_id.HeaderText = "Prestamos cuotas";
            this.Prestamos_cuotas_id.Name = "Prestamos_cuotas_id";
            this.Prestamos_cuotas_id.ReadOnly = true;
            this.Prestamos_cuotas_id.Visible = false;
            // 
            // Numero_cuota
            // 
            this.Numero_cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numero_cuota.DataPropertyName = "num_cuota";
            this.Numero_cuota.HeaderText = "Numero cuota";
            this.Numero_cuota.Name = "Numero_cuota";
            this.Numero_cuota.ReadOnly = true;
            this.Numero_cuota.Width = 125;
            // 
            // Fecha_pactada
            // 
            this.Fecha_pactada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha_pactada.DataPropertyName = "fecha_pactada";
            this.Fecha_pactada.HeaderText = "Fecha pactada";
            this.Fecha_pactada.Name = "Fecha_pactada";
            this.Fecha_pactada.ReadOnly = true;
            this.Fecha_pactada.Width = 125;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // Abonos
            // 
            this.Abonos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Abonos.HeaderText = "Abonos";
            this.Abonos.Name = "Abonos";
            this.Abonos.ReadOnly = true;
            this.Abonos.Text = "Abonos";
            this.Abonos.Width = 80;
            // 
            // frmCargarPlanillaProcesada
            // 
            this.AcceptButton = this.btnProcesar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(976, 457);
            this.Controls.Add(this.dtgPrestamosCuotas);
            this.Controls.Add(this.lblTotalCuotasSeleccionadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCuotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarPlanillaProcesada";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Planilla cobro";
            this.Load += new System.EventHandler(this.frmCargarPlanillaProcesada_Load);
            this.Shown += new System.EventHandler(this.frmCargarPlanilla_Shown);
            this.menuCuotas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamosCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblDetalle;
        public System.Windows.Forms.TextBox txtDetalle;
        public System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Drawing.Printing.PrintDocument ImprimirTickets;
        private System.Windows.Forms.ContextMenuStrip menuCuotas;
        private System.Windows.Forms.ToolStripMenuItem imprimirCuotas;
        private System.Windows.Forms.Label lblTotalCuotasSeleccionadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCuotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPrestamosCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamos_cuotas_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_pactada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewButtonColumn Abonos;
    }
}