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
    public partial class frmListaCategorias : Form
    {
        public frmListaCategorias()
        {
            InitializeComponent();
        }
        DataTable Dt = new DataTable();
        Cls_Categoria_Prod Categoria = new Cls_Categoria_Prod();

        public void LLenarGrid()
        {
            dgCategoria.Rows.Clear();
            Dt = Categoria.ConsultarCategoria();
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    dgCategoria.Rows.Add(row[0].ToString(), row[1].ToString());
                }
            }
            else
            {
                MessageBox.Show("No se encontraron Registros");
            }

        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                dgCategoria.Rows.Clear();
                Dt = Categoria.FiltrarEmpleado(txtBuscar.Text);
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow row in Dt.Rows) { dgCategoria.Rows.Add(row[0], row[1]); }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros por la busqueda solicitada");
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
            frmCategoriaProductos categoria = new frmCategoriaProductos();
            categoria.IdCategoria = 0;
            categoria.ShowDialog();
            LLenarGrid();
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.Columns[e.ColumnIndex].Name == "btnBorrar") //verificamos el boton que se presiono, verificando el nombre de la columna
            {
                int posActual = dgCategoria.CurrentRow.Index; //verifico cual fue la fila Seleccionada
                if (MessageBox.Show($"Seguro de borrar la Categoria {dgCategoria[1, posActual].Value.ToString()}" , "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
 
                    Categoria.C_IdCategoria = Convert.ToInt32(dgCategoria[0,posActual].Value.ToString());
                    string mensaje = Categoria.EliminarCategoria();
                    MessageBox.Show(mensaje);
                    LLenarGrid();
                }

            }
            if (dgCategoria.Columns[e.ColumnIndex].Name == "btnEditar") //verificamos si presiono el boton editar
            {
                int posActual = dgCategoria.CurrentRow.Index;  //tomamos la fila seleccionada
                frmCategoriaProductos frmCategoria = new frmCategoriaProductos(); // instanciamos el formulario
                frmCategoria.IdCategoria = int.Parse(dgCategoria[0, posActual].Value.ToString()); // pasamos al formulario de edicion el ID del cliente seleccionado
                frmCategoria.ShowDialog(); // mostramos el formulario en forma modal
                LLenarGrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
