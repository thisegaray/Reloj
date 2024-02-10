namespace RelojGuia2
{
    partial class Pantalla
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
            this.PanelReloj = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelReloj
            // 
            this.PanelReloj.Location = new System.Drawing.Point(12, 12);
            this.PanelReloj.Name = "PanelReloj";
            this.PanelReloj.Size = new System.Drawing.Size(760, 437);
            this.PanelReloj.TabIndex = 0;
            this.PanelReloj.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelReloj_Paint);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelReloj);
            this.MaximizeBox = false;
            this.Name = "Pantalla";
            this.Text = "Reloj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelReloj;
    }
}

