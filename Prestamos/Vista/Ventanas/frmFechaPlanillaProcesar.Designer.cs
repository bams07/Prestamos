namespace Prestamos.Vista.Ventanas
{
    partial class frmFechaPlanillaProcesar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechaPlanillaProcesar));
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarFechaPlanilla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(49, 53);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(207, 25);
            this.dtFecha.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha procesar planilla";
            // 
            // btnAceptarFechaPlanilla
            // 
            this.btnAceptarFechaPlanilla.Location = new System.Drawing.Point(181, 84);
            this.btnAceptarFechaPlanilla.Name = "btnAceptarFechaPlanilla";
            this.btnAceptarFechaPlanilla.Size = new System.Drawing.Size(75, 33);
            this.btnAceptarFechaPlanilla.TabIndex = 23;
            this.btnAceptarFechaPlanilla.Text = "Aceptar";
            this.btnAceptarFechaPlanilla.UseVisualStyleBackColor = true;
            this.btnAceptarFechaPlanilla.Click += new System.EventHandler(this.btnAceptarFechaPlanilla_Click);
            // 
            // frmFechaPlanillaProcesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(287, 129);
            this.Controls.Add(this.btnAceptarFechaPlanilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFechaPlanillaProcesar";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procesar planilla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFechaPlanillaProcesar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarFechaPlanilla;


    }
}