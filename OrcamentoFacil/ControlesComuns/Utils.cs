using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesComuns
{
    public class Utils
    {
        public static void AceitarSomenteNumerosDouble(KeyPressEventArgs e, TextBox txtCampo)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtCampo.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        public static string RetornaInteiro(string input)
        {

            var digitos = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digitos.Append(c);
                }
            }

            return digitos.ToString();
        }
    }
}
