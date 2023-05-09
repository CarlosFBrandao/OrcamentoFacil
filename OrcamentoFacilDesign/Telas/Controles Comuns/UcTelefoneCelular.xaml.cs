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
    /// Interação lógica para UcTelefoneCelular.xam
    /// </summary>
    public partial class UcTelefoneCelular : UserControl
    {
        public UcTelefoneCelular()
        {
            InitializeComponent();
        }

        private void txtTelefone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
                return;
            }
            else
            {
                string text = Utils.RetornaInteiro(txtTelefone.Text).ToString();
                if (e.Text == "\b" && text.Length > 0)
                {
                    if (text.Length > 0)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    txtTelefone.Text = text;
                    e.Handled = true;
                }
                if (text.Length >= Constantes.CELULAR_LENGTH)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtTelefone_txtCep_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                txtTelefone.SelectionStart = 0;
            }
        }

        private void txtTelefone_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (!Constantes.KeysNavegacao.Contains(e.Key))
            {
                string text = Utils.RetornaInteiro(txtTelefone.Text).ToString();

                if (text.Length == Constantes.TELEFONE_LENGTH)
                {
                    txtTelefone.Text = string.Format("{0:\\(00\\)\\ 0000\\-0000}", long.Parse(text));
                }
                else if (text.Length == Constantes.CELULAR_LENGTH)
                {
                    txtTelefone.Text = string.Format("{0:\\(00\\)\\ 00000\\-0000}", long.Parse(text));
                }
                else
                {
                    txtTelefone.Text = text;
                }
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
            }
        }
    }
}
