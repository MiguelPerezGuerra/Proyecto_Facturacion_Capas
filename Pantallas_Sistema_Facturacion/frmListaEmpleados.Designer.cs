namespace Pantallas_Sistema_Facturacion
{
    partial class frmListaEmpleados
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
            this.pnlButtonNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.Id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumentoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTelefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmailEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaIngresoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlButtonNuevo.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtonNuevo
            // 
            this.pnlButtonNuevo.Controls.Add(this.btnNuevo);
            this.pnlButtonNuevo.Location = new System.Drawing.Point(1092, 144);
            this.pnlButtonNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtonNuevo.Name = "pnlButtonNuevo";
            this.pnlButtonNuevo.Size = new System.Drawing.Size(99, 44);
            this.pnlButtonNuevo.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(99, 44);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnSalir);
            this.pnlButton.Location = new System.Drawing.Point(1092, 649);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(99, 44);
            this.pnlButton.TabIndex = 12;
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
            this.btnSalir.Size = new System.Drawing.Size(99, 44);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Empleado,
            this.strEmpleado,
            this.strDocumentoEmpleado,
            this.strTelefonoEmpleado,
            this.strEmailEmpleado,
            this.strRol,
            this.strFechaIngresoEmpleado,
            this.strFechaRetiro,
            this.btnEditar,
            this.btnBorrar});
            this.dgEmpleados.Location = new System.Drawing.Point(147, 215);
            this.dgEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.Size = new System.Drawing.Size(1044, 426);
            this.dgEmpleados.TabIndex = 3;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // Id_Empleado
            // 
            this.Id_Empleado.HeaderText = "ID";
            this.Id_Empleado.MinimumWidth = 6;
            this.Id_Empleado.Name = "Id_Empleado";
            this.Id_Empleado.Width = 40;
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "NOMBRE EMPLEADO";
            this.strEmpleado.MinimumWidth = 6;
            this.strEmpleado.Name = "strEmpleado";
            this.strEmpleado.Width = 150;
            // 
            // strDocumentoEmpleado
            // 
            this.strDocumentoEmpleado.HeaderText = "DOCUMENTO";
            this.strDocumentoEmpleado.MinimumWidth = 6;
            this.strDocumentoEmpleado.Name = "strDocumentoEmpleado";
            this.strDocumentoEmpleado.Width = 80;
            // 
            // strTelefonoEmpleado
            // 
            this.strTelefonoEmpleado.HeaderText = "TELEFONO";
            this.strTelefonoEmpleado.MinimumWidth = 6;
            this.strTelefonoEmpleado.Name = "strTelefonoEmpleado";
            this.strTelefonoEmpleado.Width = 70;
            // 
            // strEmailEmpleado
            // 
            this.strEmailEmpleado.HeaderText = "EMAIL";
            this.strEmailEmpleado.MinimumWidth = 6;
            this.strEmailEmpleado.Name = "strEmailEmpleado";
            this.strEmailEmpleado.Width = 80;
            // 
            // strRol
            // 
            this.strRol.HeaderText = "ROL";
            this.strRol.MinimumWidth = 6;
            this.strRol.Name = "strRol";
            this.strRol.Width = 40;
            // 
            // strFechaIngresoEmpleado
            // 
            this.strFechaIngresoEmpleado.HeaderText = "F. INGRESO";
            this.strFechaIngresoEmpleado.MinimumWidth = 6;
            this.strFechaIngresoEmpleado.Name = "strFechaIngresoEmpleado";
            this.strFechaIngresoEmpleado.Width = 60;
            // 
            // strFechaRetiro
            // 
            this.strFechaRetiro.HeaderText = "F. RETIRO";
            this.strFechaRetiro.MinimumWidth = 6;
            this.strFechaRetiro.Name = "strFechaRetiro";
            this.strFechaRetiro.Width = 50;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.MinimumWidth = 6;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(856, 144);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar Empleado";
            this.txtBuscar.Location = new System.Drawing.Point(147, 155);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(701, 28);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(517, 62);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "ADMINISTRACION DE EMPLEADOS";
            // 
            // frmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 721);
            this.Controls.Add(this.pnlButtonNuevo);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaEmpleados";
            this.Text = "frmListaEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaEmpleados_Load);
            this.pnlButtonNuevo.ResumeLayout(false);
            this.pnlButtonNuevo.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.Panel pnlButton;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumentoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefonoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmailEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaIngresoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaRetiro;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}