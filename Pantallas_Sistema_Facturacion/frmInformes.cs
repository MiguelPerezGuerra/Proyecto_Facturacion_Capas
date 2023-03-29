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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        public int IdInforme { get; set; }
        private void frmEditarInformes_Load(object sender, EventArgs e)
        {
            if (IdInforme == 0)
            {
                lblTitulo.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR INFORME DE FACTURACIÓN";
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe Generado");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
