using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ControlesComuns;

namespace OrcamentoFacilDesign.Telas
{
    /// <summary>
    /// Interação lógica para UcCep.xam
    /// </summary>
    public partial class UcCep : UserControl
    {
        public UcCep()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return txtCep.Text; }
        }

        private void txtCpfCnpj_txtCep_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
                return;
            }
            else
            {
                string text = Utils.RetornaInteiro(txtCep.Text).ToString();
                if (e.Text == "\b" && text.Length > 0)
                {
                    if (text.Length > 0)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    txtCep.Text = text;
                    e.Handled = true;
                }
                if (text.Length >= Constantes.CEP_LENGTH)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtCpfCnpj_txtCep_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text))
            {
                txtCep.SelectionStart = 0;
            }
        }

        private void txtCpfCnpj_txtCep_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (!Constantes.KeysNavegacao.Contains(e.Key))
            {
                string text = Utils.RetornaInteiro(txtCep.Text).ToString();
                if (txtCep.Text.Length == Constantes.CEP_LENGTH)
                {
                    txtCep.Text = string.Format("{0:00000\\-000}", long.Parse(text));
                    e.Handled = true;
                    txtCep.SelectionStart = txtCep.Text.Length;
                }
            }
        }
    }
}
