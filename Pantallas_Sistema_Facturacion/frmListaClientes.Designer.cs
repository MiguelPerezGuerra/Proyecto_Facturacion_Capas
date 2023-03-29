namespace Pantallas_Sistema_Facturacion
{
    partial class frmListaClientes
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.strTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlButtonNuevo = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlButtonNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(515, 63);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(283, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACION DE CLIENTES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar por Cliente";
            this.txtBuscar.Location = new System.Drawing.Point(144, 156);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(701, 28);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(853, 145);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // strTelefono
            // 
            this.strTelefono.HeaderText = "TELEFONO";
            this.strTelefono.MinimumWidth = 6;
            this.strTelefono.Name = "strTelefono";
            this.strTelefono.Width = 125;
            // 
            // strDocumento
            // 
            this.strDocumento.HeaderText = "DOCUMENTO";
            this.strDocumento.MinimumWidth = 6;
            this.strDocumento.Name = "strDocumento";
            this.strDocumento.Width = 125;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.MinimumWidth = 6;
            this.strCliente.Name = "strCliente";
            this.strCliente.Width = 300;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "ID";
            this.Id_Cliente.MinimumWidth = 6;
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Width = 80;
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.strCliente,
            this.strDocumento,
            this.strTelefono,
            this.btnEditar,
            this.btnBorrar});
            this.dgClientes.Location = new System.Drawing.Point(144, 217);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.Size = new System.Drawing.Size(1044, 426);
            this.dgClientes.TabIndex = 5;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
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
            this.btnSalir.Size = new System.Drawing.Size(99, 44);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnSalir);
            this.pnlButton.Location = new System.Drawing.Point(1089, 650);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(99, 44);
            this.pnlButton.TabIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(99, 44);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlButtonNuevo
            // 
            this.pnlButtonNuevo.Controls.Add(this.btnNuevo);
            this.pnlButtonNuevo.Location = new System.Drawing.Point(1089, 145);
            this.pnlButtonNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButtonNuevo.Name = "pnlButtonNuevo";
            this.pnlButtonNuevo.Size = new System.Drawing.Size(99, 44);
            this.pnlButtonNuevo.TabIndex = 7;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(130, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1070, 645);
            this.pnlContent.TabIndex = 8;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 721);
            this.ControlBox = false;
            this.Controls.Add(this.pnlButtonNuevo);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaClientes";
            this.ShowIcon = false;
            this.Text = "CRUD LISTA CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlButtonNuevo.ResumeLayout(false);
            this.pnlButtonNuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridView dgClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel pnlButton;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.Panel pnlButtonNuevo;
        private System.Windows.Forms.Panel pnlContent;
    }
}