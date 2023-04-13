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

namespace OrcamentoFacilWPF
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

        private void Button_MouseEvent(object sender, MouseEventArgs e)
        {
            if (e.RoutedEvent == Mouse.MouseEnterEvent)
                btnMaximizar.Content = new Image { Source = (DrawingImage)Application.Current.FindResource("imgMaximizarPressed") };
            else
                btnMaximizar.Content = new Image { Source = (DrawingImage)Application.Current.FindResource("imgMaximizar") };
        }

        private void Button_Pressed(object sender, MouseButtonEventArgs e)
        {
            if(e.RoutedEvent == Mouse.PreviewMouseDownEvent)
                btnMaximizar.Content = new Image { Source = (DrawingImage)Application.Current.FindResource("imgMaximizar") };
            else
                btnMaximizar.Content = new Image { Source = (DrawingImage)Application.Current.FindResource("imgMaximizarPressed") };
        }
    }
}
