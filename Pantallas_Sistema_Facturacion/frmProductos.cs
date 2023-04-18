using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        public int IdProducto { get; set; }
        DataTable Dt = new DataTable();
        Cls_Productos Productos = new Cls_Productos();

        private void LLenarCboCategoria()
        {
            cboCategoria.DataSource = Productos.ConsultarCategoria();
            cboCategoria.DisplayMember = "StrDescripcion";
            cboCategoria.ValueMember = "IdCategoria";
        }
        private void LLenarProducto()
        {
            Dt = Productos.ConsultarProducto(IdProducto);
            if (Dt.Rows.Count > 0 )
            {
                foreach (DataRow row in Dt.Rows)
                {
                    txtProducto.Text = row[1].ToString();
                    txtCodReferencia.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    cboCategoria.SelectedValue = int.Parse(row[5].ToString());
                    txtDatalle.Text = row[6].ToString();
                    txtRutaImagen.Text = row[7].ToString();
                    txtStock.Text = row[8].ToString();
                }
            }
                
        }

        private bool Validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MensajeError.SetError(txtProducto, "Debe ingresar el nombre del Producto");
                errorCampos = false;
                txtProducto.Focus();
            } else { MensajeError.SetError(txtProducto, ""); }

            if (string.IsNullOrEmpty(txtCodReferencia.Text) || string.IsNullOrWhiteSpace(txtCodReferencia.Text))
            {
                MensajeError.SetError(txtCodReferencia, "Debe ingresar el numero de Referencia");
                errorCampos = false;
                txtCodReferencia.Focus();
            }
            else { MensajeError.SetError(txtCodReferencia, ""); }
            if (!esNumerico(txtCodReferencia.Text))
            {
                MensajeError.SetError(txtCodReferencia, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtCodReferencia.Focus();
            } else { MensajeError.SetError(txtCodReferencia, ""); }

            if (string.IsNullOrEmpty(txtPrecioCompra.Text) || string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar el Precio de Compra");
                errorCampos = false;
                txtPrecioCompra.Focus();
            }
            else { MensajeError.SetError(txtPrecioCompra, ""); }
            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtPrecioCompra.Focus();
            }
            else { MensajeError.SetError(txtPrecioCompra, ""); }


            if (string.IsNullOrEmpty(txtPrecioVenta.Text) || string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar el Precio de Venta");
                errorCampos = false;
                txtPrecioVenta.Focus();
            }
            else { MensajeError.SetError(txtPrecioVenta, ""); }
            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtPrecioVenta.Focus();
            }
            else { MensajeError.SetError(txtPrecioVenta, ""); }


            if (string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MensajeError.SetError(txtStock, "Debe ingresar la Cantidad de Stock");
                errorCampos = false;
                txtStock.Focus();
            }
            else { MensajeError.SetError(txtStock, ""); }
            if (!esNumerico(txtStock.Text))
            {
                MensajeError.SetError(txtStock, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtStock.Focus();
            }
            else { MensajeError.SetError(txtStock, ""); }


            if (string.IsNullOrEmpty(txtRutaImagen.Text) || string.IsNullOrWhiteSpace(txtRutaImagen.Text))
            {
                MensajeError.SetError(txtRutaImagen, "Debe ingresar la Ruta de Imagen");
                errorCampos = false;
                txtRutaImagen.Focus();
            }
            else { MensajeError.SetError(txtRutaImagen, ""); }


            if (string.IsNullOrEmpty(txtDatalle.Text) || string.IsNullOrWhiteSpace(txtDatalle.Text))
            {
                MensajeError.SetError(txtDatalle, "Debe ingresar los Detalles");
                errorCampos = false;
                txtDatalle.Focus();
            }
            else { MensajeError.SetError(txtDatalle, ""); }

            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Guardar()
        {
            string mensaje = string.Empty;
            if (Validar())
            {
                Productos.C_IdProducto = IdProducto;
                Productos.C_StrNombre = txtProducto.Text;
                Productos.C_StrCodigo = txtCodReferencia.Text;
                Productos.C_NumPrecioCompra = Single.Parse(txtPrecioCompra.Text);
                Productos.C_NumPrecioVenta = Single.Parse(txtPrecioVenta.Text);
                Productos.C_IdCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                Productos.C_StrDetalle = txtDatalle.Text;
                Productos.C_StrFoto = txtRutaImagen.Text;
                Productos.C_NumStock = int.Parse(txtStock.Text);
                Productos.C_StrUsuarioModifica = "Javier";
                mensaje = Productos.ActualizarProducto();
                MessageBox.Show(mensaje);
            }

        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            LLenarCboCategoria();
            if (IdProducto == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR PRODUCTO";
                LLenarProducto();
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
            Rta = MessageBox.Show("Desea salir de la Edicion?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK) { this.Close(); }
        }

        
    }
}
