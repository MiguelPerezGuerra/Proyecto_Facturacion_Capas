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
    public partial class frmListaCategorias : Form
    {
        public frmListaCategorias()
        {
            InitializeComponent();
        }
        DataTable DataTable = new DataTable();
        ///AccesoDatos AccesoDatos = new AccesoDatos();

        public void LLenarGrid()
        {
            dgCategoria.Rows.Clear();
            string Sentencia = $"SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";
           // DataTable = AccesoDatos.EjecutarComandoDatos(Sentencia);
            foreach (DataRow row in DataTable.Rows) { dgCategoria.Rows.Add(row[0], row[1]); }

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
                string Sentencia = $"SELECT  IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD WHERE StrDescripcion LIKE '%{txtBuscar.Text}%'";
              //  DataTable = AccesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow row in DataTable.Rows) { dgCategoria.Rows.Add(row[0], row[1]); }
            }
            else { LLenarGrid(); }
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
 
                    int IdCategoria = Convert.ToInt32(dgCategoria[0,posActual].Value.ToString());
                    string Sentencia = $"Exec Eliminar_CategoriaProducto {IdCategoria}";
                   // string Mensaje = AccesoDatos.EjecutarComando(Sentencia);
                    // MessageBox.Show(Mensaje);
                    LLenarGrid();
                }

            }
            if (dgCategoria.Columns[e.ColumnIndex].Name == "btnEditar") //verificamos si presiono el boton editar
            {
                int posActual = dgCategoria.CurrentRow.Index;  //tomamos la fila seleccionada
                frmCategoriaProductos Categoria = new frmCategoriaProductos(); // instanciamos el formulario
                Categoria.IdCategoria = int.Parse(dgCategoria[0, posActual].Value.ToString()); // pasamos al formulario de edicion el ID del cliente seleccionado
                Categoria.ShowDialog(); // mostramos el formulario en forma modal
                LLenarGrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
