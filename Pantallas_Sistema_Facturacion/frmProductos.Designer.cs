namespace Pantallas_Sistema_Facturacion
{
    partial class frmProductos
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDatalle = new System.Windows.Forms.TextBox();
            this.lblDetalles = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(96, 84);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(57, 22);
            this.txtIdProducto.TabIndex = 1;
            // 
            // txtProducto
            // 
            this.txtProducto.Depth = 0;
            this.txtProducto.Hint = "Nombre Producto";
            this.txtProducto.Location = new System.Drawing.Point(96, 139);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.Size = new System.Drawing.Size(367, 28);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.TabStop = false;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtCodReferencia
            // 
            this.txtCodReferencia.Depth = 0;
            this.txtCodReferencia.Hint = "Código Referencia";
            this.txtCodReferencia.Location = new System.Drawing.Point(96, 199);
            this.txtCodReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodReferencia.MaxLength = 32767;
            this.txtCodReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodReferencia.Name = "txtCodReferencia";
            this.txtCodReferencia.PasswordChar = '\0';
            this.txtCodReferencia.SelectedText = "";
            this.txtCodReferencia.SelectionLength = 0;
            this.txtCodReferencia.SelectionStart = 0;
            this.txtCodReferencia.Size = new System.Drawing.Size(367, 28);
            this.txtCodReferencia.TabIndex = 3;
            this.txtCodReferencia.TabStop = false;
            this.txtCodReferencia.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio Compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(96, 266);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.MaxLength = 32767;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(367, 28);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.TabStop = false;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio Venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(96, 331);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.MaxLength = 32767;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(367, 28);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.TabStop = false;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtStock
            // 
            this.txtStock.Depth = 0;
            this.txtStock.Hint = "Cantidad Stock";
            this.txtStock.Location = new System.Drawing.Point(96, 398);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.MaxLength = 32767;
            this.txtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.Size = new System.Drawing.Size(367, 28);
            this.txtStock.TabIndex = 6;
            this.txtStock.TabStop = false;
            this.txtStock.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCategoria.Location = new System.Drawing.Point(635, 137);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(264, 24);
            this.cboCategoria.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(528, 139);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 24);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "Ruta Imagen";
            this.txtRutaImagen.Location = new System.Drawing.Point(533, 210);
            this.txtRutaImagen.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaImagen.MaxLength = 32767;
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.PasswordChar = '\0';
            this.txtRutaImagen.SelectedText = "";
            this.txtRutaImagen.SelectionLength = 0;
            this.txtRutaImagen.SelectionStart = 0;
            this.txtRutaImagen.Size = new System.Drawing.Size(367, 28);
            this.txtRutaImagen.TabIndex = 9;
            this.txtRutaImagen.TabStop = false;
            this.txtRutaImagen.UseSystemPasswordChar = false;
            // 
            // txtDatalle
            // 
            this.txtDatalle.Location = new System.Drawing.Point(533, 331);
            this.txtDatalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatalle.Multiline = true;
            this.txtDatalle.Name = "txtDatalle";
            this.txtDatalle.Size = new System.Drawing.Size(365, 94);
            this.txtDatalle.TabIndex = 10;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Depth = 0;
            this.lblDetalles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalles.Location = new System.Drawing.Point(528, 288);
            this.lblDetalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(160, 24);
            this.lblDetalles.TabIndex = 11;
            this.lblDetalles.Text = "Detalles Producto";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(325, 500);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(533, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 44);
            this.panel1.TabIndex = 14;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtDatalle);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCodReferencia);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.TextBox txtIdProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStock;
        private System.Windows.Forms.ComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private System.Windows.Forms.TextBox txtDatalle;
        private MaterialSkin.Controls.MaterialLabel lblDetalles;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}