using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alici
{
    public partial class MDIform : Form
    {
        public MDIform()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployees frmCustomerMDI = new frmEmployees();
            frmCustomerMDI.MdiParent = this;
            //este muestra el formulario en cuestion 
            frmCustomerMDI.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea salir de la aplicación?", 
                "Salir"
                , MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (dialogResult== DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(DialogResult== DialogResult.No)
            {
                this.Hide();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoProducto frmNproduc = new frmNuevoProducto();
            frmNproduc.MdiParent = this;
            //muestra el formulario en cuestion 
            frmNproduc.Show();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompra frmPCompra = new frmCompra();
            frmPCompra.MdiParent = this;
            //muestra el formulario en cuestion 
            frmPCompra.Show();
        }

        private void MDIform_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.VariableOne == "Usuario")
            {
                nuevoEmpleadosToolStripMenuItem.Visible = false;
                ayudaToolStripMenuItem.Visible = false;
            }
            else if (GlobalVariables.VariableOne == "Administrador")
            {
                nuevoEmpleadosToolStripMenuItem.Visible = true;
            }
            TLSU.Text = "Usuario Tipo:" + GlobalVariables.VariableOne;
        }
    }
}
