namespace Pantallas_Sistema_Facturacion
{
    partial class frmRolEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDesRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDesRol = new System.Windows.Forms.TextBox();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.MensajeErrror = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pnlCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeErrror)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(359, 430);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 44);
            this.panel1.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(137, 44);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(151, 430);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtRol
            // 
            this.txtRol.Depth = 0;
            this.txtRol.Hint = "Nombre Rol";
            this.txtRol.Location = new System.Drawing.Point(112, 97);
            this.txtRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRol.MaxLength = 32767;
            this.txtRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.SelectedText = "";
            this.txtRol.SelectionLength = 0;
            this.txtRol.SelectionStart = 0;
            this.txtRol.Size = new System.Drawing.Size(400, 28);
            this.txtRol.TabIndex = 0;
            this.txtRol.TabStop = false;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(112, 49);
            this.txtIdRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(57, 22);
            this.txtIdRol.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(335, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 24);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDesRol
            // 
            this.lblDesRol.Depth = 0;
            this.lblDesRol.Enabled = false;
            this.lblDesRol.Hint = "";
            this.lblDesRol.Location = new System.Drawing.Point(112, 166);
            this.lblDesRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDesRol.MaxLength = 32767;
            this.lblDesRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesRol.Name = "lblDesRol";
            this.lblDesRol.PasswordChar = '\0';
            this.lblDesRol.SelectedText = "";
            this.lblDesRol.SelectionLength = 0;
            this.lblDesRol.SelectionStart = 0;
            this.lblDesRol.Size = new System.Drawing.Size(400, 28);
            this.lblDesRol.TabIndex = 22;
            this.lblDesRol.TabStop = false;
            this.lblDesRol.Text = "Descripción detallada Rol";
            this.lblDesRol.UseSystemPasswordChar = false;
            // 
            // txtDesRol
            // 
            this.txtDesRol.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDesRol.Location = new System.Drawing.Point(112, 224);
            this.txtDesRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesRol.Multiline = true;
            this.txtDesRol.Name = "txtDesRol";
            this.txtDesRol.Size = new System.Drawing.Size(399, 138);
            this.txtDesRol.TabIndex = 1;
            // 
            // pnlCont
            // 
            this.pnlCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCont.Controls.Add(this.txtIdRol);
            this.pnlCont.Controls.Add(this.txtDesRol);
            this.pnlCont.Controls.Add(this.txtRol);
            this.pnlCont.Controls.Add(this.lblDesRol);
            this.pnlCont.Controls.Add(this.btnActualizar);
            this.pnlCont.Controls.Add(this.panel1);
            this.pnlCont.Location = new System.Drawing.Point(164, 64);
            this.pnlCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(643, 519);
            this.pnlCont.TabIndex = 24;
            // 
            // MensajeErrror
            // 
            this.MensajeErrror.ContainerControl = this;
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.pnlCont);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRolEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRolEmpleados";
            this.Load += new System.EventHandler(this.frmEditarRol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCont.ResumeLayout(false);
            this.pnlCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeErrror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRol;
        private System.Windows.Forms.TextBox txtIdRol;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblDesRol;
        private System.Windows.Forms.TextBox txtDesRol;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.ErrorProvider MensajeErrror;
    }
}