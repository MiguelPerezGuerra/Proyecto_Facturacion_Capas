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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        public int IdCliente { get; set; }
        DataTable Dt = new DataTable();
        Cls_Cliente Cliente = new Cls_Cliente();
       
        private void LLenarCliente()
        {
            Dt = Cliente.ConsultarCliente(IdCliente);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    // llenamos los campos con el registro consultado
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }

        // funcion que permite validar los campos de los formularios
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del Cliente");
                errorCampos = false;
                txtNombre.Focus();
            }
            else { MensajeError.SetError(txtNombre, ""); }

            if (string.IsNullOrEmpty(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar el documento");
                errorCampos = false;
                txtDocumento.Focus();
            }
            else { MensajeError.SetError(txtDocumento, ""); }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
                txtDocumento.Focus();
                errorCampos = false;
                return false;
            }
            else { MensajeError.SetError(txtDocumento, ""); }

            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MensajeError.SetError(txtDireccion, "Debe ingresar la Direccion");
                errorCampos = false;
                txtDireccion.Focus();
            }
            else { MensajeError.SetError(txtDireccion, ""); }

            if (string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MensajeError.SetError(txtTelefono, "Debe ingresar un numero de Telefono");
                errorCampos = false;
                txtTelefono.Focus();
            }
            else { MensajeError.SetError(txtTelefono, ""); }
            if (!esNumerico(txtTelefono.Text))
            {
                MensajeError.SetError(txtTelefono, "Debe ingresar valor numerico");
                errorCampos = false;
                txtTelefono.Focus();
                return false;
            }
            else { MensajeError.SetError(txtTelefono, ""); }

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MensajeError.SetError(txtEmail, "Debe ingresar el Email");
                errorCampos = false;
                txtEmail.Focus();
            }
            else { MensajeError.SetError(txtEmail, ""); }

            return errorCampos;
        }



        // funcion que permite validar si un valor dado es numerico
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

        // funcion que permite el ingreso, retiro y actualizacion de la base de datos
        public void Guardar()
        {
            string mensaje = string.Empty;
            if (validar())
            {
                Cliente.C_IdCliente = IdCliente;
                Cliente.C_StrNombre = txtNombre.Text;
                Cliente.C_NumDocumento = int.Parse(txtDocumento.Text);
                Cliente.C_StrDireccion = txtDireccion.Text;
                Cliente.C_StrTelefono = txtTelefono.Text;
                Cliente.C_StrEmail = txtEmail.Text;
                Cliente.C_StrUsuarioModifica = "Javier";
                mensaje = Cliente.ActualizarCliente();
                MessageBox.Show(mensaje);
            }
        }
        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CLIENTE";
                LLenarCliente();
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
