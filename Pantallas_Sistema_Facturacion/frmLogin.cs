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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta = ""; // cramos la variable para controlar si encontro el usuario en la base de datos
            if(TxtUsuario.Text != string.Empty && TxtUsuario.Text != "") 
            {
                //AccesoDatos Acceso = new AccesoDatos(); // creamos el objeto con la clase acceso_datos
              //  Respuesta = Acceso.ValidarUsuario(TxtUsuario.Text, TxtPasword.Text);
                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido: " + Respuesta);
                    frmPrincipal frmPrincipal = new frmPrincipal(); // creamos el objeo del formulario frmprincipal
                    this.Hide(); // ocultamos el formulario login
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIOS Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text= string.Empty;
                    TxtUsuario.Focus();
                    TxtPasword.Text= string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y clave");
            }

        }
    }
}
