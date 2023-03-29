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

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }
        DataTable DataTable=new DataTable();
        //AccesoDatos accesoDatos = new AccesoDatos();

        private void llenarEmpleado()
        {
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR EMPLEADO";
                string Sentencia = $"SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = '{IdEmpleado}' ";
              //  DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);

                foreach (DataRow dr in DataTable.Rows)
                {
                    txtEmpleado.Text = dr[1].ToString();
                    txtDocEmpleado.Text = dr[2].ToString();
                    txtDirEmpleado.Text = dr[3].ToString();
                    txtTelEmpleado.Text = dr[4].ToString();
                    txtEmailEmpleado.Text = dr[5].ToString();
                    cboRol.SelectedText= dr[6].ToString();
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
            }
            else { MensajeError.SetError(txtEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDocEmpleado.Text) || string.IsNullOrWhiteSpace(txtDocEmpleado.Text))
            {
                MensajeError.SetError(txtDocEmpleado, "Debe ingresar el documento");
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
            }
            else { MensajeError.SetError(txtDirEmpleado, ""); }

            if (string.IsNullOrEmpty(txtTelEmpleado.Text) || string.IsNullOrWhiteSpace(txtTelEmpleado.Text))
            {
                MensajeError.SetError(txtTelEmpleado, "Debe ingresar el nombre del Cliente");
            }
            else { MensajeError.SetError(txtTelEmpleado, ""); }

            if (string.IsNullOrEmpty(txtEmailEmpleado.Text) || string.IsNullOrWhiteSpace(txtEmailEmpleado.Text))
            {
                MensajeError.SetError(txtEmailEmpleado, "Debe ingresar el nombre del Cliente");
            }
            else { MensajeError.SetError(txtEmailEmpleado, ""); }

            if (string.IsNullOrEmpty(txtDatosAdicionales.Text) || string.IsNullOrWhiteSpace(txtDatosAdicionales.Text))
            {
                MensajeError.SetError(txtDatosAdicionales, "Debe ingresar el nombre del Cliente");
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

        public bool Guardar()
        {
            Boolean Actualizar = false;
            if (Validar())
            {
                try
                {
                    string Sentencia = $"Exec actualizar_Empleado {IdEmpleado}, '{txtEmpleado.Text}', '{txtDocEmpleado.Text}', '{txtDirEmpleado.Text}', '{txtTelEmpleado.Text}', '{txtEmailEmpleado.Text}', '{Convert.ToInt32(cboRol.Text)}', '{dtpFIngreso.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}', '{dtpFRetiro.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}', '{txtDatosAdicionales.Text}',  '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 'Javier' ";
                   // MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
                    Actualizar = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló insercion: " + ex);
                    Actualizar= false;
                }
            }
            return Actualizar;
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            llenarEmpleado();
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
