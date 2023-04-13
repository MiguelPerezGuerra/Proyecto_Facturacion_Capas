using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }

        DataTable Dt = new DataTable();
        Cls_Facturas Facturas = new Cls_Facturas();

        public void LLenarGrid()
        {
            dgFacturas.Rows.Clear();
            Dt = Facturas.ConsultarFactura();
            foreach (DataRow dr in Dt.Rows ) { dgFacturas.Rows.Add(dr[0], dr[2], dr[3], dr[1], dr[4]); }
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnBorrar") //verificamos el boton que se presiono, verificando el nombre de la columna
            {
                int posActual = dgFacturas.CurrentRow.Index; //verifico cual fue la fila Seleccionada
                if (MessageBox.Show($"Seguro de borrar la Factura {dgFacturas[1, posActual].Value.ToString()}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Facturas.C_IdFactura = Convert.ToInt32(dgFacturas[0,posActual].Value.ToString());
                    string Mensaje = Facturas.EliminarFactura();
                    MessageBox.Show(Mensaje);
                    LLenarGrid();
                }

            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar") //verificamos si presiono el boton editar
            {
                int posActual = dgFacturas.CurrentRow.Index;  //tomamos la fila seleccionada
                frmFacturas frmFactura = new frmFacturas(); // instanciamos el formulario
                frmFactura.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString()); // pasamos al formulario de edicion el ID del cliente seleccionado
                frmFactura.ShowDialog(); // mostramos el formulario en forma modal
                LLenarGrid();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas frmFactura = new frmFacturas();
            frmFactura.IdFactura = 0;
            frmFactura.ShowDialog();
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                dgFacturas.Rows.Clear();
                Dt = Facturas.FiltroFactura(txtBuscar.Text);
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in Dt.Rows)
                    {
                        dgFacturas.Rows.Add(dr[0], dr[2], dr[3], dr[1], dr[4]);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron Registros para la Busqueda Solicitada");
                    LLenarGrid();
                }
                
            }
            else
            {
                LLenarGrid();
            }
            txtBuscar.Text = string.Empty;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
