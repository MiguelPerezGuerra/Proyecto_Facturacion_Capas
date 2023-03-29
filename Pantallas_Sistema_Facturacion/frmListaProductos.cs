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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        //AccesoDatos accesoDatos= new AccesoDatos();

        public void LLenarGrid()
        {
            dgProductos.Rows.Clear();
            string Sentencia = "SELECT TBLPRODUCTO.IdProducto, TBLPRODUCTO.StrCodigo, TBLPRODUCTO.StrNombre, TBLPRODUCTO.IdCategoria, TBLPRODUCTO.NumPrecioCompra, TBLPRODUCTO.NumStock FROM TBLPRODUCTO";
            //dataTable= accesoDatos.EjecutarComandoDatos(Sentencia);
            foreach (DataRow row in dataTable.Rows)
            {
                dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }
        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text) || !string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                dgProductos.Rows.Clear();
                string Sentencia = $"SELECT TBLPRODUCTO.IdProducto, TBLPRODUCTO.StrCodigo, TBLPRODUCTO.StrNombre, TBLCATEGORIA_PROD.StrDescripcion, TBLPRODUCTO.NumPrecioCompra, TBLPRODUCTO.NumStock FROM TBLPRODUCTO INNER JOIN TBLCATEGORIA_PROD ON TBLPRODUCTO.IdCategoria=TBLCATEGORIA_PROD.IdCategoria WHERE TBLPRODUCTO.StrNombre LIKE '%{txtBuscar.Text}%' ";
                //dataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow row in dataTable.Rows)
                {
                    dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
            }
            else
            {
                LLenarGrid();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos producto= new frmProductos();
            producto.IdProducto = 0;
            producto.ShowDialog();
            LLenarGrid();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if(MessageBox.Show($"Seguro de Borrar el Producto {dgProductos[2, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    int IdProducto = Convert.ToInt32(dgProductos[0, posActual].Value.ToString());
                    string Sentencia = $"Exec Eliminar_Producto {IdProducto}";
                    //string Mensaje = accesoDatos.EjecutarComando(Sentencia);
                    //MessageBox.Show(Mensaje);
                    LLenarGrid();
                }
            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                frmProductos producto= new frmProductos();
                producto.IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString());
                producto.ShowDialog();
                LLenarGrid();

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
