namespace Pantallas_Sistema_Facturacion
{
    partial class frmEmpleados
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
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDirEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFIngreso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFRetiro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDatos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFRetiro = new System.Windows.Forms.DateTimePicker();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(532, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 44);
            this.panel1.TabIndex = 28;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(137, 44);
            this.btnSalir.TabIndex = 10;
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
            this.btnActualizar.Location = new System.Drawing.Point(324, 500);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(532, 378);
            this.txtDatosAdicionales.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(365, 94);
            this.txtDatosAdicionales.TabIndex = 8;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(527, 139);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 24);
            this.lblRol.TabIndex = 23;
            // 
            // cboRol
            // 
            this.cboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboRol.Location = new System.Drawing.Point(696, 142);
            this.cboRol.Margin = new System.Windows.Forms.Padding(4);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(201, 24);
            this.cboRol.TabIndex = 5;
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Hint = "Email";
            this.txtEmailEmpleado.Location = new System.Drawing.Point(95, 398);
            this.txtEmailEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailEmpleado.MaxLength = 32767;
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.PasswordChar = '\0';
            this.txtEmailEmpleado.SelectedText = "";
            this.txtEmailEmpleado.SelectionLength = 0;
            this.txtEmailEmpleado.SelectionStart = 0;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(367, 28);
            this.txtEmailEmpleado.TabIndex = 4;
            this.txtEmailEmpleado.TabStop = false;
            this.txtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // txtTelEmpleado
            // 
            this.txtTelEmpleado.Depth = 0;
            this.txtTelEmpleado.Hint = "Teléfono";
            this.txtTelEmpleado.Location = new System.Drawing.Point(95, 331);
            this.txtTelEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelEmpleado.MaxLength = 32767;
            this.txtTelEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelEmpleado.Name = "txtTelEmpleado";
            this.txtTelEmpleado.PasswordChar = '\0';
            this.txtTelEmpleado.SelectedText = "";
            this.txtTelEmpleado.SelectionLength = 0;
            this.txtTelEmpleado.SelectionStart = 0;
            this.txtTelEmpleado.Size = new System.Drawing.Size(367, 28);
            this.txtTelEmpleado.TabIndex = 3;
            this.txtTelEmpleado.TabStop = false;
            this.txtTelEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDirEmpleado
            // 
            this.txtDirEmpleado.Depth = 0;
            this.txtDirEmpleado.Hint = "Dirección";
            this.txtDirEmpleado.Location = new System.Drawing.Point(95, 266);
            this.txtDirEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirEmpleado.MaxLength = 32767;
            this.txtDirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDirEmpleado.Name = "txtDirEmpleado";
            this.txtDirEmpleado.PasswordChar = '\0';
            this.txtDirEmpleado.SelectedText = "";
            this.txtDirEmpleado.SelectionLength = 0;
            this.txtDirEmpleado.SelectionStart = 0;
            this.txtDirEmpleado.Size = new System.Drawing.Size(367, 28);
            this.txtDirEmpleado.TabIndex = 2;
            this.txtDirEmpleado.TabStop = false;
            this.txtDirEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDocEmpleado
            // 
            this.txtDocEmpleado.Depth = 0;
            this.txtDocEmpleado.Hint = "Documento";
            this.txtDocEmpleado.Location = new System.Drawing.Point(95, 199);
            this.txtDocEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocEmpleado.MaxLength = 32767;
            this.txtDocEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocEmpleado.Name = "txtDocEmpleado";
            this.txtDocEmpleado.PasswordChar = '\0';
            this.txtDocEmpleado.SelectedText = "";
            this.txtDocEmpleado.SelectionLength = 0;
            this.txtDocEmpleado.SelectionStart = 0;
            this.txtDocEmpleado.Size = new System.Drawing.Size(367, 28);
            this.txtDocEmpleado.TabIndex = 1;
            this.txtDocEmpleado.TabStop = false;
            this.txtDocEmpleado.UseSystemPasswordChar = false;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Depth = 0;
            this.txtEmpleado.Hint = "Nombre Empleado";
            this.txtEmpleado.Location = new System.Drawing.Point(95, 139);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpleado.MaxLength = 32767;
            this.txtEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasswordChar = '\0';
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.SelectionLength = 0;
            this.txtEmpleado.SelectionStart = 0;
            this.txtEmpleado.Size = new System.Drawing.Size(367, 28);
            this.txtEmpleado.TabIndex = 0;
            this.txtEmpleado.TabStop = false;
            this.txtEmpleado.UseSystemPasswordChar = false;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(95, 84);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(57, 22);
            this.txtIdEmpleado.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(333, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 24);
            this.lblTitulo.TabIndex = 88;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Enabled = false;
            this.lblRolEmpleado.Hint = "";
            this.lblRolEmpleado.Location = new System.Drawing.Point(537, 139);
            this.lblRolEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.lblRolEmpleado.MaxLength = 32767;
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.PasswordChar = '\0';
            this.lblRolEmpleado.SelectedText = "";
            this.lblRolEmpleado.SelectionLength = 0;
            this.lblRolEmpleado.SelectionStart = 0;
            this.lblRolEmpleado.Size = new System.Drawing.Size(132, 28);
            this.lblRolEmpleado.TabIndex = 29;
            this.lblRolEmpleado.TabStop = false;
            this.lblRolEmpleado.Text = "Rol Empleado";
            this.lblRolEmpleado.UseSystemPasswordChar = false;
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.Depth = 0;
            this.lblFIngreso.Enabled = false;
            this.lblFIngreso.Hint = "";
            this.lblFIngreso.Location = new System.Drawing.Point(577, 199);
            this.lblFIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.lblFIngreso.MaxLength = 32767;
            this.lblFIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.PasswordChar = '\0';
            this.lblFIngreso.SelectedText = "";
            this.lblFIngreso.SelectionLength = 0;
            this.lblFIngreso.SelectionStart = 0;
            this.lblFIngreso.Size = new System.Drawing.Size(92, 28);
            this.lblFIngreso.TabIndex = 30;
            this.lblFIngreso.TabStop = false;
            this.lblFIngreso.Text = "F. Ingreso";
            this.lblFIngreso.UseSystemPasswordChar = false;
            // 
            // lblFRetiro
            // 
            this.lblFRetiro.Depth = 0;
            this.lblFRetiro.Enabled = false;
            this.lblFRetiro.Hint = "";
            this.lblFRetiro.Location = new System.Drawing.Point(577, 252);
            this.lblFRetiro.Margin = new System.Windows.Forms.Padding(4);
            this.lblFRetiro.MaxLength = 32767;
            this.lblFRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFRetiro.Name = "lblFRetiro";
            this.lblFRetiro.PasswordChar = '\0';
            this.lblFRetiro.SelectedText = "";
            this.lblFRetiro.SelectionLength = 0;
            this.lblFRetiro.SelectionStart = 0;
            this.lblFRetiro.Size = new System.Drawing.Size(92, 28);
            this.lblFRetiro.TabIndex = 31;
            this.lblFRetiro.TabStop = false;
            this.lblFRetiro.Text = "F. Retiro";
            this.lblFRetiro.UseSystemPasswordChar = false;
            // 
            // lblDatos
            // 
            this.lblDatos.Depth = 0;
            this.lblDatos.Enabled = false;
            this.lblDatos.Hint = "";
            this.lblDatos.Location = new System.Drawing.Point(532, 345);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4);
            this.lblDatos.MaxLength = 32767;
            this.lblDatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.PasswordChar = '\0';
            this.lblDatos.SelectedText = "";
            this.lblDatos.SelectionLength = 0;
            this.lblDatos.SelectionStart = 0;
            this.lblDatos.Size = new System.Drawing.Size(204, 28);
            this.lblDatos.TabIndex = 32;
            this.lblDatos.TabStop = false;
            this.lblDatos.Text = "DATOS ADICIONALES";
            this.lblDatos.UseSystemPasswordChar = false;
            // 
            // dtpFIngreso
            // 
            this.dtpFIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFIngreso.Location = new System.Drawing.Point(696, 203);
            this.dtpFIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFIngreso.MinDate = new System.DateTime(1799, 1, 1, 0, 0, 0, 0);
            this.dtpFIngreso.Name = "dtpFIngreso";
            this.dtpFIngreso.Size = new System.Drawing.Size(201, 22);
            this.dtpFIngreso.TabIndex = 6;
            // 
            // dtpFRetiro
            // 
            this.dtpFRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFRetiro.Location = new System.Drawing.Point(696, 256);
            this.dtpFRetiro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFRetiro.MinDate = new System.DateTime(1799, 1, 1, 0, 0, 0, 0);
            this.dtpFRetiro.Name = "dtpFRetiro";
            this.dtpFRetiro.Size = new System.Drawing.Size(201, 22);
            this.dtpFRetiro.TabIndex = 7;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.dtpFRetiro);
            this.Controls.Add(this.dtpFIngreso);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblFRetiro);
            this.Controls.Add(this.lblFIngreso);
            this.Controls.Add(this.lblRolEmpleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDatosAdicionales);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.txtEmailEmpleado);
            this.Controls.Add(this.txtTelEmpleado);
            this.Controls.Add(this.txtDirEmpleado);
            this.Controls.Add(this.txtDocEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEditarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDirEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblRolEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFIngreso;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFRetiro;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblDatos;
        private System.Windows.Forms.DateTimePicker dtpFIngreso;
        private System.Windows.Forms.DateTimePicker dtpFRetiro;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}