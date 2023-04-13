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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }
        DataTable Dt = new DataTable();
        Cls_Facturas Facturas = new Cls_Facturas();

        private void LLenarFactura()
        {
            Dt = Facturas.ConsultarFactura(IdFactura);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    txtIdFactura.Text = row[0].ToString();
                    cboCliente.SelectedValue = int.Parse(row[2].ToString());
                    cboEmpleado.SelectedValue = int.Parse(row[3].ToString()); 
                    txtDescuento.Text = row[4].ToString();
                    txtTotalIva.Text = row[5].ToString();
                    txtTotalFactura.Text = row[6].ToString();
                    dtpFechaRegistro.Value = Convert.ToDateTime(row[1].ToString());
                    cboEstadoFactura.SelectedValue = int.Parse(row[7].ToString());
                }
            }
        }

        public void LLenarProducto()
        {
            DataTable DtProductos = new DataTable();
            DtProductos = Facturas.ConsultarProductos();
            foreach (DataRow row in DtProductos.Rows)
            {
                dgDetFact.Rows.Add(row[2], row[1], row[8], row[3], row[4], row[6]);
            }
        }

        public void LLenarCboCliente()
        {
            cboCliente.DataSource = Facturas.ConsultarClientes();
            cboCliente.DisplayMember = "StrNombre";
            cboCliente.ValueMember = "IdCliente";
        }

        public void LLenarCboEmpleado()
        {
            cboEmpleado.DataSource = Facturas.ConsultarEmpleados();
            cboEmpleado.DisplayMember = "StrNombre";
            cboEmpleado.ValueMember = "IdEmpleado";
        }

        public void LLenarCboEstado()
        {
            cboEstadoFactura.DataSource = Facturas.ConsultarEstadoFactura();
            cboEstadoFactura.DisplayMember = "StrDescripcion";
            cboEstadoFactura.ValueMember = "IdEstadoFactura";
        }

        private bool Validar()
        {
            Boolean errorCampos = true;

            if (string.IsNullOrEmpty(cboCliente.Text) || string.IsNullOrWhiteSpace(cboCliente.Text))
            {
                MensajeError.SetError(cboCliente, "Debe seleccionar un Cliente");
                errorCampos = false;
                cboCliente.Focus();
            } else { MensajeError.SetError(cboCliente, ""); }

            if (string.IsNullOrEmpty(cboEmpleado.Text) || string.IsNullOrWhiteSpace(cboEmpleado.Text))
            {
                MensajeError.SetError(cboEmpleado, "Debe Seleccionar un Empleado");
                errorCampos = false;
                cboEmpleado.Focus();
            } else { MensajeError.SetError(cboEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar el valor de Descuento");
                errorCampos = false;
                txtDescuento.Focus();
            } else { MensajeError.SetError(txtDescuento, ""); }
            if (!esNumerico(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtDescuento.Focus();
            } else { MensajeError.SetError(txtDescuento, ""); }

            if (string.IsNullOrEmpty(txtTotalFactura.Text) || string.IsNullOrWhiteSpace(txtTotalFactura.Text))
            {
                MensajeError.SetError(txtTotalFactura, "Debe ingredar el valor del Total");
                errorCampos = false;
                txtTotalFactura.Focus();
            } else {MensajeError.SetError(txtTotalFactura, ""); }
            if (!esNumerico(txtTotalFactura.Text))
            {
                MensajeError.SetError(txtTotalFactura, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtTotalFactura.Focus();
            }
            else { MensajeError.SetError(txtTotalFactura, ""); }

            if (string.IsNullOrEmpty(txtTotalIva.Text) || string.IsNullOrWhiteSpace(txtTotalIva.Text))
            {
                MensajeError.SetError(txtTotalIva, "Debe ingresar el valor del Iva");
                errorCampos = false;
                txtTotalIva.Focus();
            } else { MensajeError.SetError(txtTotalIva, ""); }
            if (!esNumerico(txtTotalIva.Text))
            {
                MensajeError.SetError(txtTotalIva, "Debe ingresar valores Numericos");
                errorCampos = false;
                txtTotalIva.Focus();
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

        public void Guardar()
        {
            string mensaje = string.Empty;
            if (Validar())
            {
                Facturas.C_IdFactura = IdFactura;
                Facturas.C_DtmFecha = dtpFechaRegistro.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
                Facturas.C_IdCliente = int.Parse(cboCliente.SelectedValue.ToString());
                Facturas.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                Facturas.C_NumDescuento = Single.Parse(txtDescuento.Text); 
                Facturas.C_NumImpuesto = Single.Parse(txtTotalIva.Text); 
                Facturas.C_NumValorTotal = Single.Parse(txtTotalFactura.Text);
                Facturas.C_IdEstado = int.Parse(cboEstadoFactura.SelectedValue.ToString());
                Facturas.C_StrUsuarioModifica = "Javier";
                mensaje = Facturas.ActualizarFactura();
                MessageBox.Show(mensaje);

            }
                
        }


        private void frmEditarFacturas_Load(object sender, EventArgs e)
        {
            LLenarProducto();
            LLenarCboCliente();
            LLenarCboEmpleado();
            LLenarCboEstado();
            if (IdFactura == 0)
            {
                lblTitulo.Text = "INGRESE NUEVA FACTURA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR FACTURA";
                LLenarFactura();
            }
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
