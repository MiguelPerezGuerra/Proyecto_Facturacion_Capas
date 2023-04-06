using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }
        DataTable DataTable = new DataTable();
        Cls_Empleados Empleado = new Cls_Empleados();

        private void llenarCombo()
        {
            cboRol.DataSource = Empleado.ConsultarRol(); // invocamos metodo de consulta de rol.
            cboRol.DisplayMember = "StrDescripcion"; // informacion del nombre del rol que se muestra al usuario.
            cboRol.ValueMember = "IdRolEmpleado"; // codigo interno que identifica este rol, este es el valor que se guarda luego en la tabla de empleados.
        }

        // consultamos por el id el empleado que vamos a modificar y mostramos la informacion consultada.
        private void LLenarCampos()
        {
            DataTable = Empleado.ConsultaEmpleado(IdEmpleado); // consultamos el empleado con un idempleado especifico.
            if (DataTable.Columns.Count > 0) // si retorna valores de consulta, asignamos los valores a los campos.
            {
                foreach (DataRow dr in DataTable.Rows)
                {
                    txtEmpleado.Text = dr[1].ToString();
                    txtDocEmpleado.Text = dr[2].ToString();
                    txtDirEmpleado.Text = dr[3].ToString();
                    txtTelEmpleado.Text = dr[4].ToString();
                    txtEmailEmpleado.Text = dr[5].ToString();
                    // selecciona en la lista de rol de acuerdo al valor que se tiene en la tabla tblempleados.
                    cboRol.SelectedValue = int.Parse(dr[6].ToString());
                    dtpFIngreso.Value = Convert.ToDateTime(dr[7].ToString());
                    dtpFRetiro.Value = Convert.ToDateTime(dr[8].ToString());
                    txtDatosAdicionales.Text = dr[9].ToString();
                }
            }
        }

        private bool Validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtEmpleado.Text) || string.IsNullOrWhiteSpace(txtEmpleado.Text))
            {
                MensajeError.SetError(txtEmpleado, "Debe ingresar el nombre del Cliente");
                txtEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDocEmpleado.Text) || string.IsNullOrWhiteSpace(txtDocEmpleado.Text))
            {
                MensajeError.SetError(txtDocEmpleado, "Debe ingresar el documento");
                txtDocEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocEmpleado, ""); }

            if (!esNumerico(txtDocEmpleado.Text))
            {
                MensajeError.SetError(txtDocEmpleado, "El Documento debe ser numerico");
                txtDocEmpleado.Focus();
                return false;
            }
            else { MensajeError.SetError(txtDocEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDirEmpleado.Text) || string.IsNullOrWhiteSpace(txtDirEmpleado.Text))
            {
                MensajeError.SetError(txtDirEmpleado, "Debe ingresar el nombre del Cliente");
                txtDirEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDirEmpleado, ""); }

            if (string.IsNullOrEmpty(txtTelEmpleado.Text) || string.IsNullOrWhiteSpace(txtTelEmpleado.Text))
            {
                MensajeError.SetError(txtTelEmpleado, "Debe ingresar el nombre del Cliente");
                txtTelEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtTelEmpleado, ""); }

            if (string.IsNullOrEmpty(txtEmailEmpleado.Text) || string.IsNullOrWhiteSpace(txtEmailEmpleado.Text))
            {
                MensajeError.SetError(txtEmailEmpleado, "Debe ingresar el nombre del Cliente");
                txtEmailEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtEmailEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDatosAdicionales.Text) || string.IsNullOrWhiteSpace(txtDatosAdicionales.Text))
            {
                MensajeError.SetError(txtDatosAdicionales, "Debe ingresar el nombre del Cliente");
                txtDatosAdicionales.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDatosAdicionales, ""); }

            return errorCampos;
        }

        private Boolean esNumerico(string num)
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
                Empleado.C_IdEmpleado = IdEmpleado;
                Empleado.C_StrNombre = txtEmpleado.Text;
                Empleado.C_NumDocumento = int.Parse(txtDocEmpleado.Text);
                Empleado.C_StrDireccion = txtDirEmpleado.Text;
                Empleado.C_StrTelefono = txtTelEmpleado.Text;
                Empleado.C_StrEmail = txtEmailEmpleado.Text;
                Empleado.C_IdRolEmpleado = int.Parse(cboRol.SelectedValue.ToString());
                Empleado.C_DtmIngreso = dtpFIngreso.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
                Empleado.C_DtmRetiro = dtpFRetiro.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
                Empleado.C_StrDatosAdicionales = txtDatosAdicionales.Text;
                Empleado.C_StrUsuarioModifico = "Javier";
                mensaje = Empleado.ActualizarEmpleado(); // invocamos el metodo de actualizar informacion del empleado.
                MessageBox.Show(mensaje);
            }
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            llenarCombo();
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR EMPLEADO";
                LLenarCampos();
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
