using System.Windows.Forms;

namespace alici
{
    public class LPCampos
    {
        public void BRCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
                
                }
            }
        }
    }


