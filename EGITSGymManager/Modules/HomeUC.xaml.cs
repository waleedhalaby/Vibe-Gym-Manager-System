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

namespace EGITSGymManager.Modules
{
    /// <summary>
    /// Interaction logic for HomeUC.xaml
    /// </summary>
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();

            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new DashboardUC());
            DashboardBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)((Grid)Application.Current.MainWindow.Content).Children[1]).Children.Remove(this);
            Intro intro = new Intro();
            intro.ShowDialog();
        }

        private void AddContractBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new AddContractUC());
            AddContractBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void MembersBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new MembersUC());
            MembersBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void NotificationBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new NotificationUC());
            NotificationBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void EmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new EmployeesUC());
            EmployeesBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void DashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new DashboardUC());
            DashboardBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void ReportsBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new ReportsUC());
            ReportsBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void PackagesBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new Packages());
            PackagesBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void TitlesBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveAllActiveButtons();
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(new Titles());
            TitlesBtn.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }

        private void RemoveAllActiveButtons()
        {
            PackagesBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            TitlesBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            ReportsBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            AddContractBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            MembersBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            EmployeesBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            DashboardBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
            NotificationBtn.Background = new SolidColorBrush(Color.FromRgb(61, 80, 102));
        }
    }
}
