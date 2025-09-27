namespace Escuela
{
    partial class frmAlumnosListado
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgbAlumnos = new System.Windows.Forms.DataGridView();
            this.colMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alfabetico\t",
            "Año de ingreso",
            "Matricula"});
            this.comboBox1.Location = new System.Drawing.Point(114, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // dgbAlumnos
            // 
            this.dgbAlumnos.AllowUserToOrderColumns = true;
            this.dgbAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMat,
            this.colApe,
            this.colNom,
            this.colAno});
            this.dgbAlumnos.Location = new System.Drawing.Point(16, 112);
            this.dgbAlumnos.Name = "dgbAlumnos";
            this.dgbAlumnos.RowHeadersWidth = 51;
            this.dgbAlumnos.RowTemplate.Height = 24;
            this.dgbAlumnos.Size = new System.Drawing.Size(551, 49);
            this.dgbAlumnos.TabIndex = 2;
            this.dgbAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbAlumnos_CellContentClick);
            // 
            // colMat
            // 
            this.colMat.HeaderText = "Matricula";
            this.colMat.MinimumWidth = 6;
            this.colMat.Name = "colMat";
            this.colMat.Width = 125;
            // 
            // colApe
            // 
            this.colApe.HeaderText = "Apellido";
            this.colApe.MinimumWidth = 6;
            this.colApe.Name = "colApe";
            this.colApe.Width = 125;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nombre";
            this.colNom.MinimumWidth = 6;
            this.colNom.Name = "colNom";
            this.colNom.Width = 125;
            // 
            // colAno
            // 
            this.colAno.HeaderText = "Año de Ingreso";
            this.colAno.MinimumWidth = 6;
            this.colAno.Name = "colAno";
            this.colAno.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(713, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmAlumnosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgbAlumnos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAlumnosListado";
            this.Text = "Listado de Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgbAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgbAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.Button btnCerrar;
    }
}