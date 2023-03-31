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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        DataTable DataTable = new DataTable();
        Cls_Seguridad SeguridadEmpleado = new Cls_Seguridad();
        private void LLenarComboEmpleados()
        {
            // invocamos metodo de consulta de los empleados.
            cboEmpleado.DataSource = SeguridadEmpleado.ConsultarEmpleados();
            // informacion del nombre del empleado:
            cboEmpleado.DisplayMember = "StrNombre";
            // codigo internno que identifica idEmpleado.
            cboEmpleado.ValueMember = "IdEmpleado";
        }

        public void Consultar()
        {
            int IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
            DataTable = SeguridadEmpleado.ConsultaSeguridadEmpleado(IdEmpleado); // consultamos el empleado con un idempleado.
            if (DataTable.Rows.Count > 0)
            {
                txtUsuario.Text = DataTable.Rows[0].ToString();
                txtClave.Text = DataTable.Rows[1].ToString();
            }
            else
            {
                MessageBox.Show("No se le ha asignado usuario y clave a este Empleado");
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
            }
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MensajeError.SetError(txtUsuario, "Debe ingresar un valor de usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtUsuario, ""); }

            if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MensajeError.SetError(txtClave, "Debe ingresar un valor de Cédula");
                txtClave.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtClave, ""); }

            if (!esNumerico(txtClave.Text))
            {
                MensajeError.SetError(txtClave, "Debe ingresar valores numericos");
                txtClave.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtClave, ""); }

            return errorCampos;
        }

        // metodo para validar si los numeros son numericos
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

        // metodo que permite guardar los datos de ingreso a un usuario
        public void Guardar()
        {
            string mensaje = string.Empty;
            if (Validar())
            {

                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                SeguridadEmpleado.C_StrUsuario = txtUsuario.Text;
                SeguridadEmpleado.C_StrClave = txtClave.Text;
                SeguridadEmpleado.C_StrUsuarioModifico = "Javier";
                // invocamos el metodo de Actualizar.
                mensaje = SeguridadEmpleado.ActualizarSeguridadEmpleado();
                MessageBox.Show(mensaje);               
            }

            txtClave.Text = string.Empty;
            txtUsuario.Text = string.Empty;

        }

        // funcion que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            // preguntamos si esta seguro de borrar los registros.
            if (MessageBox.Show($"ESTA SEGURO DE BORRAR EL REGISTRO DE : \n {cboEmpleado.Text}", "COMFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // pasamos el parametro del ide empleado que vamos a modificar.
                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                // ejecutamos el borrado.
                string mensaje = SeguridadEmpleado.EliminarSeguridadEmpleados();
                if (mensaje != string.Empty)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show($"BORRANDO EL REGISTRO");
                }

                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
            }
        }

        // funcion que permite consultar los datos de ingreso de un usuario
        

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            LLenarComboEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edicion?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK) { this.Close(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
