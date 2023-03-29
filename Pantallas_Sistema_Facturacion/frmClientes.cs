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

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        public int IdCliente { get; set; }
        DataTable DataTable = new DataTable();
        //AccesoDatos Acceso = new AccesoDatos();
       
        private void LLenarCliente()
        {
            if(IdCliente == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CLIENTE";
                // actualizar el registo con el id pasado
                string Sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {IdCliente}"; // consulto registro del idcliente
               // DataTable = Acceso.EjecutarComandoDatos(Sentencia);
                foreach(DataRow row in DataTable.Rows) 
                {
                    // llenamos los campos con el registro consultado
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text= row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }
        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            LLenarCliente();
        }

        // funcion que permite validar los campos de los formularios
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del Cliente");
            }
            else { MensajeError.SetError(txtNombre, ""); }

            if (string.IsNullOrEmpty(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text) )
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar el documento");
            } 
            else { MensajeError.SetError(txtDocumento, ""); }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            else { MensajeError.SetError(txtDocumento, ""); }

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
        public bool Guardar() 
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    //AccesoDatos Acceso = new AccesoDatos();
                    string Sentencia = $"Exec [actualizar_Cliente] {IdCliente}, '{txtNombre.Text}', '{txtDocumento.Text}', '{txtDireccion.Text}', '{txtTelefono.Text}', '{txtEmail.Text}','Javier', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' ";
                    //MessageBox.Show(Acceso.EjecutarComando(Sentencia));
                    actualizado= true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló inserción: " + ex);
                    actualizado= false;
                }
            }
            return actualizado;
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
