namespace WindowsFormsApplication1
{
    partial class FrmMenuPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padreDeFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.becasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicadoresDePobrezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteInternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioBecaTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesInternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteDeEstudianteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.becasDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(488, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.padreDeFamiliaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.becasToolStripMenuItem,
            this.indicadoresDePobrezaToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // padreDeFamiliaToolStripMenuItem
            // 
            this.padreDeFamiliaToolStripMenuItem.Name = "padreDeFamiliaToolStripMenuItem";
            this.padreDeFamiliaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.padreDeFamiliaToolStripMenuItem.Text = "Padre de Familia";
            this.padreDeFamiliaToolStripMenuItem.Click += new System.EventHandler(this.padreDeFamiliaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // becasToolStripMenuItem
            // 
            this.becasToolStripMenuItem.Name = "becasToolStripMenuItem";
            this.becasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.becasToolStripMenuItem.Text = "Becas";
            // 
            // indicadoresDePobrezaToolStripMenuItem
            // 
            this.indicadoresDePobrezaToolStripMenuItem.Name = "indicadoresDePobrezaToolStripMenuItem";
            this.indicadoresDePobrezaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.indicadoresDePobrezaToolStripMenuItem.Text = "Indicadores de Pobreza";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteInternoToolStripMenuItem,
            this.formularioBecaTransporteToolStripMenuItem,
            this.expedienteDeEstudianteToolStripMenuItem,
            this.resumenDeIngresosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reporteInternoToolStripMenuItem
            // 
            this.reporteInternoToolStripMenuItem.Name = "reporteInternoToolStripMenuItem";
            this.reporteInternoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reporteInternoToolStripMenuItem.Text = "Reporte Interno";
            this.reporteInternoToolStripMenuItem.Click += new System.EventHandler(this.reporteInternoToolStripMenuItem_Click);
            // 
            // formularioBecaTransporteToolStripMenuItem
            // 
            this.formularioBecaTransporteToolStripMenuItem.Name = "formularioBecaTransporteToolStripMenuItem";
            this.formularioBecaTransporteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.formularioBecaTransporteToolStripMenuItem.Text = "Formulario Beca Transporte";
            // 
            // expedienteDeEstudianteToolStripMenuItem
            // 
            this.expedienteDeEstudianteToolStripMenuItem.Name = "expedienteDeEstudianteToolStripMenuItem";
            this.expedienteDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.expedienteDeEstudianteToolStripMenuItem.Text = "Expediente de Estudiante";
            // 
            // resumenDeIngresosToolStripMenuItem
            // 
            this.resumenDeIngresosToolStripMenuItem.Name = "resumenDeIngresosToolStripMenuItem";
            this.resumenDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.resumenDeIngresosToolStripMenuItem.Text = "Resumen de Ingresos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesInternosToolStripMenuItem,
            this.expedienteDeEstudianteToolStripMenuItem1,
            this.becasDeTransporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesInternosToolStripMenuItem
            // 
            this.reportesInternosToolStripMenuItem.Name = "reportesInternosToolStripMenuItem";
            this.reportesInternosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.reportesInternosToolStripMenuItem.Text = "Reportes Internos";
            // 
            // expedienteDeEstudianteToolStripMenuItem1
            // 
            this.expedienteDeEstudianteToolStripMenuItem1.Name = "expedienteDeEstudianteToolStripMenuItem1";
            this.expedienteDeEstudianteToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.expedienteDeEstudianteToolStripMenuItem1.Text = "Expediente de Estudiante";
            // 
            // becasDeTransporteToolStripMenuItem
            // 
            this.becasDeTransporteToolStripMenuItem.Name = "becasDeTransporteToolStripMenuItem";
            this.becasDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.becasDeTransporteToolStripMenuItem.Text = "Becas de Transporte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Sin_título;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 261);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteInternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioBecaTransporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteDeEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padreDeFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesInternosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem becasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicadoresDePobrezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteDeEstudianteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem becasDeTransporteToolStripMenuItem;
    }
}