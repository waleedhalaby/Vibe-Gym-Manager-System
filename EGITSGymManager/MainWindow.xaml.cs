using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using DomainModel.Helpers;
using EGITSGymManager.Forms;
using EGITSGymManager.Modules;

namespace EGITSGymManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var executablePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (true)
            {
                Intro intro = new Intro();
                intro.ShowDialog();
            }
            //else
            //{
            //    Configuration config = new Configuration();
            //    config.ShowDialog();
            //    //HomeUC homeUC = new HomeUC();
            //    //Grid.SetColumn(homeUC, 1);
            //    //Grid.SetRow(homeUC, 1);
            //    //((Grid)((Grid)Application.Current.MainWindow.Content).Children[1]).Children.Add(homeUC);
            //}
        }
    }
}
