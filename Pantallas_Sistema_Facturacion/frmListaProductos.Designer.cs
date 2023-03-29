namespace Pantallas_Sistema_Facturacion
{
    partial class frmListaProductos
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(386, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(246, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar Producto";
            this.txtBuscar.Location = new System.Drawing.Point(108, 131);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(526, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(640, 118);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.panel2.Location = new System.Drawing.Point(817, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 36);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Location = new System.Drawing.Point(817, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 36);
            this.panel3.TabIndex = 7;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.strCodigo,
            this.strProducto,
            this.intCategoria,
            this.strPrecio,
            this.strStock,
            this.btnEditar,
            this.btnBorrar});
            this.dgProductos.Location = new System.Drawing.Point(108, 176);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.Size = new System.Drawing.Size(783, 346);
            this.dgProductos.TabIndex = 8;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "ID";
            this.Id_Producto.MinimumWidth = 6;
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.Width = 45;
            // 
            // strCodigo
            // 
            this.strCodigo.HeaderText = "CODIGO";
            this.strCodigo.MinimumWidth = 6;
            this.strCodigo.Name = "strCodigo";
            this.strCodigo.Width = 75;
            // 
            // strProducto
            // 
            this.strProducto.HeaderText = "PRODUCTO";
            this.strProducto.MinimumWidth = 6;
            this.strProducto.Name = "strProducto";
            this.strProducto.Width = 220;
            // 
            // intCategoria
            // 
            this.intCategoria.HeaderText = "CATEGORIA";
            this.intCategoria.MinimumWidth = 6;
            this.intCategoria.Name = "intCategoria";
            // 
            // strPrecio
            // 
            this.strPrecio.HeaderText = "PRECIO";
            this.strPrecio.MinimumWidth = 6;
            this.strPrecio.Name = "strPrecio";
            this.strPrecio.Width = 70;
            // 
            // strStock
            // 
            this.strStock.HeaderText = "STOCK";
            this.strStock.MinimumWidth = 6;
            this.strStock.Name = "strStock";
            this.strStock.Width = 60;
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
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.Text = "frmListaProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn strPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn strStock;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}