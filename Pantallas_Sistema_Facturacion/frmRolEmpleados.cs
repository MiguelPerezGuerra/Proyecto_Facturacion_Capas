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
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }
        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos = new AccesoDatos();

        private void LLenarRol()
        {
            if (IdRol == 0)
            {
                lblTitulo.Text = "INGRESE NUEVO ROL DE EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR ROL DE EMPLEADO";
                String Sentencia = $"SELECT * FROM TBLROLES WHERE IdRolEmpleado = '{IdRol}' ";
                //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow row in DataTable.Rows) 
                {
                    txtRol.Text = row[1].ToString();
                }
            }
        }

        private bool Validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtRol.Text) || string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MensajeErrror.SetError(txtRol, "Debe ingresar el Nombre del Rol");
            }
            else { MensajeErrror.SetError(txtRol, ""); }

            return errorCampos;
        }

        public bool Guardar()
        {
            Boolean Actualizado = false;

            if (IdRol == 0)
            {
                try
                {
                    if (Validar())
                    {
                        String Sentencia = $"INSERT INTO TBLROLES VALUES ('{txtRol.Text}') ";
                       // MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
                        Actualizado = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo inserción: " + ex);
                    Actualizado = false;
                }

            }
            else
            {
                try
                {
                    if (Validar())
                    {
                        String Sentencia = $"UPDATE TBLROLES SET StrDescripcion = '{txtRol.Text}' WHERE IdRolEmpleado = '{IdRol}' ";
                       // MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
                        Actualizado = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo inserción: " + ex);
                    Actualizado = false;
                }
            }
            

            return Actualizado;

        }

        private void frmEditarRol_Load(object sender, EventArgs e)
        {
           LLenarRol();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Seguro de Salir de la Edicion", "MENSAJE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK) { this.Close(); }
        }
    }
}
