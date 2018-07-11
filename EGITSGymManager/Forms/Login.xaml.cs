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
using EGITSGymManager.Modules;

namespace EGITSGymManager.Forms
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeUC homeUC = new HomeUC();
            Grid.SetColumn(homeUC, 1);
            Grid.SetRow(homeUC, 1);
            ((Grid)((Grid)Application.Current.MainWindow.Content).Children[1]).Children.Add(homeUC);
            Close();
        }
    }
}
