﻿using System;
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
            Imy.Background = Brushes.Blue;
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
            Meny.Background = Brushes.White;
        }

        private void Siniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Blue;
        }

        private void Krasniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Red;
        }

        private void TipoSiniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Blue;
        }

        private void TipoKrasniy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.Red;
        }

        private void TipoBeliy_Click(object sender, RoutedEventArgs e)
        {
            Meny.Background = Brushes.White;
        }

        private void TipoZakrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ZadanieDva_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }
}
