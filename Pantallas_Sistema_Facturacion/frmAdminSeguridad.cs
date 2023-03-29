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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void LLenarComboEmpleados()
        {
            DataTable dataTable= new DataTable();
            //AccesoDatos accesoDatos = new AccesoDatos();
            //dataTable = accesoDatos.CargarTabla("TBLEMPLEADO", ""); 

            cboEmpleado.DataSource= dataTable;
            cboEmpleado.DisplayMember= "strNombre";
            cboEmpleado.ValueMember= "IdEmpleado";
            //accesoDatos.CerrarBd();
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
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (Validar())
            {
                try
                {
                    //AccesoDatos accesoDatos = new AccesoDatos();
                    string Sentencia = $"Exec [actualizar_Seguridad] '{Convert.ToInt32(cboEmpleado.SelectedValue)}', '{txtUsuario.Text}', '{txtClave.Text}', '{DateTime.Now}', 'Javier' ";
                    //MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló inserción: " + ex);
                    actualizado = false;
                }
            }

            return actualizado;
        }

        // funcion que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            //AccesoDatos accesoDatos = new AccesoDatos();
            string Sentencia = $"Exec [Eliminar_Seguridad] '{Convert.ToInt32(cboEmpleado.SelectedValue)}' ";
            //MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        // funcion que permite consultar los datos de ingreso de un usuario
        public void Consultar()
        {
            DataTable dataTable= new DataTable();
            string Sentencia = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado= {cboEmpleado.SelectedValue.ToString()} ";
            //AccesoDatos accesoDatos = new AccesoDatos();
            //dataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
            if (dataTable.Rows.Count > 0)
            {
                txtUsuario.Text = dataTable.Rows[0]["StrUsuario"].ToString();
                txtClave.Text = dataTable.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El Usuario ni dispone de datos de ingreso");
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
            }
        }

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
