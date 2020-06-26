namespace CitasProgra20202.Formularios
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.citasPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasCanceladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMantenimientos,
            this.MnuProcesos,
            this.MnuReportes,
            this.aCERCADEToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMantenimientos
            // 
            this.MnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestionPersona,
            this.MnuGestionEspecialidad});
            this.MnuMantenimientos.Name = "MnuMantenimientos";
            this.MnuMantenimientos.Size = new System.Drawing.Size(150, 24);
            this.MnuMantenimientos.Text = "MANTENIMIENTOS";
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCitas});
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(95, 24);
            this.MnuProcesos.Text = "PROCESOS";
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasPendientesToolStripMenuItem,
            this.citasCanceladasToolStripMenuItem,
            this.listaDeMedicosToolStripMenuItem,
            this.listaDeClientesToolStripMenuItem,
            this.listaDeEmpleadosToolStripMenuItem});
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(91, 24);
            this.MnuReportes.Text = "REPORTES";
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE ";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // MnuGestionPersona
            // 
            this.MnuGestionPersona.Name = "MnuGestionPersona";
            this.MnuGestionPersona.Size = new System.Drawing.Size(251, 26);
            this.MnuGestionPersona.Text = "Gestión de Personas ";
            this.MnuGestionPersona.Click += new System.EventHandler(this.gestionDePersonasToolStripMenuItem_Click);
            // 
            // MnuGestionEspecialidad
            // 
            this.MnuGestionEspecialidad.Name = "MnuGestionEspecialidad";
            this.MnuGestionEspecialidad.Size = new System.Drawing.Size(251, 26);
            this.MnuGestionEspecialidad.Text = "Gestión de Especialidad";
            // 
            // MnuCitas
            // 
            this.MnuCitas.Name = "MnuCitas";
            this.MnuCitas.Size = new System.Drawing.Size(224, 26);
            this.MnuCitas.Text = "CITAS";
            // 
            // citasPendientesToolStripMenuItem
            // 
            this.citasPendientesToolStripMenuItem.Name = "citasPendientesToolStripMenuItem";
            this.citasPendientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.citasPendientesToolStripMenuItem.Text = "Citas Pendientes ";
            // 
            // citasCanceladasToolStripMenuItem
            // 
            this.citasCanceladasToolStripMenuItem.Name = "citasCanceladasToolStripMenuItem";
            this.citasCanceladasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.citasCanceladasToolStripMenuItem.Text = "Citas Canceladas";
            // 
            // listaDeMedicosToolStripMenuItem
            // 
            this.listaDeMedicosToolStripMenuItem.Name = "listaDeMedicosToolStripMenuItem";
            this.listaDeMedicosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeMedicosToolStripMenuItem.Text = "Lista de Medicos ";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de clientes ";
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 734);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE GESTION DE CITAS PROGRA5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionPersona;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuCitas;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem citasPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasCanceladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
    }
}