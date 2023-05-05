using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Net.Mime.MediaTypeNames;

namespace OrcamentoFacilDesign
{
    /// <summary>
    /// Interação lógica para UcCadastroCliente.xam
    /// </summary>
    public partial class UcCadastroCliente : UserControl
    {
        private const int CPF_LENGTH = 11;
        private const int CNPJ_LENGTH = 14;
        private const int CEP_LENGTH = 8;
        private Key[] KeysNavegacao = { Key.Left, Key.Right, Key.Up, Key.Down, Key.Back, Key.Delete };

        public UcCadastroCliente()
        {
            InitializeComponent();
            PopulaDataGrid();
        }

        private void PopulaDataGrid()
        {
            List<Teste> lista = new List<Teste>();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(new Teste
                {
                    Codigo = i,
                    Nome = "Nomeaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa " + i,
                    Telefone = "123" + i
                });
            }
            listViewClientes.ItemsSource = lista;
        }

        private void txtCpfCnpj_txtCep_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
                return;
            }
            if (((FrameworkElement)sender).Name == "txtCpfCnpj")
            {
                string text = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (e.Text == "\b" && text.Length > 0)
                {
                    if (text.Length > 0)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    txtCpfCnpj.Text = text;
                    e.Handled = true;
                }
                if (text.Length >= CNPJ_LENGTH)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                string text = txtCep.Text.Replace("-", "").Replace(".", "");
                if (e.Text == "\b" && text.Length > 0)
                {
                    if (text.Length > 0)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    txtCep.Text = text;
                    e.Handled = true;
                }
                if (text.Length >= CEP_LENGTH)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtCpfCnpj_txtCep_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((FrameworkElement)sender).Name == "txtCpfCnpj")
            {
                if (string.IsNullOrEmpty(txtCpfCnpj.Text))
                {
                    txtCpfCnpj.SelectionStart = 0;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCep.Text))
                {
                    txtCep.SelectionStart = 0;
                }
            }
        }

        private void txtCpfCnpj_txtCep_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!KeysNavegacao.Contains(e.Key))
                {
                    if (((FrameworkElement)sender).Name == "txtCpfCnpj")
                    {

                        string text = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");

                        if (text.Length == CPF_LENGTH)
                        {
                            txtCpfCnpj.Text = string.Format("{0:000\\.000\\.000\\-00}", long.Parse(text));
                        }
                        else if (text.Length == CNPJ_LENGTH)
                        {
                            txtCpfCnpj.Text = string.Format("{0:00\\.000\\.000\\/0000\\-00}", long.Parse(text));
                        }
                        else
                        {
                            txtCpfCnpj.Text = text;
                        }
                        txtCpfCnpj.SelectionStart = txtCpfCnpj.Text.Length;
                    }
                    else
                    {
                        string text = txtCep.Text.Replace("-", "").Replace(".", "");
                        if (txtCep.Text.Length == CEP_LENGTH)
                        {
                            txtCep.Text = string.Format("{0:00000\\-000}", long.Parse(text));
                            e.Handled = true;
                            txtCep.SelectionStart = txtCep.Text.Length;
                        }
                    }
                }
            }
            catch (Exception)
            {
                e.Handled = true;
            }
        }

        public class Teste
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
        }
    }
}
