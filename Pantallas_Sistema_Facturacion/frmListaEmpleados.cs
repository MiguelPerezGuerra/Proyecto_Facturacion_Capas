using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios; // anexamos la libreria de la clase.

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }
        DataTable Dt = new DataTable(); // datatable para consulta de datos.
        Cls_Empleados Empleado = new Cls_Empleados(); // instanciamos el objeto empleado.

        public void LLenar_Grid()
        {
            dgEmpleados.Rows.Clear(); // limpiamos los datos privios del datagrid
            Dt = Empleado.ConsultaEmpleado(); // llenamos al datatable con los datos retornados desde el metodo ConsultaEmpleado.
            if (Dt.Rows.Count > 0) // verifico si retotno valores
            {
                foreach (DataRow row in Dt.Rows) // esta instruccion permite recorrer todas las filas retornadas.
                {
                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()); // llenamos el grid.
                }
            }
            else
            {
                MessageBox.Show("No se encontraron Registros");
            }
        }
        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            LLenar_Grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty) // verifico si ingresaron texto a buscar.
            {
                dgEmpleados.Rows.Clear();
                Dt = Empleado.FiltrarEmpleado(txtBuscar.Text); // invocamos filtrar empleado con el texto a buscar como parametro.

                if (Dt.Rows.Count > 0) // si retorna valores los recorremos para llenar el gridview.
                {
                    foreach (DataRow row in Dt.Rows) 
                    { 
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()); 
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros por la busqueda Solicitada");
                    LLenar_Grid();
                }
                
            }
            else { LLenar_Grid(); }

            txtBuscar.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleado = new frmEmpleados();
            frmEmpleado.IdEmpleado = 0;
            frmEmpleado.ShowDialog();
            LLenar_Grid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show($"Seguro de borrar al empleado {dgEmpleados[1, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Empleado.C_IdEmpleado = Convert.ToInt32(dgEmpleados[0, posActual].Value.ToString());
                    string mensaje = Empleado.EliminarEmpleado();
                    MessageBox.Show(mensaje);
                    LLenar_Grid();

                }
            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                frmEmpleados frmEmpleado = new frmEmpleados();
                frmEmpleado.IdEmpleado = int.Parse(dgEmpleados[0,posActual].Value.ToString());
                frmEmpleado.ShowDialog();
                LLenar_Grid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
