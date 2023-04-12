namespace Pantallas_Sistema_Facturacion
{
    partial class frmFacturas
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
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblNroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtTotalIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFecha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFacturaEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEstadoFactura = new System.Windows.Forms.ComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFatura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgDetFact = new System.Windows.Forms.DataGridView();
            this.strCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDetalleProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetFact)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(761, 273);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(137, 44);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(63, 273);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(359, 28);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdFactura.Location = new System.Drawing.Point(183, 124);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(238, 22);
            this.txtIdFactura.TabIndex = 0;
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
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Depth = 0;
            this.lblNroFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroFactura.Location = new System.Drawing.Point(57, 122);
            this.lblNroFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(0, 24);
            this.lblNroFactura.TabIndex = 22;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "1022",
            "1029"});
            this.cboCliente.Location = new System.Drawing.Point(183, 170);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(237, 24);
            this.cboCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.CausesValidation = false;
            this.lblCliente.Depth = 0;
            this.lblCliente.Enabled = false;
            this.lblCliente.Hint = "";
            this.lblCliente.Location = new System.Drawing.Point(63, 167);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4);
            this.lblCliente.MaxLength = 32767;
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.PasswordChar = '\0';
            this.lblCliente.SelectedText = "";
            this.lblCliente.SelectionLength = 0;
            this.lblCliente.SelectionStart = 0;
            this.lblCliente.Size = new System.Drawing.Size(145, 28);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.TabStop = false;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.UseSystemPasswordChar = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.CausesValidation = false;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Enabled = false;
            this.lblEmpleado.Hint = "";
            this.lblEmpleado.Location = new System.Drawing.Point(63, 219);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.lblEmpleado.MaxLength = 32767;
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.PasswordChar = '\0';
            this.lblEmpleado.SelectedText = "";
            this.lblEmpleado.SelectionLength = 0;
            this.lblEmpleado.SelectionStart = 0;
            this.lblEmpleado.Size = new System.Drawing.Size(145, 28);
            this.lblEmpleado.TabIndex = 26;
            this.lblEmpleado.TabStop = false;
            this.lblEmpleado.Text = "Empleado";
            this.lblEmpleado.UseSystemPasswordChar = false;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboEmpleado.Location = new System.Drawing.Point(183, 219);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(237, 24);
            this.cboEmpleado.TabIndex = 2;
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.Depth = 0;
            this.txtTotalIva.Hint = "Total Iva";
            this.txtTotalIva.Location = new System.Drawing.Point(63, 324);
            this.txtTotalIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalIva.MaxLength = 32767;
            this.txtTotalIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.PasswordChar = '\0';
            this.txtTotalIva.SelectedText = "";
            this.txtTotalIva.SelectionLength = 0;
            this.txtTotalIva.SelectionStart = 0;
            this.txtTotalIva.Size = new System.Drawing.Size(359, 28);
            this.txtTotalIva.TabIndex = 4;
            this.txtTotalIva.TabStop = false;
            this.txtTotalIva.UseSystemPasswordChar = false;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total Factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(63, 378);
            this.txtTotalFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(359, 28);
            this.txtTotalFactura.TabIndex = 5;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // lblFecha
            // 
            this.lblFecha.CausesValidation = false;
            this.lblFecha.Depth = 0;
            this.lblFecha.Enabled = false;
            this.lblFecha.Hint = "";
            this.lblFecha.Location = new System.Drawing.Point(484, 139);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4);
            this.lblFecha.MaxLength = 32767;
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.PasswordChar = '\0';
            this.lblFecha.SelectedText = "";
            this.lblFecha.SelectionLength = 0;
            this.lblFecha.SelectionStart = 0;
            this.lblFecha.Size = new System.Drawing.Size(176, 28);
            this.lblFecha.TabIndex = 30;
            this.lblFecha.TabStop = false;
            this.lblFecha.Text = "Fecha Registro";
            this.lblFecha.UseSystemPasswordChar = false;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.CustomFormat = "";
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(484, 175);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegistro.MinDate = new System.DateTime(1799, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(176, 22);
            this.dtpFechaRegistro.TabIndex = 6;
            this.dtpFechaRegistro.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // lblFacturaEstado
            // 
            this.lblFacturaEstado.CausesValidation = false;
            this.lblFacturaEstado.Depth = 0;
            this.lblFacturaEstado.Enabled = false;
            this.lblFacturaEstado.Hint = "";
            this.lblFacturaEstado.Location = new System.Drawing.Point(484, 234);
            this.lblFacturaEstado.Margin = new System.Windows.Forms.Padding(4);
            this.lblFacturaEstado.MaxLength = 32767;
            this.lblFacturaEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFacturaEstado.Name = "lblFacturaEstado";
            this.lblFacturaEstado.PasswordChar = '\0';
            this.lblFacturaEstado.SelectedText = "";
            this.lblFacturaEstado.SelectionLength = 0;
            this.lblFacturaEstado.SelectionStart = 0;
            this.lblFacturaEstado.Size = new System.Drawing.Size(176, 28);
            this.lblFacturaEstado.TabIndex = 32;
            this.lblFacturaEstado.TabStop = false;
            this.lblFacturaEstado.Text = "Estado Factura";
            this.lblFacturaEstado.UseSystemPasswordChar = false;
            // 
            // cboEstadoFactura
            // 
            this.cboEstadoFactura.FormattingEnabled = true;
            this.cboEstadoFactura.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboEstadoFactura.Location = new System.Drawing.Point(484, 270);
            this.cboEstadoFactura.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstadoFactura.Name = "cboEstadoFactura";
            this.cboEstadoFactura.Size = new System.Drawing.Size(176, 24);
            this.cboEstadoFactura.TabIndex = 7;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(63, 449);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialDivider1.Size = new System.Drawing.Size(836, 151);
            this.materialDivider1.TabIndex = 34;
            this.materialDivider1.Text = "Detalle Factura";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.CausesValidation = false;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(63, 421);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(4);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(835, 28);
            this.materialSingleLineTextField1.TabIndex = 35;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "Detalle Factura";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // lblFatura
            // 
            this.lblFatura.CausesValidation = false;
            this.lblFatura.Depth = 0;
            this.lblFatura.Enabled = false;
            this.lblFatura.Hint = "";
            this.lblFatura.Location = new System.Drawing.Point(63, 117);
            this.lblFatura.Margin = new System.Windows.Forms.Padding(4);
            this.lblFatura.MaxLength = 32767;
            this.lblFatura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.PasswordChar = '\0';
            this.lblFatura.SelectedText = "";
            this.lblFatura.SelectionLength = 0;
            this.lblFatura.SelectionStart = 0;
            this.lblFatura.Size = new System.Drawing.Size(145, 28);
            this.lblFatura.TabIndex = 37;
            this.lblFatura.TabStop = false;
            this.lblFatura.Text = "Nro Factura";
            this.lblFatura.UseSystemPasswordChar = false;
            // 
            // dgDetFact
            // 
            this.dgDetFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strCodigo,
            this.strProducto,
            this.strCantidad,
            this.strValor,
            this.strTotal,
            this.strDetalleProd});
            this.dgDetFact.Location = new System.Drawing.Point(81, 462);
            this.dgDetFact.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetFact.Name = "dgDetFact";
            this.dgDetFact.RowHeadersWidth = 51;
            this.dgDetFact.Size = new System.Drawing.Size(800, 129);
            this.dgDetFact.TabIndex = 38;
            // 
            // strCodigo
            // 
            this.strCodigo.HeaderText = "CODIGO";
            this.strCodigo.MinimumWidth = 6;
            this.strCodigo.Name = "strCodigo";
            this.strCodigo.Width = 60;
            // 
            // strProducto
            // 
            this.strProducto.HeaderText = "PRODUCTO";
            this.strProducto.MinimumWidth = 6;
            this.strProducto.Name = "strProducto";
            this.strProducto.Width = 130;
            // 
            // strCantidad
            // 
            this.strCantidad.HeaderText = "CANTIDAD";
            this.strCantidad.MinimumWidth = 6;
            this.strCantidad.Name = "strCantidad";
            this.strCantidad.Width = 75;
            // 
            // strValor
            // 
            this.strValor.HeaderText = "VALOR";
            this.strValor.MinimumWidth = 6;
            this.strValor.Name = "strValor";
            this.strValor.Width = 70;
            // 
            // strTotal
            // 
            this.strTotal.HeaderText = "TOTAL";
            this.strTotal.MinimumWidth = 6;
            this.strTotal.Name = "strTotal";
            this.strTotal.Width = 70;
            // 
            // strDetalleProd
            // 
            this.strDetalleProd.HeaderText = "DETALLE";
            this.strDetalleProd.MinimumWidth = 6;
            this.strDetalleProd.Name = "strDetalleProd";
            this.strDetalleProd.Width = 125;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(0, 0);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(137, 44);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Location = new System.Drawing.Point(761, 139);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 44);
            this.panel2.TabIndex = 22;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.dgDetFact);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cboEstadoFactura);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.txtTotalIva);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFatura);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFacturaEstado);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmEditarFacturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetFact)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private System.Windows.Forms.TextBox txtIdFactura;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblNroFactura;
        private System.Windows.Forms.ComboBox cboCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFacturaEstado;
        private System.Windows.Forms.ComboBox cboEstadoFactura;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFatura;
        private System.Windows.Forms.DataGridView dgDetFact;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn strValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDetalleProd;
    }
}