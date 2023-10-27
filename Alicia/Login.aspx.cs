using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BEL;

namespace Alicia
{
    public partial class Login : System.Web.UI.Page

    {
        public Information info = new Information();
        public Operations opr = new Operations();

        //varible global para el usuario 

        //en este agregamos una variable para controlar el tipo de usuario
        public string uType;
        // este objeto se comprueba las credenciales
        // de login pero se debe usar un data table que almacene datos
        //y compruebe
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            info.NombreUsuario = txtNusuario.Text;
            info.Contraseña = txtContraseña.Text;

            //en este punto se compara la contraseña con el 
            //almacenado en la base de datos

          //  dt = opr.Login(info);

            //if (dt.Rows.Count > 0)

            {
               

            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
          
        }
    }
}