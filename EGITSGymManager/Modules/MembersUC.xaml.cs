using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using EGITSGymManager.Forms;

namespace EGITSGymManager.Modules
{
    /// <summary>
    /// Interaction logic for AddMemberUC.xaml
    /// </summary>
    public partial class MembersUC : UserControl
    {
        private bool searchByName = false;
        private List<Member> Members;
        public MembersUC()
        {
            InitializeComponent();
        }

        private void LoadData(int id)
        {
            Members = new List<Member>
            {
                new Member
                {
                    Id = 1293,
                    Name = "waleed halaby",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01001392964"
                },
                new Member
                {
                    Id = 4522,
                    Name = "إسلام حسام الدين أحمد",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01001392964"
                },
                new Member
                {
                    Id = 6545,
                    Name = "هيثم محمد عبدالهادي",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01001392964"
                },
                new Member
                {
                    Id = 3549,
                    Name = "wael moataz",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01013880957"
                },
                new Member
                {
                    Id = 2458,
                    Name = "islam ahmed",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01011341944"
                },
                new Member
                {
                    Id = 874,
                    Name = "mai essam",
                    Gender = GenderEnum.Female,
                    MobileNumber = "01123584377"
                }
            };
            int itemsCount = Members.Count(x => x.Id == id);
            dgMembers.ItemsSource = Members.Where(x => x.Id == id);
            if (itemsCount == 0)
                MessageBox.Show("No members with the following Id.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LoadData(string name)
        {
            Members = new List<Member>
            {
                new Member
                {
                    Id = 1293,
                    Name = "waleed halaby",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01001392964"
                },
                new Member
                {
                    Id = 6545,
                    Name = "هيثم محمد عبدالهادي",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01001392964"
                },
                new Member
                {
                    Id = 4522,
                    Name = "إسلام حسام الدين أحمد",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01001392964"
                },
                new Member
                {
                    Id = 3549,
                    Name = "wael moataz",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01013880957"
                },
                new Member
                {
                    Id = 2458,
                    Name = "islam ahmed",
                    Gender = GenderEnum.Male,
                    MobileNumber = "01011341944"
                },
                new Member
                {
                    Id = 874,
                    Name = "mai essam",
                    Gender = GenderEnum.Female,
                    MobileNumber = "01123584377"
                }
            };
            int itemsCount = Members.Count(x => x.Name.Contains(name));
            dgMembers.ItemsSource = Members.Where(x => x.Name.Contains(name));
            if (itemsCount == 0)
                MessageBox.Show("No members with the following Name.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            if (!searchByName)
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void AddMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            AddMemberFrm form = new AddMemberFrm();
            form.ShowDialog();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(memberIDTB.Text))
            {
                if (!searchByName)
                    LoadData(int.Parse(memberIDTB.Text));
                else if (searchByName)
                    LoadData(memberIDTB.Text);
            }
        }

        private void InBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            MessageBox.Show("Member " + ID + " has been signed in.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OutBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            MessageBox.Show("Member " + ID + " has been signed out.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ViewBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            ViewMemberFrm form = new ViewMemberFrm(int.Parse(ID));
            form.ShowDialog();
        }

        private void EditBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            EditMemberFrm form = new EditMemberFrm(int.Parse(ID));
            form.ShowDialog();
        }

        private void DeleteBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete Member " + ID + " ?", "Message", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Member " + ID + " has been deleted successfully.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);                
            }
        }

        private void MembersUC_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!string.IsNullOrEmpty(memberIDTB.Text))
                {
                    if(!searchByName)
                        LoadData(int.Parse(memberIDTB.Text));
                    else if(searchByName)
                        LoadData(memberIDTB.Text);
                }
            }
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string) ((ComboBoxItem)searchByCB.SelectedItem).Content == "NAME")
            {
                searchByName = true;
            }
            else
            {
                searchByName = false;
            }
        }
    }
}
