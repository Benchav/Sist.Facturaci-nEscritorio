using System;
using System.Data;
using System.Windows.Forms;
using BEL;
using BAL;

namespace alici
{
    public partial class frmNuevoProducto : Form
    {
        public InformationProduc info = new InformationProduc();
        public Operations opr = new Operations();

        //carga el grid
        public DataTable dt = new DataTable();

        public frmNuevoProducto()
        {
            InitializeComponent();
        }
        
        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            dt = opr.ViewProducto(info);
            dgProducto.DataSource = dt;

            dgProducto.Columns[0].Visible = false;
           

        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            //aqui hacemos la validacion de todos los texbox en 
            //el frm
            if (FrmValidacion.Validate(this))

                info.Nombre = txtNameProducto.Text;
            info.Descripcion = txtDescripcionP.Text;
            info.PrecioVenta = txtVenta.Text;


            int row = opr.InsertEmp(info);
            if (row > 0)
            {
                MessageBox.Show(
                      "se ha agregado su registro exitósamente",
                      "Información",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            //este es el metodo para agregar datos o refrescar 
            dt = opr.ViewProducto(info);
            dgProducto.DataSource = dt;

        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            LPCampos lpcampos = new LPCampos();
            lpcampos.BRCampos(this);
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Favaor Verificar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            VaalidacionLetras.Sololetras(e);   


        }

    }
}
    


   

    


