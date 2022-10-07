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

namespace Wpf_Samkova_PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ORazrabotchike_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработал данную программу студент группы ИСиП, Самкова К.С.");
        }

        private void Zakrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Beliy_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Siniy_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
