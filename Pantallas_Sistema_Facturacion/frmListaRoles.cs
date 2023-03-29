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
    public partial class frmListaRoles : Form
    {
        public frmListaRoles()
        {
            InitializeComponent();
        }
        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos = new AccesoDatos();
        public void LLenarGrid()
        {
            dgRol.Rows.Clear();
            string Sentencia = "SELECT * FROM TBLROLES";
            //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
            foreach (DataRow row in DataTable.Rows) { dgRol.Rows.Add(row[0], row[1]); }

        }
        private void frmListaRoles_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBuscar.Text) || !string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                dgRol.Rows.Clear();
                String Sentencia = $"SELECT * FROM TBLROLES WHERE StrDescripcion LIKE '%{txtBuscar.Text}%' ";
               // DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow row in DataTable.Rows) { dgRol.Rows.Add(row[0], row[1]); }
            }
            else { LLenarGrid();}
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados Rol = new frmRolEmpleados();
            Rol.IdRol = 0;
            Rol.ShowDialog();
            LLenarGrid();
        }

        private void dgRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRol.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRol.CurrentRow.Index;
                if (MessageBox.Show($"Seguro de Borar el Rol {dgRol[1, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdRol = Convert.ToInt32(dgRol[0,posActual].Value.ToString());
                    String Sentencia = $"DELETE TBLROLES WHERE IdRolEmpleado = {IdRol}";
                   // string Mensaje = accesoDatos.EjecutarComando(Sentencia);
                    //MessageBox.Show(Mensaje);
                    LLenarGrid();
                }
            }
            if (dgRol.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgRol.CurrentRow.Index;
                frmRolEmpleados Rol = new frmRolEmpleados();
                Rol.IdRol = int.Parse(dgRol[0, posActual].Value.ToString());
                Rol.ShowDialog();
                LLenarGrid();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
