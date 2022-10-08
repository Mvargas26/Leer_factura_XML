namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    partial class frmPrincipal
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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.verXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verXMLToolStripMenuItem,
            this.modificarXMLToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(1132, 46);
            this.mnPrincipal.TabIndex = 1;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // verXMLToolStripMenuItem
            // 
            this.verXMLToolStripMenuItem.Name = "verXMLToolStripMenuItem";
            this.verXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 42);
            this.verXMLToolStripMenuItem.Text = "Ver XML";
            this.verXMLToolStripMenuItem.Click += new System.EventHandler(this.verXMLToolStripMenuItem_Click);
            // 
            // modificarXMLToolStripMenuItem
            // 
            this.modificarXMLToolStripMenuItem.Name = "modificarXMLToolStripMenuItem";
            this.modificarXMLToolStripMenuItem.Size = new System.Drawing.Size(240, 42);
            this.modificarXMLToolStripMenuItem.Text = "Modificar XML";
            this.modificarXMLToolStripMenuItem.Click += new System.EventHandler(this.modificarXMLToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(95, 42);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 711);
            this.Controls.Add(this.mnPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Ventana Principal";
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem verXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

