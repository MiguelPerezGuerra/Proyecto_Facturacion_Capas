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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable DataTable = new DataTable();
        //AccesoDatos Acceso = new AccesoDatos();

        public void LLenar_Grid()
        {
            dgClientes.Rows.Clear();
            string Sentencia = $"SELECT IdCliente, StrNombre, NumDocumento, StrTelefono FROM TBLCLIENTES"; 
           // DataTable = Acceso.EjecutarComandoDatos(Sentencia);

            foreach (DataRow dr in DataTable.Rows) { dgClientes.Rows.Add(dr[0], dr[1], dr[2], dr[3]); }
        }
        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            LLenar_Grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                dgClientes.Rows.Clear();
                string Sentencia = $"SELECT * FROM TBLCLIENTES WHERE strNombre LIKE '%{txtBuscar.Text}%'";
               // DataTable = Acceso.EjecutarComandoDatos(Sentencia);

                foreach (DataRow row in DataTable.Rows)
                {
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
                }
            }
            else
            {
                LLenar_Grid();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes Cliente = new frmClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            LLenar_Grid();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar") //verificamos el boton que se presiono, verificando el nombre de la columna
            {
                int posActual = dgClientes.CurrentRow.Index; //verifico cual fue la fila Seleccionada

                // monstramos un mensaje de confirmacion de borrado
                if(MessageBox.Show($"Seguro de borrar al cliente {dgClientes[1, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // invocamos el procedimiento almacenado de eliminar cliente y pasamos como parametro el id del cliente a borrar
                   int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString()); // leemos del datagrid el id del cliente a borrar

                    string Sentencia = $"Exec Eliminar_cliente '{IdCliente}' ";

                   // string Mensaje = Acceso.EjecutarComando(Sentencia);
                   // MessageBox.Show(Mensaje);
                    LLenar_Grid();
                }
                
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") //verificamos si presiono el boton editar
            {
                int posActual = dgClientes.CurrentRow.Index;  //tomamos la fila seleccionada
                frmClientes Cliente = new frmClientes(); // instanciamos el formulario
                Cliente.IdCliente= int.Parse(dgClientes[0, posActual].Value.ToString()); // pasamos al formulario de edicion el ID del cliente seleccionado
                Cliente.ShowDialog(); // mostramos el formulario en forma modal
                LLenar_Grid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
