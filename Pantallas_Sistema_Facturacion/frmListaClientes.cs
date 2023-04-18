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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable Dt = new DataTable();
        Cls_Cliente Cliente = new Cls_Cliente();

        public void LLenar_Grid()
        {
            dgClientes.Rows.Clear();
            Dt = Cliente.ConsultarCliente();
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow dr in Dt.Rows) { dgClientes.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString()); }
            }
            else
            {
                MessageBox.Show("No se encontraron Registros");
            }

            
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
                Dt = Cliente.FiltrarCliente(txtBuscar.Text);
                if (Dt.Rows.Count > 0) 
                {
                    foreach (DataRow row in Dt.Rows)
                    {
                        dgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron Registros para la busqueda Solicitada");
                    LLenar_Grid();
                }
            }
            else
            {
                LLenar_Grid();
            }
            txtBuscar.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes frmCliente = new frmClientes();
            frmCliente.IdCliente = 0;
            frmCliente.ShowDialog();
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
                   Cliente.C_IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString()); // leemos del datagrid el id del cliente a borrar
                    string mensaje = Cliente.EliminarCliente();
                    MessageBox.Show(mensaje);
                    LLenar_Grid();
                }
                
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") //verificamos si presiono el boton editar
            {
                int posActual = dgClientes.CurrentRow.Index;  //tomamos la fila seleccionada
                frmClientes frmCliente = new frmClientes(); // instanciamos el formulario
                frmCliente.IdCliente= int.Parse(dgClientes[0, posActual].Value.ToString()); // pasamos al formulario de edicion el ID del cliente seleccionado
                frmCliente.ShowDialog(); // mostramos el formulario en forma modal
                LLenar_Grid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
