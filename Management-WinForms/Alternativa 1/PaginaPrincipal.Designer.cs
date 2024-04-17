namespace Alternativa_1
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaListaToolStripMenuItem,
            this.cargarListaToolStripMenuItem,
            this.guardarListaToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(48, 20);
            this.tsmiInicio.Text = "Inicio";
            // 
            // nuevaListaToolStripMenuItem
            // 
            this.nuevaListaToolStripMenuItem.Name = "nuevaListaToolStripMenuItem";
            this.nuevaListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaListaToolStripMenuItem.Text = "Nueva Lista";
            // 
            // cargarListaToolStripMenuItem
            // 
            this.cargarListaToolStripMenuItem.Name = "cargarListaToolStripMenuItem";
            this.cargarListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarListaToolStripMenuItem.Text = "Cargar Lista";
            // 
            // guardarListaToolStripMenuItem
            // 
            this.guardarListaToolStripMenuItem.Name = "guardarListaToolStripMenuItem";
            this.guardarListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarListaToolStripMenuItem.Text = "Guardar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaginaPrincipal";
            this.Text = " Gestor de artículos SupremoMax";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem nuevaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

