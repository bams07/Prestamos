namespace Prestamos.Vista.Ventanas
{
    partial class frmCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.cedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotasMontoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interesPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calendario.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.calendario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calendario.Location = new System.Drawing.Point(9, 9);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            this.calendario.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.AllowUserToResizeColumns = false;
            this.dtgPrestamos.AllowUserToResizeRows = false;
            this.dtgPrestamos.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.cedulaCliente,
            this.nombreCliente,
            this.idPrestamo,
            this.saldoPrestamo,
            this.totalPrestamo,
            this.fechaInicialPrestamo,
            this.fechaFinalPrestamo,
            this.montoPrestamo,
            this.cuotasMontoPrestamo,
            this.interesPrestamo});
            this.dtgPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPrestamos.EnableHeadersVisualStyles = false;
            this.dtgPrestamos.Location = new System.Drawing.Point(217, 3);
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamos.Size = new System.Drawing.Size(796, 458);
            this.dtgPrestamos.TabIndex = 1;
            this.dtgPrestamos.Sorted += new System.EventHandler(this.dtgPrestamos_Sorted);
            // 
            // cedulaCliente
            // 
            this.cedulaCliente.DataPropertyName = "cedula";
            this.cedulaCliente.HeaderText = "Cedula ";
            this.cedulaCliente.Name = "cedulaCliente";
            this.cedulaCliente.ReadOnly = true;
            this.cedulaCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombreCliente
            // 
            this.nombreCliente.DataPropertyName = "nombre";
            this.nombreCliente.HeaderText = "Nombre";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // idPrestamo
            // 
            this.idPrestamo.DataPropertyName = "id";
            this.idPrestamo.HeaderText = "Prestamo";
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.ReadOnly = true;
            // 
            // saldoPrestamo
            // 
            this.saldoPrestamo.DataPropertyName = "saldo";
            this.saldoPrestamo.HeaderText = "Saldo";
            this.saldoPrestamo.Name = "saldoPrestamo";
            this.saldoPrestamo.ReadOnly = true;
            this.saldoPrestamo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalPrestamo
            // 
            this.totalPrestamo.DataPropertyName = "total";
            this.totalPrestamo.HeaderText = "Total";
            this.totalPrestamo.Name = "totalPrestamo";
            this.totalPrestamo.ReadOnly = true;
            this.totalPrestamo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaInicialPrestamo
            // 
            this.fechaInicialPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaInicialPrestamo.DataPropertyName = "fecha";
            this.fechaInicialPrestamo.HeaderText = "Fecha inicial";
            this.fechaInicialPrestamo.Name = "fechaInicialPrestamo";
            this.fechaInicialPrestamo.ReadOnly = true;
            this.fechaInicialPrestamo.Width = 120;
            // 
            // fechaFinalPrestamo
            // 
            this.fechaFinalPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaFinalPrestamo.HeaderText = "Fecha final";
            this.fechaFinalPrestamo.Name = "fechaFinalPrestamo";
            this.fechaFinalPrestamo.ReadOnly = true;
            this.fechaFinalPrestamo.Width = 120;
            // 
            // montoPrestamo
            // 
            this.montoPrestamo.DataPropertyName = "monto";
            this.montoPrestamo.HeaderText = "Monto";
            this.montoPrestamo.Name = "montoPrestamo";
            this.montoPrestamo.ReadOnly = true;
            this.montoPrestamo.Visible = false;
            // 
            // cuotasMontoPrestamo
            // 
            this.cuotasMontoPrestamo.DataPropertyName = "cuotas";
            this.cuotasMontoPrestamo.HeaderText = "Cuotas";
            this.cuotasMontoPrestamo.Name = "cuotasMontoPrestamo";
            this.cuotasMontoPrestamo.ReadOnly = true;
            this.cuotasMontoPrestamo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cuotasMontoPrestamo.Visible = false;
            // 
            // interesPrestamo
            // 
            this.interesPrestamo.DataPropertyName = "interes";
            this.interesPrestamo.HeaderText = "Interes";
            this.interesPrestamo.Name = "interesPrestamo";
            this.interesPrestamo.ReadOnly = true;
            this.interesPrestamo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.interesPrestamo.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.83858F));
            this.tableLayoutPanel1.Controls.Add(this.dtgPrestamos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.calendario, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 464);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalendario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.frmCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.DataGridView dtgPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotasMontoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn interesPrestamo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}