using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace alici
{
    public partial class frmCompra : Form
    {
        public InformationComp info = new InformationComp();
        public Operations opr = new Operations();

        //carga el grid
        public DataTable dt = new DataTable();
        public frmCompra()
       
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            dt = opr.ViewCompra(info);
            dgCompra.DataSource = dt;

            dgCompra.Columns[0].Visible = false;
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            //aqui hacemos la validacion de todos los texbox en 
            //el frm
            if (FrmValidacion.Validate(this))

                info.Categoria = cbCategoria.Text;
            info.Descripcion = txtDescripcionComp.Text;
            info.Precio = txtCompra.Text;
            info.FechaCompraX = Convert.ToDateTime(DataTCompra.Value.ToShortDateString());
            info.FechaExpiracionX = Convert.ToDateTime(DataTExpiracion.Value.ToShortDateString());

            int row = opr.InsertEmp(info);
            {
                MessageBox.Show(
                      "se ha agregado su registro exitósamente",
                      "Información",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            //este es el metodo para agregar datos o refrescar 
            dt = opr.ViewCompra(info);
            dgCompra.DataSource = dt;
        }

        private void dpExpiracion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LPCampos lpcampos = new LPCampos();
            lpcampos.BRCampos(this);
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <=47) || ( e.KeyChar >=58 && e.KeyChar <=255))
                    {
                MessageBox.Show("Solo numeros", "Verificar", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dpCompra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
