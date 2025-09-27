namespace Escuela
{
    partial class frmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeExámenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeAlumnosToolStripMenuItem,
            this.listadoDeAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // gestiónDeAlumnosToolStripMenuItem
            // 
            this.gestiónDeAlumnosToolStripMenuItem.Name = "gestiónDeAlumnosToolStripMenuItem";
            this.gestiónDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.gestiónDeAlumnosToolStripMenuItem.Text = "Gestión de Alumnos";
            this.gestiónDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeAlumnosToolStripMenuItem_Click);
            // 
            // listadoDeAlumnosToolStripMenuItem
            // 
            this.listadoDeAlumnosToolStripMenuItem.Name = "listadoDeAlumnosToolStripMenuItem";
            this.listadoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.listadoDeAlumnosToolStripMenuItem.Text = "Listado de Alumnos";
            this.listadoDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlumnosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeNotasToolStripMenuItem,
            this.notasDeAlumnosToolStripMenuItem,
            this.listadoDeNotasToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // gestiónDeNotasToolStripMenuItem
            // 
            this.gestiónDeNotasToolStripMenuItem.Name = "gestiónDeNotasToolStripMenuItem";
            this.gestiónDeNotasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestiónDeNotasToolStripMenuItem.Text = "Gestión de Notas";
            this.gestiónDeNotasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeNotasToolStripMenuItem_Click);
            // 
            // notasDeAlumnosToolStripMenuItem
            // 
            this.notasDeAlumnosToolStripMenuItem.Name = "notasDeAlumnosToolStripMenuItem";
            this.notasDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notasDeAlumnosToolStripMenuItem.Text = "Notas de Alumnos";
            this.notasDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.notasDeAlumnosToolStripMenuItem_Click);
            // 
            // listadoDeNotasToolStripMenuItem
            // 
            this.listadoDeNotasToolStripMenuItem.Name = "listadoDeNotasToolStripMenuItem";
            this.listadoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoDeNotasToolStripMenuItem.Text = "Listado de Notas";
            this.listadoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaturasToolStripMenuItem,
            this.ciudadesToolStripMenuItem,
            this.tiposDeExámenToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem.Click += new System.EventHandler(this.asignaturasToolStripMenuItem_Click);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // tiposDeExámenToolStripMenuItem
            // 
            this.tiposDeExámenToolStripMenuItem.Name = "tiposDeExámenToolStripMenuItem";
            this.tiposDeExámenToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.tiposDeExámenToolStripMenuItem.Text = "Tipos de Exámen";
            this.tiposDeExámenToolStripMenuItem.Click += new System.EventHandler(this.tiposDeExámenToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de alumnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeExámenToolStripMenuItem;
    }
}