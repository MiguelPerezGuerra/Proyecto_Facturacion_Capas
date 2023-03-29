namespace Pantallas_Sistema_Facturacion
{
    partial class frmPrincipal
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.TbnMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Facturacion = new System.Windows.Forms.TabPage();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.PnlPrincipal.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.TbnMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.pnlContenedor);
            this.PnlPrincipal.Controls.Add(this.PnlMenu);
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 64);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1200, 586);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1000, 586);
            this.pnlContenedor.TabIndex = 1;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.TbnMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 586);
            this.PnlMenu.TabIndex = 0;
            // 
            // TbnMenu
            // 
            this.TbnMenu.Controls.Add(this.Principal);
            this.TbnMenu.Controls.Add(this.Tablas);
            this.TbnMenu.Controls.Add(this.Facturacion);
            this.TbnMenu.Controls.Add(this.Seguridad);
            this.TbnMenu.Controls.Add(this.Acerca);
            this.TbnMenu.Depth = 0;
            this.TbnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbnMenu.Location = new System.Drawing.Point(0, 0);
            this.TbnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbnMenu.Name = "TbnMenu";
            this.TbnMenu.SelectedIndex = 0;
            this.TbnMenu.Size = new System.Drawing.Size(200, 586);
            this.TbnMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 560);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.cerrar1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(-1, 144);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tablas.Controls.Add(this.btnCategorias);
            this.Tablas.Controls.Add(this.btnProductos);
            this.Tablas.Controls.Add(this.btnClientes);
            this.Tablas.Controls.Add(this.pictureBox2);
            this.Tablas.Location = new System.Drawing.Point(4, 22);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(192, 560);
            this.Tablas.TabIndex = 1;
            this.Tablas.Text = "Abmin Tablas";
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.nube;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(-1, 256);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(205, 50);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "  Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.carrito_de_compras;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(-1, 200);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(205, 50);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = " Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.dos_tarjetas_de_presentacion_con_texto_y_fotografia;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-1, 144);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(205, 50);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Facturacion
            // 
            this.Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Facturacion.Controls.Add(this.btnInformes);
            this.Facturacion.Controls.Add(this.btnFacturas);
            this.Facturacion.Controls.Add(this.pictureBox3);
            this.Facturacion.Location = new System.Drawing.Point(4, 22);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(192, 560);
            this.Facturacion.TabIndex = 2;
            this.Facturacion.Text = "Facturación";
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInformes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.lista_de_verificacion;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(-1, 200);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(205, 50);
            this.btnInformes.TabIndex = 10;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.cuenta;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(-1, 144);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(205, 50);
            this.btnFacturas.TabIndex = 9;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Seguridad.Controls.Add(this.btnSeguridad);
            this.Seguridad.Controls.Add(this.btnRoles);
            this.Seguridad.Controls.Add(this.btnEmpleados);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 560);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSeguridad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.seguridad_online;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(-1, 256);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(205, 50);
            this.btnSeguridad.TabIndex = 11;
            this.btnSeguridad.Text = "  Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.equipo;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(-1, 200);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(205, 50);
            this.btnRoles.TabIndex = 10;
            this.btnRoles.Text = " Roles";
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.cliente;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(-1, 144);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(205, 50);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Text = " Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(186, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Acerca.Controls.Add(this.btnAcerca);
            this.Acerca.Controls.Add(this.btnAyuda);
            this.Acerca.Controls.Add(this.pictureBox5);
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 560);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "\"Acerca de..\"";
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAcerca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAcerca.FlatAppearance.BorderSize = 0;
            this.btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.Color.White;
            this.btnAcerca.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.informacion;
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(-1, 200);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(205, 50);
            this.btnAcerca.TabIndex = 10;
            this.btnAcerca.Text = "   Acerca de..";
            this.btnAcerca.UseVisualStyleBackColor = false;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.servicio_al_cliente;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(-1, 144);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(205, 50);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "   Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pantallas_Sistema_Facturacion.Properties.Resources.logo;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(186, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // TabOpcionesMenu
            // 
            this.TabOpcionesMenu.BaseTabControl = this.TbnMenu;
            this.TabOpcionesMenu.Depth = 0;
            this.TabOpcionesMenu.Location = new System.Drawing.Point(373, 29);
            this.TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpcionesMenu.Name = "TabOpcionesMenu";
            this.TabOpcionesMenu.Size = new System.Drawing.Size(637, 29);
            this.TabOpcionesMenu.TabIndex = 1;
            this.TabOpcionesMenu.Text = "\"\"";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabOpcionesMenu);
            this.Controls.Add(this.PnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.TbnMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private MaterialSkin.Controls.MaterialTabControl TbnMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabPage Facturacion;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}