using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }
        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos= new AccesoDatos();

        public void LLenar_Grid()
        {
            dgEmpleados.Rows.Clear();
            string Sentencia = $"SELECT IdEmpleado, strNombre, NumDocumento, StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro FROM TBLEMPLEADO";
           // DataTable= accesoDatos.EjecutarComandoDatos(Sentencia);
            foreach (DataRow dr in DataTable.Rows) { dgEmpleados.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]); }
        }
        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            LLenar_Grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                dgEmpleados.Rows.Clear();
                string Sentencia = $"SELECT IdEmpleado, strNombre, NumDocumento, StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro FROM TBLEMPLEADO WHERE strNombre LIKE '%{txtBuscar.Text}%' ";
               // DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow dr in DataTable.Rows) { dgEmpleados.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]); }
                
            }
            else { LLenar_Grid(); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados Empleado = new frmEmpleados();
            Empleado.IdEmpleado = 0;
            Empleado.ShowDialog();
            LLenar_Grid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show($"Seguro de borrar al empleado {dgEmpleados[1, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdEmpleado = Convert.ToInt32(dgEmpleados[0, posActual].Value.ToString());
                    string Sentencia = $"Exec Eliminar_Empleado '{IdEmpleado}'";
                    //string Mensaje = accesoDatos.EjecutarComando(Sentencia);
                    //MessageBox.Show(Mensaje);
                    LLenar_Grid();

                }
            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                frmEmpleados Empleado = new frmEmpleados();
                Empleado.IdEmpleado = int.Parse(dgEmpleados[0,posActual].Value.ToString());
                Empleado.ShowDialog();
                LLenar_Grid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
