using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios; // Anexamos la libreria de la clase.

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmLogin : Form
    {
        /* Funcionalidad: Por medio de este formulario realizamos el acceso ala base de datos con el fin de verificar si el usuario y la clave estan registrados en la tabla TBLSEGU
         */
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(TxtUsuario.Text) && !string.IsNullOrEmpty(TxtPasword.Text)) // validamos que el usuario y la clave no esten vacios.
            {
                // cleamos el objeto apartir de la clase ValidarUsuario.
                Validar_Usuario ObjValidar = new Validar_Usuario();
                // asognamos valores a los atributos.
                ObjValidar.C_StrUsuario = TxtUsuario.Text;
                ObjValidar.C_StrClave = TxtPasword.Text;
                ObjValidar.ValidarUsuario(); // ejecutamos el metodo de validacion.

                if (ObjValidar.C_IdEmpleado != 0)
                {
                    MessageBox.Show("Datos de verificacion Validados"); // mostramos mensaje.
                    frmPrincipal frmPpal = new frmPrincipal(); // creamos el objeto del formulario principal.
                    this.Hide(); // ocultamos el formulario login.
                    frmPpal.Show(); // mostramos el formulario principal.
                }
                else
                {
                    MessageBox.Show("Usuarios y Clave NO Encontrados");
                    TxtUsuario.Text = string.Empty;
                    TxtUsuario.Focus();
                    TxtPasword.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
