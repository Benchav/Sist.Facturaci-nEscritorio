using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace alici
{
    public partial class frmEmployees : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public string gender;

        //se usa para cargar los datos al datagrid
        public DataTable dt = new DataTable();


        public frmEmployees()
        {
            InitializeComponent();
            {

                // Agrega aquí los controles que desees validar en tu formulario
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {

            //data grib  
            dt = opr.ViewEmployees(info);
            dgEmployees.DataSource = dt;

            dgEmployees.Columns[0].Visible = false;
            dgEmployees.Columns[6].Visible = false;
            dgEmployees.Columns[7].Visible = false;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //aqui hacemos la validacion de todos los texbox en 
            //el frm
            if (FrmValidacion.Validate(this))

                //se realiza la validaxion del nombre y del genero masculino o femenino
                info.Nombre = txtName.Text;
            if (rbMale.Checked == true)
            {
                gender = "Masculino";
            }
            if (rbFemale.Checked == true)
            {
                gender = "Femenino";

            }
            info.Genero = gender;
            info.FechaNacimiento = Convert.ToDateTime(dpDOB.Value.ToShortDateString());
            info.Direccion = txtAddress.Text;
            info.Educacíon = cbEducation.Text;
            info.NombreUsuario = txtUserName.Text;
            info.Contraseña = txtPassword.Text;

            if (info.Contraseña != txtConfirmaPassword.Text)
            {
                MessageBox.Show("las contraseñas no coinciden, favor revisar!",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int row = opr.InsertEmp(info);
                if (row > 0)
                {
                    MessageBox.Show(
                        "se ha agregado su registro exitósamente",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
               
            }
            //este es el metodo para agregar datos o refrescar 
            dt = opr.ViewEmployees(info);
            dgEmployees.DataSource = dt;
        }


        private void btnLimpiarCl_Click(object sender, EventArgs e)
        {
            LPCampos lpcampos = new LPCampos();
            lpcampos.BRCampos(this);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Obtener el código ASCII de la tecla presionada
            int keyCode = (int)e.KeyChar;

            // Verificar si el código ASCII está dentro del rango de letras (mayúsculas o minúsculas) con o sin tilde,
            // o es la barra espaciadora o la tecla "Eliminar" (Delete)
            if ((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || IsLetterWithAccent(keyCode) || keyCode == 32 || keyCode == 8)
            {
                // Permitir la entrada de letras con o sin tilde, la barra espaciadora y la tecla "Eliminar"
                e.Handled = false;
            }
            else
            {
                // Bloquear la entrada de cualquier otro carácter no permitido
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsLetterWithAccent(int keyCode)
        {
            // Verificar si el código ASCII corresponde a una letra con tilde
            return ((keyCode >= 192 && keyCode <= 214) || (keyCode >= 216 && keyCode <= 246) || (keyCode >= 248 && keyCode <= 255));
        }



        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64)
               || (e.KeyChar >= 91 && e.KeyChar <= 96)
              // || (e.KeyChar >= 123 && e.KeyChar <= 255)
                || (e.KeyChar >= 123 && e.KeyChar <=155 )
                 || (e.KeyChar >= 166 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", " Favor Verificar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
