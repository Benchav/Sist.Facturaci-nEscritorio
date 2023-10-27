using System.Windows.Forms;

namespace alici
{
    public class VaalidacionLetras
    {
        public static void SoloNumeros(KeyPressEventArgs pe)
        {
            if (char.IsDigit(pe.KeyChar))
            
        {
         pe.Handled = false;
        }
                else if(char.IsControl(pe.KeyChar))
        {
            pe.Handled = false;
        }
        else
        {
                pe.Handled = true;
                MessageBox.Show("Solo numeros", "Favaor Verificar");
            }
    }

        public static void Sololetras(KeyPressEventArgs pe)
        {
            if (char.IsLetter(pe.KeyChar))

            {
                pe.Handled = false;
            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else if (char.IsSeparator(pe.KeyChar))
            {
                pe.Handled = true;
            }
            else
            {
                pe.Handled = true;
                MessageBox.Show("Solo letras", "Favaor Verificar");
                
            }
        }
    }
}


             
               
 


