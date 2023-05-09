using ControlesComuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrcamentoFacilDesign.Telas
{
    /// <summary>
    /// Interação lógica para UcCpfCnpj.xam
    /// </summary>
    public partial class UcCpfCnpj : UserControl
    {
        public UcCpfCnpj()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return txtCpfCnpj.Text; }
        }

        private void txtCpfCnpj_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
                return;
            }
            else
            {
                string text = Utils.RetornaInteiro(txtCpfCnpj.Text).ToString();
                if (e.Text == "\b" && text.Length > 0)
                {
                    if (text.Length > 0)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    txtCpfCnpj.Text = text;
                    e.Handled = true;
                }
                if (text.Length >= Constantes.CNPJ_LENGTH)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtCpfCnpj_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCpfCnpj.Text))
            {
                txtCpfCnpj.SelectionStart = 0;
            }
        }

        private void txtCpfCnpj_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (!Constantes.KeysNavegacao.Contains(e.Key))
            {
                string text = Utils.RetornaInteiro(txtCpfCnpj.Text).ToString();

                if (text.Length == Constantes.CPF_LENGTH)
                {
                    txtCpfCnpj.Text = string.Format("{0:000\\.000\\.000\\-00}", long.Parse(text));
                }
                else if (text.Length == Constantes.CNPJ_LENGTH)
                {
                    txtCpfCnpj.Text = string.Format("{0:00\\.000\\.000\\/0000\\-00}", long.Parse(text));
                }
                else
                {
                    txtCpfCnpj.Text = text;
                }
                txtCpfCnpj.SelectionStart = txtCpfCnpj.Text.Length;
            }

        }
    }
}
