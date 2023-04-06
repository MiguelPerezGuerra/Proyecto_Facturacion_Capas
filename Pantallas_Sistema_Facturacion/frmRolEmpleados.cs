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
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }
        DataTable Dt = new DataTable();
        Cls_Roles Roles = new Cls_Roles();

        private void LLenarRol()
        {
            Dt = Roles.ConsultaRol(IdRol);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
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
                txtRol.Focus();
                errorCampos = false;
            }
            else { MensajeErrror.SetError(txtRol, ""); }

            return errorCampos;
        }

        public void Guardar()
        {
            string mensaje = string.Empty;

            if (Validar())
            {
                Roles.C_IdRolEmpleado = IdRol;
                Roles.C_StrDescripcion = txtRol.Text;
                mensaje = Roles.ActualizarRol();
                MessageBox.Show(mensaje);
            }

        }

        private void frmEditarRol_Load(object sender, EventArgs e)
        {
            if (IdRol == 0)
            {
                lblTitulo.Text = "INGRESE NUEVO ROL DE EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR ROL DE EMPLEADO";
                LLenarRol();
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
            Rta = MessageBox.Show("Seguro de Salir de la Edicion", "MENSAJE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK) { this.Close(); }
        }
    }
}
