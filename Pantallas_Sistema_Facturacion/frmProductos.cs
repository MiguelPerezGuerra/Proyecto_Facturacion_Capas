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

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        public int IdProducto { get; set; }
        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos = new AccesoDatos();

        private void LLenarProducto()
        {
            if (IdProducto == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR PRODUCTO";
                string Sentencia = $"SELECT * FROM TBLPRODUCTO WHERE TBLPRODUCTO.IdProducto = '{IdProducto}' ";
                //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow row in DataTable.Rows)
                {
                    txtProducto.Text = row[1].ToString();
                    txtCodReferencia.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    cboCategoria.SelectedText = row[5].ToString();
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
            } else { MensajeError.SetError(txtProducto, ""); }

            if (string.IsNullOrEmpty(txtCodReferencia.Text) || string.IsNullOrWhiteSpace(txtCodReferencia.Text))
            {
                MensajeError.SetError(txtCodReferencia, "Debe ingresar el numero de Referencia");
            }
            else { MensajeError.SetError(txtCodReferencia, ""); }
            if (!esNumerico(txtCodReferencia.Text))
            {
                MensajeError.SetError(txtCodReferencia, "Debe ingresar valores Numericos");
            } else { MensajeError.SetError(txtCodReferencia, ""); }

            if (string.IsNullOrEmpty(txtPrecioCompra.Text) || string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar el Precio de Compra");
            }
            else { MensajeError.SetError(txtPrecioCompra, ""); }
            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar valores Numericos");
            }
            else { MensajeError.SetError(txtPrecioCompra, ""); }


            if (string.IsNullOrEmpty(txtPrecioVenta.Text) || string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar el Precio de Venta");
            }
            else { MensajeError.SetError(txtPrecioVenta, ""); }
            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar valores Numericos");
            }
            else { MensajeError.SetError(txtPrecioVenta, ""); }


            if (string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MensajeError.SetError(txtStock, "Debe ingresar la Cantidad de Stock");
            }
            else { MensajeError.SetError(txtStock, ""); }
            if (!esNumerico(txtStock.Text))
            {
                MensajeError.SetError(txtStock, "Debe ingresar valores Numericos");
            }
            else { MensajeError.SetError(txtStock, ""); }


            if (string.IsNullOrEmpty(txtRutaImagen.Text) || string.IsNullOrWhiteSpace(txtRutaImagen.Text))
            {
                MensajeError.SetError(txtRutaImagen, "Debe ingresar la Ruta de Imagen");
            }
            else { MensajeError.SetError(txtRutaImagen, ""); }


            if (string.IsNullOrEmpty(txtDatalle.Text) || string.IsNullOrWhiteSpace(txtDatalle.Text))
            {
                MensajeError.SetError(txtDatalle, "Debe ingresar los Detalles");
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

        public bool Guardar()
        {
            Boolean Actualizar = false;
            if (Validar())
            {
                try
                {
                    string sentencia = $"Exec actualizar_Producto {IdProducto}, '{txtProducto.Text}', '{txtCodReferencia.Text}', '{decimal.Parse(txtPrecioCompra.Text)}', '{decimal.Parse(txtPrecioVenta.Text)}', '{int.Parse(cboCategoria.Text)}', '{txtDatalle.Text}', '{txtRutaImagen.Text}', '{int.Parse(txtStock.Text)}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{"Javier"}'";
                    //MessageBox.Show(accesoDatos.EjecutarComando(sentencia));
                    Actualizar = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo inserción: " + ex);
                    Actualizar = false;
                }
            }

            return Actualizar;
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {           
            LLenarProducto();
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
