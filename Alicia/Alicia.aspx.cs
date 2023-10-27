using System;
using System.Data;
using BAL;
using BEL;



namespace Alicia
{
    public partial class Alicia : System.Web.UI.Page
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public DataTable dt = new DataTable();
        public string gender;
        protected void Page_Load(object sender, EventArgs e)
        {

            dt = opr.ViewEmployees(info); 
            GdUsuario.DataSource = dt;

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            info.Nombre = txtUsua.Text;
            if (ckMasculino.Checked == true)
            {
                gender = "Masculino";
            }
            if (ckFemenino.Checked == true)
            {
                gender = "Femenino";

            }
            info.Genero = gender;
            info.Educacíon = DpEducacion.Text;
            info.NombreUsuario = txtUsuarion.Text;
            info.Contraseña = txtContraseña.Text;
            info.Direccion = txtDireccion.Text;
            int rows = opr.InsertEmp(info); 
            if (info.Contraseña != txtconfirmarcontra.Text)
            {
            
            
          
            
              
                
                  
                
              
                dt = opr.ViewEmployees(info);
                GdUsuario.DataSource = dt;

            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
