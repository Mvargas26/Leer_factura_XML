namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    partial class frmConsultar_XML
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
            this.btnVer = new System.Windows.Forms.Button();
            this.grpVer = new System.Windows.Forms.GroupBox();
            this.listDetalle = new System.Windows.Forms.ListView();
            this.grpVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(315, 48);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(214, 64);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // grpVer
            // 
            this.grpVer.AutoSize = true;
            this.grpVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpVer.Controls.Add(this.btnVer);
            this.grpVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVer.Location = new System.Drawing.Point(0, 0);
            this.grpVer.Name = "grpVer";
            this.grpVer.Size = new System.Drawing.Size(925, 137);
            this.grpVer.TabIndex = 2;
            this.grpVer.TabStop = false;
            this.grpVer.Text = "Ver Factura";
            // 
            // listDetalle
            // 
            this.listDetalle.BackColor = System.Drawing.Color.White;
            this.listDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDetalle.GridLines = true;
            this.listDetalle.HideSelection = false;
            this.listDetalle.Location = new System.Drawing.Point(0, 137);
            this.listDetalle.Name = "listDetalle";
            this.listDetalle.Size = new System.Drawing.Size(925, 576);
            this.listDetalle.TabIndex = 3;
            this.listDetalle.UseCompatibleStateImageBehavior = false;
            this.listDetalle.View = System.Windows.Forms.View.List;
            // 
            // frmConsultar_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 713);
            this.Controls.Add(this.listDetalle);
            this.Controls.Add(this.grpVer);
            this.Name = "frmConsultar_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultar_XML";
            this.grpVer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.GroupBox grpVer;
        private System.Windows.Forms.ListView listDetalle;
    }
}