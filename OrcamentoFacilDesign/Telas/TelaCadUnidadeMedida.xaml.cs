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
using System.Windows.Shapes;

namespace OrcamentoFacilDesign
{
    /// <summary>
    /// Lógica interna para TelaCadUnidadeMedida.xaml
    /// </summary>
    public partial class TelaCadUnidadeMedida : Window
    {
        public TelaCadUnidadeMedida(Window windowOwner)
        {
            Owner = windowOwner;
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnWindowClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
