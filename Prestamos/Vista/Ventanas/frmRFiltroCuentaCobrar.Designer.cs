namespace Prestamos.Vista.Ventanas
{
    partial class frmRFiltroCuentaCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRFiltroCuentaCobrar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.MenuPrestamos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selecionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckTodosPrestamos = new System.Windows.Forms.CheckBox();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DiaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.MenuPrestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(72, 34);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(178, 25);
            this.txtCliente.TabIndex = 19;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // btnClientes
            // 
            this.btnClientes.Enabled = false;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(256, 34);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(48, 25);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Enabled = false;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(22, 38);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(50, 17);
            this.lblClientes.TabIndex = 17;
            this.lblClientes.Text = "Cliente:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(28, 351);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(116, 56);
            this.btnProcesar.TabIndex = 20;
            this.btnProcesar.Tag = "1";
            this.btnProcesar.Text = "Prosesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPrestamos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 182);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamos";
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.AllowUserToResizeColumns = false;
            this.dtgPrestamos.AllowUserToResizeRows = false;
            this.dtgPrestamos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.monto,
            this.fechaPrestamo,
            this.cliente,
            this.Interes,
            this.Cuotas,
            this.saldoPrestamo,
            this.Total,
            this.Recargo,
            this.DiaPago,
            this.Eliminado});
            this.dtgPrestamos.ContextMenuStrip = this.MenuPrestamos;
            this.dtgPrestamos.Enabled = false;
            this.dtgPrestamos.EnableHeadersVisualStyles = false;
            this.dtgPrestamos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgPrestamos.Location = new System.Drawing.Point(17, 32);
            this.dtgPrestamos.MultiSelect = false;
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamos.ShowCellErrors = false;
            this.dtgPrestamos.ShowCellToolTips = false;
            this.dtgPrestamos.ShowEditingIcon = false;
            this.dtgPrestamos.ShowRowErrors = false;
            this.dtgPrestamos.Size = new System.Drawing.Size(674, 135);
            this.dtgPrestamos.TabIndex = 18;
            this.dtgPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrestamos_CellClick);
            // 
            // MenuPrestamos
            // 
            this.MenuPrestamos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrestamos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecionarTodoToolStripMenuItem});
            this.MenuPrestamos.Name = "MenuPrestamos";
            this.MenuPrestamos.Size = new System.Drawing.Size(214, 26);
            // 
            // selecionarTodoToolStripMenuItem
            // 
            this.selecionarTodoToolStripMenuItem.Name = "selecionarTodoToolStripMenuItem";
            this.selecionarTodoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.selecionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.selecionarTodoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.selecionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            this.selecionarTodoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTodoToolStripMenuItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(150, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 56);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckTodosPrestamos
            // 
            this.ckTodosPrestamos.AutoSize = true;
            this.ckTodosPrestamos.Checked = true;
            this.ckTodosPrestamos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTodosPrestamos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTodosPrestamos.Location = new System.Drawing.Point(310, 37);
            this.ckTodosPrestamos.Name = "ckTodosPrestamos";
            this.ckTodosPrestamos.Size = new System.Drawing.Size(151, 21);
            this.ckTodosPrestamos.TabIndex = 30;
            this.ckTodosPrestamos.Text = "Todos los prestamos";
            this.ckTodosPrestamos.UseVisualStyleBackColor = true;
            this.ckTodosPrestamos.CheckedChanged += new System.EventHandler(this.ckTodosPrestamos_CheckedChanged);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(72, 96);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(178, 25);
            this.dtFechaHasta.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta:";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(72, 65);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(178, 25);
            this.dtFechaDesde.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Desde:";
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numero.DataPropertyName = "id";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 75;
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
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Visible = false;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Visible = false;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuotas.DataPropertyName = "cuotas";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Width = 80;
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
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            // 
            // DiaPago
            // 
            this.DiaPago.DataPropertyName = "dia_pago";
            this.DiaPago.HeaderText = "Dia pago";
            this.DiaPago.Name = "DiaPago";
            this.DiaPago.ReadOnly = true;
            this.DiaPago.Visible = false;
            // 
            // Eliminado
            // 
            this.Eliminado.DataPropertyName = "eliminado";
            this.Eliminado.HeaderText = "Eliminado";
            this.Eliminado.Name = "Eliminado";
            this.Eliminado.ReadOnly = true;
            this.Eliminado.Visible = false;
            // 
            // frmRFiltroCuentaCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(752, 457);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckTodosPrestamos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRFiltroCuentaCobrar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.MenuPrestamos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dtgPrestamos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip MenuPrestamos;
        private System.Windows.Forms.ToolStripMenuItem selecionarTodoToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckTodosPrestamos;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminado;
    }
}