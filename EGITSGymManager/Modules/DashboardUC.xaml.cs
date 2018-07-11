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
using DomainModel.Models;

namespace EGITSGymManager.Modules
{
    /// <summary>
    /// Interaction logic for DashboardUC.xaml
    /// </summary>
    public partial class DashboardUC : UserControl
    {
        private List<Birthday> Birthdays;
        public DashboardUC()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Birthdays = new List<Birthday>
            {
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1222,
                    Name = "Waleed Halaby",
                    Gender = GenderEnum.Male,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 2319,
                    Name = "Ahmed Mostafa",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                },
                new Birthday{
                    Id = 1499,
                    Name = "Hadeer Emam",
                    Gender = GenderEnum.Female,
                    Type = "Employee"
                },
                new Birthday{
                    Id = 9349,
                    Name = "Islam Ahmed",
                    Gender = GenderEnum.Male,
                    Type = "Member"
                }
            };
            dgBirthdays.ItemsSource = Birthdays;
        }

        void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }

    public class Birthday
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
