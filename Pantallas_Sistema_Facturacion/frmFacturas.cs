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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }
        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos= new AccesoDatos();

        private void LLenarFactura()
        {
            if (IdFactura == 0)
            {
                lblTitulo.Text = "INGRESE NUEVA FACTURA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR FACTURA";
                string Sentencia = $"SELECT * FROM TBLFACTURA WHERE IdFactura = '{IdFactura}' ";
                //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow row in DataTable.Rows)
                {
                    txtIdFactura.Text = row[0].ToString();
                    cboCliente.SelectedText= row[2].ToString();
                    cboEmpleado.SelectedText= row[3].ToString();
                    txtDescuento.Text = row[4].ToString();
                    txtTotalIva.Text = row[5].ToString();
                    txtTotalFactura.Text = row[6].ToString();
                    dtpFechaRegistro.Value = Convert.ToDateTime(row[1].ToString());
                    cboEstadoFactura.Text = row[7].ToString();
                }
            }
        }

        public void LLenarProducto()
        {
            string Sentencia = $"SELECT * FROM TBLPRODUCTO";
            DataTable dt = new DataTable();
           // dt = accesoDatos.EjecutarComandoDatos(Sentencia);
            foreach (DataRow row in dt.Rows)
            {
                dgDetFact.Rows.Add(row[2], row[1], row[8], row[3], row[4], row[6]);
            }
        }

        private bool Validar()
        {
            Boolean errorCampos = true;

            if (string.IsNullOrEmpty(cboCliente.Text) || string.IsNullOrWhiteSpace(cboCliente.Text))
            {
                MensajeError.SetError(cboCliente, "Debe seleccionar un Cliente");
            } else { MensajeError.SetError(cboCliente, ""); }

            if (string.IsNullOrEmpty(cboEmpleado.Text) || string.IsNullOrWhiteSpace(cboEmpleado.Text))
            {
                MensajeError.SetError(cboEmpleado, "Debe Seleccionar un Empleado");
            } else { MensajeError.SetError(cboEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar el valor de Descuento");
            } else { MensajeError.SetError(txtDescuento, ""); }
            if (!esNumerico(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar valores Numericos");
            } else { MensajeError.SetError(txtDescuento, ""); }

            if (string.IsNullOrEmpty(txtTotalFactura.Text) || string.IsNullOrWhiteSpace(txtTotalFactura.Text))
            {
                MensajeError.SetError(txtTotalFactura, "Debe ingredar el valor del Total");
            } else {MensajeError.SetError(txtTotalFactura, ""); }
            if (!esNumerico(txtTotalFactura.Text))
            {
                MensajeError.SetError(txtTotalFactura, "Debe ingresar valores Numericos");
            }
            else { MensajeError.SetError(txtTotalFactura, ""); }

            if (string.IsNullOrEmpty(txtTotalIva.Text) || string.IsNullOrWhiteSpace(txtTotalIva.Text))
            {
                MensajeError.SetError(txtTotalIva, "Debe ingresar el valor del Iva");
            } else { MensajeError.SetError(txtTotalIva, ""); }
            if (!esNumerico(txtTotalIva.Text))
            {
                MensajeError.SetError(txtTotalIva, "Debe ingresar valores Numericos");
            }
            else { MensajeError.SetError(txtTotalIva, ""); }

            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Guardar()
        {
            Boolean Actualizado = false;
            if (Validar())
            {
                try
                {
                    string Sentencia = $" Exec actualizar_Factura {IdFactura}, '{dtpFechaRegistro.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}', {Convert.ToInt32(cboCliente.Text)}, {Convert.ToInt32(cboEmpleado.Text)}, {Convert.ToDouble(txtDescuento.Text)}, {Convert.ToDouble(txtTotalIva.Text)}, {Convert.ToDouble(txtTotalFactura.Text)}, {Convert.ToInt32(cboEstadoFactura.Text)}, '{DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")}', 'Javier' ";
                   // MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
                    Actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo inserción: " + ex);
                    Actualizado = false;
                }
            }
            
            return Actualizado;
        }


        private void frmEditarFacturas_Load(object sender, EventArgs e)
        {
            LLenarFactura();
            LLenarProducto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea Salir de la Edicion?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK) { this.Close(); }
        }

        
    }
}
