namespace AGEsteticaFuncinal
{
    partial class frmServicios
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminarSeerv = new System.Windows.Forms.Button();
            this.btnModifServ = new System.Windows.Forms.Button();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::AGEsteticaFuncinal.Properties.Resources.estetica_login;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.btnEliminarSeerv);
            this.groupBox1.Controls.Add(this.btnModifServ);
            this.groupBox1.Controls.Add(this.dgvServicios);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(135, 249);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminarSeerv
            // 
            this.btnEliminarSeerv.Location = new System.Drawing.Point(451, 249);
            this.btnEliminarSeerv.Name = "btnEliminarSeerv";
            this.btnEliminarSeerv.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSeerv.TabIndex = 2;
            this.btnEliminarSeerv.Text = "Eliminar";
            this.btnEliminarSeerv.UseVisualStyleBackColor = true;
            this.btnEliminarSeerv.Click += new System.EventHandler(this.btnEliminarSeerv_Click);
            // 
            // btnModifServ
            // 
            this.btnModifServ.Location = new System.Drawing.Point(295, 249);
            this.btnModifServ.Name = "btnModifServ";
            this.btnModifServ.Size = new System.Drawing.Size(75, 23);
            this.btnModifServ.TabIndex = 1;
            this.btnModifServ.Text = "Modificar";
            this.btnModifServ.UseVisualStyleBackColor = true;
            this.btnModifServ.Click += new System.EventHandler(this.btnModifServ_Click);
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(12, 19);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(622, 150);
            this.dgvServicios.TabIndex = 0;
            this.dgvServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 324);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmServicios";
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifServ;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminarSeerv;
        private System.Windows.Forms.Button button1;
    }
}