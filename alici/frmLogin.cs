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
    public partial class frmLogin : Form
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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Favor de completar los campos");
                return;

            }

            info.NombreUsuario = txtUsername.Text;
            info.Contraseña = txtPassword.Text;

            //en este punto se compara la contraseña con el 
            //almacenado en la base de datos

            dt = opr.Login(info);

            if (dt.Rows.Count>0)
             
            {
                this.Hide();
             
             //  MDIform mdiForm = new MDIform();
               // mdiForm.Show();
               //este estaba de primero 

                uType = dt.Rows[0][8].ToString().Trim();
                if (uType == "A")
                {
                    GlobalVariables.VariableOne = "Administrador";
                    this.Hide();
                  //  frmEmployees frmEmployees = new frmEmployees();
                    //frmEmployees.Show();
                    
                    MDIform mdiForm = new MDIform();
                   mdiForm.Show(); //y este es el segundo
                }
                else
                {
                    GlobalVariables.VariableOne = "Usuario";
                    this.Hide();
                    MDIform mdiForm = new MDIform();
                    mdiForm.Show();

                }
            }
            else
            {
                MessageBox.Show("Por favor verificar su usario y contraseña," +
                    " hay un error",
                    "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
