namespace Pantallas_Sistema_Facturacion
{
    partial class frmListaFacturas
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
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.Id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFacturas = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(641, 104);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 36);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgFacturas
            // 
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Factura,
            this.strCliente,
            this.strEmpleado,
            this.strFecha,
            this.strEstado,
            this.btnEditar,
            this.btnBorrar});
            this.dgFacturas.Location = new System.Drawing.Point(109, 162);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.RowHeadersWidth = 51;
            this.dgFacturas.Size = new System.Drawing.Size(783, 346);
            this.dgFacturas.TabIndex = 20;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
            // 
            // Id_Factura
            // 
            this.Id_Factura.HeaderText = "Nro FACTURA";
            this.Id_Factura.MinimumWidth = 6;
            this.Id_Factura.Name = "Id_Factura";
            this.Id_Factura.Width = 70;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.MinimumWidth = 6;
            this.strCliente.Name = "strCliente";
            this.strCliente.Width = 185;
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "EMPLEADO";
            this.strEmpleado.MinimumWidth = 6;
            this.strEmpleado.Name = "strEmpleado";
            this.strEmpleado.Width = 155;
            // 
            // strFecha
            // 
            this.strFecha.HeaderText = "FECHA";
            this.strFecha.MinimumWidth = 6;
            this.strFecha.Name = "strFecha";
            this.strFecha.Width = 70;
            // 
            // strEstado
            // 
            this.strEstado.HeaderText = "ESTADO";
            this.strEstado.MinimumWidth = 6;
            this.strEstado.Name = "strEstado";
            this.strEstado.Width = 90;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Location = new System.Drawing.Point(818, 514);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 36);
            this.panel3.TabIndex = 19;
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
            this.btnSalir.Size = new System.Drawing.Size(74, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Location = new System.Drawing.Point(818, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 36);
            this.panel2.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(74, 36);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar Factura";
            this.txtBuscar.Location = new System.Drawing.Point(109, 113);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(526, 23);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Depth = 0;
            this.lblFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFacturas.Location = new System.Drawing.Point(387, 37);
            this.lblFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(235, 19);
            this.lblFacturas.TabIndex = 15;
            this.lblFacturas.Text = "ADMINISTRACIÓN DE FACTURAS";
            // 
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.DataGridView dgFacturas;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEstado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}