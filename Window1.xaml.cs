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

namespace Wpf_Samkova_PR2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Holst.DefaultDrawingAttributes.Width = ((Polzuok)sender).Value;
        }

        private void Krasniy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Siniy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Chorniy_Click(object sender, RoutedEventArgs e)
        {
            Holst.DefaultDrawingAttributes.Color = Colors.Black;
        }
    }
}
