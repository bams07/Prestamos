namespace Prestamos.Vista.Ventanas
{
    partial class frmRespaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRespaldo));
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDireccionPostgre = new System.Windows.Forms.Button();
            this.txtDireccionPostgre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClienSecret = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClienSecret = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ckGDrive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRespaldar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldar.Image = ((System.Drawing.Image)(resources.GetObject("btnRespaldar.Image")));
            this.btnRespaldar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldar.Location = new System.Drawing.Point(13, 77);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(111, 47);
            this.btnRespaldar.TabIndex = 1;
            this.btnRespaldar.TabStop = false;
            this.btnRespaldar.Text = "Respaldar";
            this.btnRespaldar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldar.UseVisualStyleBackColor = true;
            this.btnRespaldar.Click += new System.EventHandler(this.btnRespaldar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 77);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(269, 47);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 460);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRespaldar);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Respaldo";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.ckGDrive);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnDireccionPostgre);
            this.tabPage2.Controls.Add(this.txtDireccionPostgre);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración";
            // 
            // btnDireccionPostgre
            // 
            this.btnDireccionPostgre.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDireccionPostgre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireccionPostgre.Image = ((System.Drawing.Image)(resources.GetObject("btnDireccionPostgre.Image")));
            this.btnDireccionPostgre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDireccionPostgre.Location = new System.Drawing.Point(16, 43);
            this.btnDireccionPostgre.Name = "btnDireccionPostgre";
            this.btnDireccionPostgre.Size = new System.Drawing.Size(111, 47);
            this.btnDireccionPostgre.TabIndex = 3;
            this.btnDireccionPostgre.TabStop = false;
            this.btnDireccionPostgre.Text = "Direccion";
            this.btnDireccionPostgre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDireccionPostgre.UseVisualStyleBackColor = true;
            this.btnDireccionPostgre.Click += new System.EventHandler(this.btnDireccionPostgre_Click);
            // 
            // txtDireccionPostgre
            // 
            this.txtDireccionPostgre.Location = new System.Drawing.Point(133, 43);
            this.txtDireccionPostgre.Multiline = true;
            this.txtDireccionPostgre.Name = "txtDireccionPostgre";
            this.txtDireccionPostgre.ReadOnly = true;
            this.txtDireccionPostgre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccionPostgre.Size = new System.Drawing.Size(269, 47);
            this.txtDireccionPostgre.TabIndex = 4;
            this.txtDireccionPostgre.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Postgres SQL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.lblClienSecret);
            this.groupBox2.Controls.Add(this.lblClientID);
            this.groupBox2.Controls.Add(this.txtClienSecret);
            this.groupBox2.Controls.Add(this.txtClienteID);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(28, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Google drive";
            // 
            // lblClienSecret
            // 
            this.lblClienSecret.AutoSize = true;
            this.lblClienSecret.ForeColor = System.Drawing.Color.Black;
            this.lblClienSecret.Location = new System.Drawing.Point(32, 81);
            this.lblClienSecret.Name = "lblClienSecret";
            this.lblClienSecret.Size = new System.Drawing.Size(82, 17);
            this.lblClienSecret.TabIndex = 3;
            this.lblClienSecret.Text = "Client secret";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.ForeColor = System.Drawing.Color.Black;
            this.lblClientID.Location = new System.Drawing.Point(32, 41);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(59, 17);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "Client ID";
            // 
            // txtClienSecret
            // 
            this.txtClienSecret.Enabled = false;
            this.txtClienSecret.Location = new System.Drawing.Point(117, 78);
            this.txtClienSecret.Name = "txtClienSecret";
            this.txtClienSecret.Size = new System.Drawing.Size(223, 25);
            this.txtClienSecret.TabIndex = 1;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Enabled = false;
            this.txtClienteID.Location = new System.Drawing.Point(117, 38);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(223, 25);
            this.txtClienteID.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(220, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 56);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(88, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 56);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Tag = "1";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ckGDrive
            // 
            this.ckGDrive.AutoSize = true;
            this.ckGDrive.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGDrive.ForeColor = System.Drawing.Color.Black;
            this.ckGDrive.Location = new System.Drawing.Point(164, 181);
            this.ckGDrive.Name = "ckGDrive";
            this.ckGDrive.Size = new System.Drawing.Size(104, 21);
            this.ckGDrive.TabIndex = 7;
            this.ckGDrive.Text = "Google drive";
            this.ckGDrive.UseVisualStyleBackColor = false;
            this.ckGDrive.CheckStateChanged += new System.EventHandler(this.ckGDrive_CheckStateChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Respaldo de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "* Direccion donde se encuentra el bin";
            // 
            // frmRespaldo
            // 
            this.AcceptButton = this.btnRespaldar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(425, 460);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRespaldo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Respaldo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDireccionPostgre;
        private System.Windows.Forms.TextBox txtDireccionPostgre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblClienSecret;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClienSecret;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox ckGDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}