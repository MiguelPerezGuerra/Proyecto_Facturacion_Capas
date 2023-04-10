using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }
        public int IdCategoria { get; set; }
        DataTable Dt = new DataTable();
        Cls_Categoria_Prod Categoria = new Cls_Categoria_Prod();

        private void LLenarCategoria()
        {
            Dt = Categoria.ConsultarCategoria(IdCategoria);
            if (Dt.Rows.Count > 0 )
            {
                foreach (DataRow row in Dt.Rows)
                {
                    txtCategoria.Text = row[1].ToString();
                }
            }
        }
        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {
                lblTitulo.Text = "INGRESE NUEVA CATEGORIA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CATEGORIA";
                LLenarCategoria();
            }
        }

        private bool Validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MensajeError.SetError(txtCategoria, "Debe ingresar el Nombre de Categoria");
                txtCategoria.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCategoria, ""); }

            return errorCampos;
        }

        public void Guardar()
        {
            string mensaje = string.Empty;
            if (Validar())
            {
                Categoria.C_IdCategoria = IdCategoria;
                Categoria.C_StrDescripcion = txtCategoria.Text;
                Categoria.C_StrUsuarioModifico = "Javier";
                mensaje = Categoria.ActualizarCategoria();
                MessageBox.Show(mensaje);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea Salir de la Edicion?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); 
            if (Rta == DialogResult.OK) { this.Close(); }
        }
    }
}
