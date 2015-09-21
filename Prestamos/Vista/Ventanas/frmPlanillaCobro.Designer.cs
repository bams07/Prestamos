namespace Prestamos.Vista.Ventanas
{
    partial class frmPlanillaCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanillaCobro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgPlanilla = new System.Windows.Forms.DataGridView();
            this.Planilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procesada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MenuPlanilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCargarPlanillas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPlanilla)).BeginInit();
            this.MenuPlanilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(82, 49);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(207, 25);
            this.dtFecha.TabIndex = 22;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(295, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 38);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgPlanilla
            // 
            this.dtgPlanilla.AllowUserToAddRows = false;
            this.dtgPlanilla.AllowUserToDeleteRows = false;
            this.dtgPlanilla.AllowUserToResizeColumns = false;
            this.dtgPlanilla.AllowUserToResizeRows = false;
            this.dtgPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgPlanilla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPlanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Planilla,
            this.Fecha,
            this.Detalle,
            this.Procesada,
            this.Cuotas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPlanilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPlanilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgPlanilla.EnableHeadersVisualStyles = false;
            this.dtgPlanilla.Location = new System.Drawing.Point(9, 101);
            this.dtgPlanilla.Name = "dtgPlanilla";
            this.dtgPlanilla.ReadOnly = true;
            this.dtgPlanilla.RowTemplate.ContextMenuStrip = this.MenuPlanilla;
            this.dtgPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPlanilla.ShowEditingIcon = false;
            this.dtgPlanilla.ShowRowErrors = false;
            this.dtgPlanilla.Size = new System.Drawing.Size(640, 171);
            this.dtgPlanilla.TabIndex = 30;
            this.dtgPlanilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPlanilla_CellContentClick);
            this.dtgPlanilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPlanilla_CellDoubleClick);
            // 
            // Planilla
            // 
            this.Planilla.DataPropertyName = "id_planilla";
            this.Planilla.HeaderText = "Documento";
            this.Planilla.Name = "Planilla";
            this.Planilla.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.DataPropertyName = "fecha_planilla";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalle.DataPropertyName = "detalle_planilla";
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 200;
            // 
            // Procesada
            // 
            this.Procesada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Procesada.DataPropertyName = "procesada_planilla";
            this.Procesada.HeaderText = "Procesada";
            this.Procesada.Name = "Procesada";
            this.Procesada.ReadOnly = true;
            this.Procesada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Procesada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Procesada.Width = 80;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuotas.DataPropertyName = "cantidad";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Text = "Cuotas";
            // 
            // MenuPlanilla
            // 
            this.MenuPlanilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarPlanillaToolStripMenuItem});
            this.MenuPlanilla.Name = "MenuPlanilla";
            this.MenuPlanilla.Size = new System.Drawing.Size(206, 26);
            // 
            // eliminarPlanillaToolStripMenuItem
            // 
            this.eliminarPlanillaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.eliminarPlanillaToolStripMenuItem.Name = "eliminarPlanillaToolStripMenuItem";
            this.eliminarPlanillaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarPlanillaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eliminarPlanillaToolStripMenuItem.Text = "Eliminar planilla";
            this.eliminarPlanillaToolStripMenuItem.Click += new System.EventHandler(this.eliminarPlanillaToolStripMenuItem_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(462, 44);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 38);
            this.btnCrear.TabIndex = 31;
            this.btnCrear.Text = "Crear planilla";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCargarPlanillas
            // 
            this.btnCargarPlanillas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPlanillas.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarPlanillas.Image")));
            this.btnCargarPlanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarPlanillas.Location = new System.Drawing.Point(378, 44);
            this.btnCargarPlanillas.Name = "btnCargarPlanillas";
            this.btnCargarPlanillas.Size = new System.Drawing.Size(78, 38);
            this.btnCargarPlanillas.TabIndex = 32;
            this.btnCargarPlanillas.Text = "Todas";
            this.btnCargarPlanillas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarPlanillas.UseVisualStyleBackColor = true;
            this.btnCargarPlanillas.Click += new System.EventHandler(this.btnCargarPlanillas_Click);
            // 
            // frmPlanillaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(658, 337);
            this.Controls.Add(this.btnCargarPlanillas);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtgPlanilla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanillaCobro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla cobro";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPlanilla)).EndInit();
            this.MenuPlanilla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgPlanilla;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCargarPlanillas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Procesada;
        private System.Windows.Forms.DataGridViewButtonColumn Cuotas;
        private System.Windows.Forms.ContextMenuStrip MenuPlanilla;
        private System.Windows.Forms.ToolStripMenuItem eliminarPlanillaToolStripMenuItem;
    }
}