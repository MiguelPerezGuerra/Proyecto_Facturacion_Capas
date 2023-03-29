using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_Facturacion
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }
        public int IdCategoria { get; set; }
        DataTable DataTable = new DataTable();
        //AccesoDatos accesoDatos = new AccesoDatos();

        private void LLenarCategoria()
        {
            if (IdCategoria == 0)
            {
                lblTitulo.Text = "INGRESE NUEVA CATEGORIA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CATEGORIA";
                string Sentencia = $"SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD WHERE IdCategoria = {IdCategoria}";
                //DataTable = accesoDatos.EjecutarComandoDatos(Sentencia);
                foreach (DataRow dr in DataTable.Rows)
                {
                    
                    txtCategoria.Text = dr[1].ToString();
                }
            }
        }
        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            LLenarCategoria();
        }

        private bool Validar()
        {
            Boolean errorCampos = true;
            if (string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MensajeError.SetError(txtCategoria, "Debe ingresar el Nombre de Categoria");
            }
            else { MensajeError.SetError(txtCategoria, ""); }

            return errorCampos;
        }

        public bool Guardar()
        {
            Boolean Actualizado = false;
            if (Validar())
            {
                try
                {
                    string Sentencia = $"Exec actualizar_CategoriaProd {IdCategoria}, '{txtCategoria.Text}', '{DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")}', 'Javier' ";
                    //MessageBox.Show(accesoDatos.EjecutarComando(Sentencia));
                    Actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló inserción: " + ex);
                    Actualizado = false;
                }

            }
            return Actualizado;
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
