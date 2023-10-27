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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblAppName.Text = "La compañia de desarrollo es:" + Application.CompanyName;
            lblVersion.Text = "Ultima Version:" + Application.ProductVersion;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }
    }
}
