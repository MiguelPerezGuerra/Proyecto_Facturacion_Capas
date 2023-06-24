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
    public partial class frmPrincipal : MaterialForm
    {
        public void DisenoFormulario()
        {
            SkinManager.ColorScheme= new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue900, Accent.Green700, TextShade.WHITE);
        }
        public frmPrincipal()
        {
            InitializeComponent();
            DisenoFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AbrirForm(Form formHijo)
        {
            if(this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock= DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes listaCliente = new frmListaClientes();
            AbrirForm(listaCliente);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos listaProductos= new frmListaProductos();
            AbrirForm(listaProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmListaCategorias listaCategorias= new frmListaCategorias();
            AbrirForm(listaCategorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas listaFacturas= new frmListaFacturas();
            AbrirForm(listaFacturas);
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmListaEmpleados listaEmpleados= new frmListaEmpleados();
            AbrirForm(listaEmpleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmListaRoles listaRoles= new frmListaRoles();
            AbrirForm(listaRoles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad Seguridad= new frmAdminSeguridad();
            AbrirForm(Seguridad);
        }
        
    }
}
