using OrcamentoFacilDesign.Telas;
using System.Windows;
using System.Windows.Input;

namespace OrcamentoFacilDesign
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string frmCliente = "frmCliente";
        private const string frmProduto = "frmProduto";
        private const string frmEmpresa = "frmEmpresa";
        private const string frmOrcamento = "frmOrcamento";

        private string TelaSelecionada;
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

        private void tabClientes_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (TelaSelecionada != frmCliente)
            {
                UcCadastroCliente ucCadCliente = new UcCadastroCliente();
                tabClientes.Content = ucCadCliente;
                TelaSelecionada = frmCliente;
            }
        }

        private void tabProdutos_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (TelaSelecionada != frmProduto)
            {
                UcCadastroProduto ucCadProduto = new UcCadastroProduto(this);
                tabProdutos.Content = ucCadProduto;
                TelaSelecionada = frmProduto;
            }
        }

        private void tabEmpresa_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (TelaSelecionada != frmEmpresa)
            {
                UcCadastroEmpresa ucCadastroEmpresa = new UcCadastroEmpresa();
                tabEmpresa.Content = ucCadastroEmpresa;
                TelaSelecionada = frmEmpresa;
            }
        }

        private void tabHome_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tabOrcamento_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (TelaSelecionada != frmOrcamento)
            {
                UcOrcamento ucOrcamento = new UcOrcamento();
                tabOrcamento.Content = ucOrcamento;
                TelaSelecionada = frmOrcamento;
            }
        }
    }
}
