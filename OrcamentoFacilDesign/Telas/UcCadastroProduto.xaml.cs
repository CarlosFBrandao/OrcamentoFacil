using OrcamentoFacilDesign.Telas;
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

namespace OrcamentoFacilDesign
{
    /// <summary>
    /// Interação lógica para UcCadastroProduto.xam
    /// </summary>
    public partial class UcCadastroProduto : UserControl
    {
        private Window Owner;
        public UcCadastroProduto( Window windowOwner)
        {
            Owner = windowOwner;
            InitializeComponent();
        }

        private void txtValor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double value))
            {
                txtValor.Text = "";
            }
        }

        private void btnCadastrarUnd_Click(object sender, RoutedEventArgs e)
        {
            TelaCadUnidadeMedida cadUnidadeMedida = new TelaCadUnidadeMedida(Owner);
            cadUnidadeMedida.ShowDialog();
        }
    }
}
