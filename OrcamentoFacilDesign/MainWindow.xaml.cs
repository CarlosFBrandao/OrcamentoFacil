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
using OrcamentoFacilDesign.Telas;

namespace OrcamentoFacilDesign
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnWindowClick(object sender, RoutedEventArgs e)
        {
            string btnClicado = ((FrameworkElement)sender).Name;
            if (btnClicado == "btnFechar")
            {
                Close();
            }
            else if(btnClicado == "btnMaximizar")
            {
                btnMaximizar.Visibility = Visibility.Hidden;
                btnRestaurarJanela.Visibility = Visibility.Visible;
                WindowState = WindowState.Maximized;
            }
            else if(btnClicado == btnRestaurarJanela.Name)
            {
                btnRestaurarJanela.Visibility = Visibility.Hidden;
                btnMaximizar.Visibility = Visibility.Visible;
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Minimized;
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void tabClientes_GotFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UcCadastroCliente ucCadCliente = new UcCadastroCliente();
            tabClientes.Content = ucCadCliente;
        }

        private void tabProdutos_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UcCadastroProduto ucCadProduto = new UcCadastroProduto();
            tabProdutos.Content = ucCadProduto;
        }
    }
}
