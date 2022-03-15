using FitnessClub.Data;
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

namespace FitnessClub.Element
{
    /// <summary>
    /// Interaction logic for Osnova.xaml
    /// </summary>
    public partial class Osnova : Page
    {
        public Osnova()
        {
            InitializeComponent();
            LvOsnova.ItemsSource = Model1.Init().Services.ToList();
        }
        private void SwitchToPerehod(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Perehod("ooo"));
        }
        private void SwitchToInfo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Info("ooo"));
        }

        private void SwithToOcenka(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Ocenka("ooo"));
        }
    }
}
