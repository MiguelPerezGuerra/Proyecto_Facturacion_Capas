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

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }

        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos = new AccesoDatos();
        public void LLenarGrid()
        {
            dgFacturas.Rows.Clear();
            string Sentencia = $"Exec [SpConsultaFactura]";
            //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
            foreach (DataRow dr in DataTable.Rows ) { dgFacturas.Rows.Add(dr[0], dr[2], dr[3], dr[1], dr[4]); }
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
                    int IdFactura = Convert.ToInt32(dgFacturas[0,posActual].Value.ToString());
                    string Sentencia = $"DELETE FROM TBLFACTURAS WHERE IdFactura = '{IdFactura}' ";

                   // string Mensaje = accesoDatos.EjecutarComando(Sentencia);
                    //MessageBox.Show(Mensaje);
                    LLenarGrid();
                }

            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar") //verificamos si presiono el boton editar
            {
                int posActual = dgFacturas.CurrentRow.Index;  //tomamos la fila seleccionada
                frmFacturas Factura = new frmFacturas(); // instanciamos el formulario
                Factura.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString()); // pasamos al formulario de edicion el ID del cliente seleccionado
                Factura.ShowDialog(); // mostramos el formulario en forma modal
                LLenarGrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas factura = new frmFacturas();
            factura.IdFactura = 0;
            factura.ShowDialog();
            LLenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                dgFacturas.Rows.Clear();
                string Sentencia = $"SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLFACTURA.DtmFecha, TBLFACTURA.NumValorTotal, TBLESTADO_FACTURA.StrDescripcion FROM TBLFACTURA INNER JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente INNER JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura WHERE TBLCLIENTES.StrNombre  LIKE '%{txtBuscar.Text}%'";
                //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);

                foreach (DataRow dr in DataTable.Rows)
                {
                    dgFacturas.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                }
            }
            else
            {
                LLenarGrid();
            }
        }
    }
}
