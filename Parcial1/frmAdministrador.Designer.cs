namespace Parcial1
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablasMaestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciaPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cronogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCredencialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasMaestrasToolStripMenuItem,
            this.incidenciaPorClienteToolStripMenuItem,
            this.cronogramaToolStripMenuItem,
            this.gestionarCredencialesToolStripMenuItem,
            this.cerrarSeciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablasMaestrasToolStripMenuItem
            // 
            this.tablasMaestrasToolStripMenuItem.Name = "tablasMaestrasToolStripMenuItem";
            this.tablasMaestrasToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.tablasMaestrasToolStripMenuItem.Text = "Tablas Maestras";
            this.tablasMaestrasToolStripMenuItem.Click += new System.EventHandler(this.tablasMaestrasToolStripMenuItem_Click);
            // 
            // incidenciaPorClienteToolStripMenuItem
            // 
            this.incidenciaPorClienteToolStripMenuItem.Name = "incidenciaPorClienteToolStripMenuItem";
            this.incidenciaPorClienteToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.incidenciaPorClienteToolStripMenuItem.Text = "Incidencia por Cliente";
            this.incidenciaPorClienteToolStripMenuItem.Click += new System.EventHandler(this.incidenciaPorClienteToolStripMenuItem_Click);
            // 
            // cronogramaToolStripMenuItem
            // 
            this.cronogramaToolStripMenuItem.Name = "cronogramaToolStripMenuItem";
            this.cronogramaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cronogramaToolStripMenuItem.Text = "Cronograma";
            this.cronogramaToolStripMenuItem.Click += new System.EventHandler(this.cronogramaToolStripMenuItem_Click);
            // 
            // gestionarCredencialesToolStripMenuItem
            // 
            this.gestionarCredencialesToolStripMenuItem.Name = "gestionarCredencialesToolStripMenuItem";
            this.gestionarCredencialesToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.gestionarCredencialesToolStripMenuItem.Text = "Gestionar Credenciales";
            this.gestionarCredencialesToolStripMenuItem.Click += new System.EventHandler(this.gestionarCredencialesToolStripMenuItem_Click);
            // 
            // cerrarSeciónToolStripMenuItem
            // 
            this.cerrarSeciónToolStripMenuItem.Name = "cerrarSeciónToolStripMenuItem";
            this.cerrarSeciónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSeciónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSeciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeciónToolStripMenuItem_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 551);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdministrador";
            this.Text = "Perfil : Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablasMaestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciaPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cronogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCredencialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeciónToolStripMenuItem;
    }
}