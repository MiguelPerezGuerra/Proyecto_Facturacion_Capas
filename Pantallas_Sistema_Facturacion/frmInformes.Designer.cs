namespace Pantallas_Sistema_Facturacion
{
    partial class frmInformes
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
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboInforme = new System.Windows.Forms.ComboBox();
            this.lblInforme = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rdbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnlButtonSalir = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlButtonSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(305, 37);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(574, 184);
            this.dtpFechaFinal.MinDate = new System.DateTime(2023, 2, 18, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(126, 20);
            this.dtpFechaFinal.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(327, 184);
            this.dtpFechaInicio.MinDate = new System.DateTime(2023, 2, 18, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(126, 20);
            this.dtpFechaInicio.TabIndex = 15;
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Location = new System.Drawing.Point(629, 119);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(151, 21);
            this.cboOrdenar.TabIndex = 14;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.Depth = 0;
            this.lblOrdenar.Enabled = false;
            this.lblOrdenar.Hint = "";
            this.lblOrdenar.Location = new System.Drawing.Point(534, 119);
            this.lblOrdenar.MaxLength = 32767;
            this.lblOrdenar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.PasswordChar = '\0';
            this.lblOrdenar.SelectedText = "";
            this.lblOrdenar.SelectionLength = 0;
            this.lblOrdenar.SelectionStart = 0;
            this.lblOrdenar.Size = new System.Drawing.Size(89, 23);
            this.lblOrdenar.TabIndex = 13;
            this.lblOrdenar.TabStop = false;
            this.lblOrdenar.Text = "Ordenar Por:";
            this.lblOrdenar.UseSystemPasswordChar = false;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Enabled = false;
            this.lblFechaFinal.Hint = "";
            this.lblFechaFinal.Location = new System.Drawing.Point(492, 181);
            this.lblFechaFinal.MaxLength = 32767;
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.PasswordChar = '\0';
            this.lblFechaFinal.SelectedText = "";
            this.lblFechaFinal.SelectionLength = 0;
            this.lblFechaFinal.SelectionStart = 0;
            this.lblFechaFinal.Size = new System.Drawing.Size(76, 23);
            this.lblFechaFinal.TabIndex = 12;
            this.lblFechaFinal.TabStop = false;
            this.lblFechaFinal.Text = "Fecha Final";
            this.lblFechaFinal.UseSystemPasswordChar = false;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Enabled = false;
            this.lblFechaInicio.Hint = "";
            this.lblFechaInicio.Location = new System.Drawing.Point(241, 181);
            this.lblFechaInicio.MaxLength = 32767;
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.PasswordChar = '\0';
            this.lblFechaInicio.SelectedText = "";
            this.lblFechaInicio.SelectionLength = 0;
            this.lblFechaInicio.SelectionStart = 0;
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 23);
            this.lblFechaInicio.TabIndex = 11;
            this.lblFechaInicio.TabStop = false;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.UseSystemPasswordChar = false;
            // 
            // cboInforme
            // 
            this.cboInforme.FormattingEnabled = true;
            this.cboInforme.Location = new System.Drawing.Point(327, 121);
            this.cboInforme.Name = "cboInforme";
            this.cboInforme.Size = new System.Drawing.Size(162, 21);
            this.cboInforme.TabIndex = 10;
            // 
            // lblInforme
            // 
            this.lblInforme.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblInforme.Depth = 0;
            this.lblInforme.Enabled = false;
            this.lblInforme.Hint = "";
            this.lblInforme.Location = new System.Drawing.Point(161, 119);
            this.lblInforme.MaxLength = 32767;
            this.lblInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.PasswordChar = '\0';
            this.lblInforme.SelectedText = "";
            this.lblInforme.SelectionLength = 0;
            this.lblInforme.SelectionStart = 0;
            this.lblInforme.Size = new System.Drawing.Size(160, 23);
            this.lblInforme.TabIndex = 9;
            this.lblInforme.TabStop = false;
            this.lblInforme.Text = "SELECCIONE INFORME";
            this.lblInforme.UseSystemPasswordChar = false;
            // 
            // rdbEnPantalla
            // 
            this.rdbEnPantalla.AutoSize = true;
            this.rdbEnPantalla.Checked = true;
            this.rdbEnPantalla.Depth = 0;
            this.rdbEnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEnPantalla.Location = new System.Drawing.Point(309, 242);
            this.rdbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEnPantalla.Name = "rdbEnPantalla";
            this.rdbEnPantalla.Ripple = true;
            this.rdbEnPantalla.Size = new System.Drawing.Size(98, 30);
            this.rdbEnPantalla.TabIndex = 17;
            this.rdbEnPantalla.TabStop = true;
            this.rdbEnPantalla.Text = "En Pantalla";
            this.rdbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rdbPdf
            // 
            this.rdbPdf.AutoSize = true;
            this.rdbPdf.Depth = 0;
            this.rdbPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPdf.Location = new System.Drawing.Point(449, 242);
            this.rdbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPdf.Name = "rdbPdf";
            this.rdbPdf.Ripple = true;
            this.rdbPdf.Size = new System.Drawing.Size(50, 30);
            this.rdbPdf.TabIndex = 18;
            this.rdbPdf.Text = "Pdf";
            this.rdbPdf.UseVisualStyleBackColor = true;
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Depth = 0;
            this.rdbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbExcel.Location = new System.Drawing.Point(544, 242);
            this.rdbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rdbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Ripple = true;
            this.rdbExcel.Size = new System.Drawing.Size(62, 30);
            this.rdbExcel.TabIndex = 19;
            this.rdbExcel.Text = "Excel";
            this.rdbExcel.UseVisualStyleBackColor = true;
            // 
            // pnlButtonSalir
            // 
            this.pnlButtonSalir.Controls.Add(this.btnSalir);
            this.pnlButtonSalir.Location = new System.Drawing.Point(522, 289);
            this.pnlButtonSalir.Name = "pnlButtonSalir";
            this.pnlButtonSalir.Size = new System.Drawing.Size(103, 36);
            this.pnlButtonSalir.TabIndex = 21;
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
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Gray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(161, 352);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(619, 141);
            this.materialDivider1.TabIndex = 22;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.Depth = 0;
            this.btnGenerar.Icon = null;
            this.btnGenerar.Location = new System.Drawing.Point(309, 289);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Primary = true;
            this.btnGenerar.Size = new System.Drawing.Size(144, 36);
            this.btnGenerar.TabIndex = 23;
            this.btnGenerar.Text = "GENERAR INFORME";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.pnlButtonSalir);
            this.Controls.Add(this.rdbExcel);
            this.Controls.Add(this.rdbPdf);
            this.Controls.Add(this.rdbEnPantalla);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cboOrdenar);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.cboInforme);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformes";
            this.Load += new System.EventHandler(this.frmEditarInformes_Load);
            this.pnlButtonSalir.ResumeLayout(false);
            this.pnlButtonSalir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblOrdenar;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFechaFinal;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblFechaInicio;
        private System.Windows.Forms.ComboBox cboInforme;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblInforme;
        private MaterialSkin.Controls.MaterialRadioButton rdbEnPantalla;
        private MaterialSkin.Controls.MaterialRadioButton rdbPdf;
        private MaterialSkin.Controls.MaterialRadioButton rdbExcel;
        private System.Windows.Forms.Panel pnlButtonSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
    }
}