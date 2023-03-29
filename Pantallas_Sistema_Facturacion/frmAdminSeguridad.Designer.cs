namespace Pantallas_Sistema_Facturacion
{
    partial class frmAdminSeguridad
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
            this.lblEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pnlCont.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Enabled = false;
            this.lblEmpleado.Hint = "";
            this.lblEmpleado.Location = new System.Drawing.Point(20, 42);
            this.lblEmpleado.MaxLength = 32767;
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.PasswordChar = '\0';
            this.lblEmpleado.SelectedText = "";
            this.lblEmpleado.SelectionLength = 0;
            this.lblEmpleado.SelectionStart = 0;
            this.lblEmpleado.Size = new System.Drawing.Size(69, 23);
            this.lblEmpleado.TabIndex = 47;
            this.lblEmpleado.TabStop = false;
            this.lblEmpleado.Text = "Empleado";
            this.lblEmpleado.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(699, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 36);
            this.panel1.TabIndex = 46;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(103, 36);
            this.btnSalir.TabIndex = 13;
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
            this.btnActualizar.Location = new System.Drawing.Point(699, 235);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(251, 18);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 19);
            this.lblRol.TabIndex = 43;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(95, 44);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(356, 21);
            this.cboEmpleado.TabIndex = 42;
            // 
            // txtClave
            // 
            this.txtClave.Depth = 0;
            this.txtClave.Hint = "Clave";
            this.txtClave.Location = new System.Drawing.Point(95, 175);
            this.txtClave.MaxLength = 32767;
            this.txtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.Size = new System.Drawing.Size(275, 23);
            this.txtClave.TabIndex = 38;
            this.txtClave.TabStop = false;
            this.txtClave.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(95, 100);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(275, 23);
            this.txtUsuario.TabIndex = 37;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(324, 46);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 19);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE USUARIO DEL SISTEMA";
            // 
            // pnlCont
            // 
            this.pnlCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCont.Controls.Add(this.lblEmpleado);
            this.pnlCont.Controls.Add(this.txtUsuario);
            this.pnlCont.Controls.Add(this.txtClave);
            this.pnlCont.Controls.Add(this.cboEmpleado);
            this.pnlCont.Controls.Add(this.lblRol);
            this.pnlCont.Location = new System.Drawing.Point(169, 134);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(475, 235);
            this.pnlCont.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Location = new System.Drawing.Point(699, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 36);
            this.panel2.TabIndex = 47;
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsultar.Icon = null;
            this.btnConsultar.Location = new System.Drawing.Point(0, 0);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(103, 36);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Location = new System.Drawing.Point(699, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 36);
            this.panel3.TabIndex = 49;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(103, 36);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCont);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminSeguridad";
            this.Load += new System.EventHandler(this.frmAdminSeguridad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCont.ResumeLayout(false);
            this.pnlCont.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField lblEmpleado;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}