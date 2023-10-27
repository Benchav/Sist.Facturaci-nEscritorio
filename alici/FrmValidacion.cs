using System.Windows.Forms;

namespace alici
{
    public class FrmValidacion
    {
        public static bool Validate (Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                        return false;
                    }
                }
            }

            return true;
        }
    }
}




