using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmListaRoles : Form
    {
        public frmListaRoles()
        {
            InitializeComponent();
        }
        DataTable Dt = new DataTable();
        Cls_Roles Roles = new Cls_Roles();
        public void LLenarGrid()
        {
            dgRol.Rows.Clear();
            Dt = Roles.ConsultaRol();
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows) 
                { 
                    dgRol.Rows.Add(row[0].ToString(), row[1].ToString()); 
                }
            }
            else 
            { 
                MessageBox.Show("No se encontraron Registros"); 
            }
            

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
                Dt = Roles.FiltrarRol(txtBuscar.Text);
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow row in Dt.Rows) { dgRol.Rows.Add(row[0], row[1]); }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para la busqueda Solicitada");
                    LLenarGrid();
                }
                
            }
            else { LLenarGrid();}

            txtBuscar.Text = string.Empty;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados frmRol = new frmRolEmpleados();
            frmRol.IdRol = 0;
            frmRol.ShowDialog();
            LLenarGrid();
        }

        private void dgRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRol.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRol.CurrentRow.Index;
                if (MessageBox.Show($"Seguro de Borar el Rol {dgRol[1, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Roles.C_IdRolEmpleado = Convert.ToInt32(dgRol[0,posActual].Value.ToString());
                    string Mensaje = Roles.EliminarRol();
                    MessageBox.Show(Mensaje);
                    LLenarGrid();
                }
            }
            if (dgRol.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgRol.CurrentRow.Index;
                frmRolEmpleados frmRol = new frmRolEmpleados();
                frmRol.IdRol = int.Parse(dgRol[0, posActual].Value.ToString());
                frmRol.ShowDialog();
                LLenarGrid();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
