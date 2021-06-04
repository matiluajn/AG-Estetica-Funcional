namespace AGEsteticaFuncinal
{
    partial class frmClienteModificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClienteMod = new System.Windows.Forms.DataGridView();
            this.dtpFechaDeNacCmodif = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefonoCmodif = new System.Windows.Forms.TextBox();
            this.txtCelularCmodif = new System.Windows.Forms.TextBox();
            this.txtApellidoCmodif = new System.Windows.Forms.TextBox();
            this.txtNombreCmodif = new System.Windows.Forms.TextBox();
            this.txtdniCmodif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailmodif = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLesionCmodif = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMedicacionCmodif = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaAltaCmodif = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.btnCerrarAltProv = new System.Windows.Forms.Button();
            this.btnModifC = new System.Windows.Forms.Button();
            this.txtDiagnosticoCmodif = new System.Windows.Forms.TextBox();
            this.txtDerivacionMedicaCmodif = new System.Windows.Forms.TextBox();
            this.txtCpCmodif = new System.Windows.Forms.TextBox();
            this.txtBarrioCmodif = new System.Windows.Forms.TextBox();
            this.txtNumeroCmodif = new System.Windows.Forms.TextBox();
            this.txtCalleCmodif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteMod)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::AGEsteticaFuncinal.Properties.Resources.estetica_login;
            this.groupBox1.Controls.Add(this.dgvClienteMod);
            this.groupBox1.Controls.Add(this.dtpFechaDeNacCmodif);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTelefonoCmodif);
            this.groupBox1.Controls.Add(this.txtCelularCmodif);
            this.groupBox1.Controls.Add(this.txtApellidoCmodif);
            this.groupBox1.Controls.Add(this.txtNombreCmodif);
            this.groupBox1.Controls.Add(this.txtdniCmodif);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmailmodif);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtLesionCmodif);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMedicacionCmodif);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpFechaAltaCmodif);
            this.groupBox1.Controls.Add(this.lblFechaAlta);
            this.groupBox1.Controls.Add(this.btnCerrarAltProv);
            this.groupBox1.Controls.Add(this.btnModifC);
            this.groupBox1.Controls.Add(this.txtDiagnosticoCmodif);
            this.groupBox1.Controls.Add(this.txtDerivacionMedicaCmodif);
            this.groupBox1.Controls.Add(this.txtCpCmodif);
            this.groupBox1.Controls.Add(this.txtBarrioCmodif);
            this.groupBox1.Controls.Add(this.txtNumeroCmodif);
            this.groupBox1.Controls.Add(this.txtCalleCmodif);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 671);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realice Modificación";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvClienteMod
            // 
            this.dgvClienteMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteMod.Location = new System.Drawing.Point(12, 19);
            this.dgvClienteMod.Name = "dgvClienteMod";
            this.dgvClienteMod.Size = new System.Drawing.Size(624, 150);
            this.dgvClienteMod.TabIndex = 95;
            this.dgvClienteMod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteMod_CellContentClick_1);
            // 
            // dtpFechaDeNacCmodif
            // 
            this.dtpFechaDeNacCmodif.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacCmodif.Location = new System.Drawing.Point(165, 274);
            this.dtpFechaDeNacCmodif.Name = "dtpFechaDeNacCmodif";
            this.dtpFechaDeNacCmodif.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDeNacCmodif.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 93;
            this.label14.Text = "Fecha De Nac";
            this.label14.UseCompatibleTextRendering = true;
            // 
            // txtTelefonoCmodif
            // 
            this.txtTelefonoCmodif.Location = new System.Drawing.Point(165, 332);
            this.txtTelefonoCmodif.Name = "txtTelefonoCmodif";
            this.txtTelefonoCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoCmodif.TabIndex = 92;
            // 
            // txtCelularCmodif
            // 
            this.txtCelularCmodif.Location = new System.Drawing.Point(165, 302);
            this.txtCelularCmodif.Name = "txtCelularCmodif";
            this.txtCelularCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtCelularCmodif.TabIndex = 91;
            // 
            // txtApellidoCmodif
            // 
            this.txtApellidoCmodif.Location = new System.Drawing.Point(165, 244);
            this.txtApellidoCmodif.Name = "txtApellidoCmodif";
            this.txtApellidoCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCmodif.TabIndex = 90;
            // 
            // txtNombreCmodif
            // 
            this.txtNombreCmodif.Location = new System.Drawing.Point(165, 218);
            this.txtNombreCmodif.Name = "txtNombreCmodif";
            this.txtNombreCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCmodif.TabIndex = 89;
            // 
            // txtdniCmodif
            // 
            this.txtdniCmodif.Location = new System.Drawing.Point(165, 190);
            this.txtdniCmodif.Name = "txtdniCmodif";
            this.txtdniCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtdniCmodif.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "DNI";
            // 
            // txtEmailmodif
            // 
            this.txtEmailmodif.Location = new System.Drawing.Point(165, 484);
            this.txtEmailmodif.Name = "txtEmailmodif";
            this.txtEmailmodif.Size = new System.Drawing.Size(100, 20);
            this.txtEmailmodif.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 491);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "Email";
            // 
            // txtLesionCmodif
            // 
            this.txtLesionCmodif.Location = new System.Drawing.Point(165, 601);
            this.txtLesionCmodif.Name = "txtLesionCmodif";
            this.txtLesionCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtLesionCmodif.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 608);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Lesion";
            // 
            // txtMedicacionCmodif
            // 
            this.txtMedicacionCmodif.Location = new System.Drawing.Point(165, 573);
            this.txtMedicacionCmodif.Name = "txtMedicacionCmodif";
            this.txtMedicacionCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtMedicacionCmodif.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Medicacion";
            // 
            // dtpFechaAltaCmodif
            // 
            this.dtpFechaAltaCmodif.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAltaCmodif.Location = new System.Drawing.Point(165, 632);
            this.dtpFechaAltaCmodif.Name = "dtpFechaAltaCmodif";
            this.dtpFechaAltaCmodif.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaAltaCmodif.TabIndex = 76;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(52, 635);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(55, 17);
            this.lblFechaAlta.TabIndex = 75;
            this.lblFechaAlta.Text = "FechaAlta";
            this.lblFechaAlta.UseCompatibleTextRendering = true;
            // 
            // btnCerrarAltProv
            // 
            this.btnCerrarAltProv.Location = new System.Drawing.Point(509, 608);
            this.btnCerrarAltProv.Name = "btnCerrarAltProv";
            this.btnCerrarAltProv.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarAltProv.TabIndex = 74;
            this.btnCerrarAltProv.Text = "Cerrar";
            this.btnCerrarAltProv.UseVisualStyleBackColor = true;
            this.btnCerrarAltProv.Click += new System.EventHandler(this.btnCerrarAltProv_Click);
            // 
            // btnModifC
            // 
            this.btnModifC.Location = new System.Drawing.Point(509, 535);
            this.btnModifC.Name = "btnModifC";
            this.btnModifC.Size = new System.Drawing.Size(75, 23);
            this.btnModifC.TabIndex = 73;
            this.btnModifC.Text = "Modificar";
            this.btnModifC.UseVisualStyleBackColor = true;
            this.btnModifC.Click += new System.EventHandler(this.btnModifC_Click);
            // 
            // txtDiagnosticoCmodif
            // 
            this.txtDiagnosticoCmodif.Location = new System.Drawing.Point(165, 538);
            this.txtDiagnosticoCmodif.Name = "txtDiagnosticoCmodif";
            this.txtDiagnosticoCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtDiagnosticoCmodif.TabIndex = 72;
            // 
            // txtDerivacionMedicaCmodif
            // 
            this.txtDerivacionMedicaCmodif.Location = new System.Drawing.Point(165, 510);
            this.txtDerivacionMedicaCmodif.Name = "txtDerivacionMedicaCmodif";
            this.txtDerivacionMedicaCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtDerivacionMedicaCmodif.TabIndex = 71;
            // 
            // txtCpCmodif
            // 
            this.txtCpCmodif.Location = new System.Drawing.Point(165, 452);
            this.txtCpCmodif.Name = "txtCpCmodif";
            this.txtCpCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtCpCmodif.TabIndex = 70;
            // 
            // txtBarrioCmodif
            // 
            this.txtBarrioCmodif.Location = new System.Drawing.Point(165, 423);
            this.txtBarrioCmodif.Name = "txtBarrioCmodif";
            this.txtBarrioCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtBarrioCmodif.TabIndex = 69;
            // 
            // txtNumeroCmodif
            // 
            this.txtNumeroCmodif.Location = new System.Drawing.Point(165, 396);
            this.txtNumeroCmodif.Name = "txtNumeroCmodif";
            this.txtNumeroCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCmodif.TabIndex = 68;
            // 
            // txtCalleCmodif
            // 
            this.txtCalleCmodif.Location = new System.Drawing.Point(165, 362);
            this.txtCalleCmodif.Name = "txtCalleCmodif";
            this.txtCalleCmodif.Size = new System.Drawing.Size(100, 20);
            this.txtCalleCmodif.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Diagnostico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Derivacion Medica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "CP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Barrio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Calle";
            // 
            // frmClienteModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 671);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClienteModificar";
            this.Text = "frmClienteModificar";
            this.Load += new System.EventHandler(this.frmClienteModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailmodif;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCpCmodif;
        private System.Windows.Forms.TextBox txtBarrioCmodif;
        private System.Windows.Forms.TextBox txtNumeroCmodif;
        private System.Windows.Forms.TextBox txtCalleCmodif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacCmodif;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoCmodif;
        private System.Windows.Forms.TextBox txtCelularCmodif;
        private System.Windows.Forms.TextBox txtApellidoCmodif;
        private System.Windows.Forms.TextBox txtNombreCmodif;
        private System.Windows.Forms.TextBox txtdniCmodif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClienteMod;
        private System.Windows.Forms.TextBox txtLesionCmodif;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMedicacionCmodif;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaAltaCmodif;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Button btnCerrarAltProv;
        private System.Windows.Forms.Button btnModifC;
        private System.Windows.Forms.TextBox txtDiagnosticoCmodif;
        private System.Windows.Forms.TextBox txtDerivacionMedicaCmodif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}