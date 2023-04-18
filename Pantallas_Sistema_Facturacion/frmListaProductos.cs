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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }
        DataTable Dt = new DataTable();
        Cls_Productos Productos = new Cls_Productos();

        public void LLenarGrid()
        {
            dgProductos.Rows.Clear();
            Dt = Productos.ConsultarProducto();
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    dgProductos.Rows.Add(row[0], row[2], row[1], row[5], row[3], row[8]);
                }
            }
            else 
            {
                MessageBox.Show("No se encontraron Registros");
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
                Dt = Productos.FiltrarProducto(txtBuscar.Text);
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow row in Dt.Rows)
                    {
                        dgProductos.Rows.Add(row[0], row[2], row[1], row[5], row[3], row[8]);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron Registros para la busqueda Solicitado");
                    LLenarGrid();
                }
                
                
            }
            else
            {
                LLenarGrid();
            }
            txtBuscar.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos frmProducto= new frmProductos();
            frmProducto.IdProducto = 0;
            frmProducto.ShowDialog();
            LLenarGrid();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if(MessageBox.Show($"Seguro de Borrar el Producto {dgProductos[2, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    Productos.C_IdProducto = Convert.ToInt32(dgProductos[0, posActual].Value.ToString());
                    string mensaje = Productos.EliminarProducto();
                    MessageBox.Show(mensaje);
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
