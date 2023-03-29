namespace Pantallas_Sistema_Facturacion
{
    partial class frmListaAyuda
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
            this.wbrPagina = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbrPagina
            // 
            this.wbrPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrPagina.Location = new System.Drawing.Point(0, 0);
            this.wbrPagina.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrPagina.Name = "wbrPagina";
            this.wbrPagina.ScriptErrorsSuppressed = true;
            this.wbrPagina.Size = new System.Drawing.Size(1000, 586);
            this.wbrPagina.TabIndex = 2;
            this.wbrPagina.Url = new System.Uri("https://learn.microsoft.com/es-es/", System.UriKind.Absolute);
            // 
            // frmListaAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.wbrPagina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaAyuda";
            this.Text = "frmListaAyuda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbrPagina;
    }
}