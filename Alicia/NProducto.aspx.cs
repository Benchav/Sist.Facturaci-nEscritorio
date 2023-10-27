using BAL;
using BEL;
using System;
using System.Data;

namespace Alicia
{
    public partial class NProducto : System.Web.UI.Page
    {
        public InformationProduc info = new InformationProduc();
        public Operations opr = new Operations();

        //carga el grid
        public DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            info.Nombre = txtNProducto.Text;
            info.Descripcion = txtDescripcion.Text;
            info.PrecioVenta = txtPrecio.Text;
            int rows = opr.InsertEmp(info);
        }
    }
}