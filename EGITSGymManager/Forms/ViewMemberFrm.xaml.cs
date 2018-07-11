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
using DomainModel.Models;

namespace EGITSGymManager.Forms
{
    /// <summary>
    /// Interaction logic for ViewMemberFrm.xaml
    /// </summary>
    public partial class ViewMemberFrm : Window
    {
        private int _memberID;
        public ViewMemberFrm(int id)
        {
            InitializeComponent();
            _memberID = id;

            Member member = new Member
            {
                Id = id,
                Address = "43 dsmaakmdsamdakmamkdaakdsmskdmadkmadkamdkasmdadka, kdsmadksm, kdamska",
                Company = "amdmkkamakmdakakmdakmqi",
                DateOfBirth = DateTime.Today.Date,
                Gender = GenderEnum.Male,
                Image = "",
                JobTitle = "sMASMimIMadmdi",
                MobileNumber = "01001392964",
                Name = "mohamed ashraf",
                Nationality = "Egyptian",
                MaritalStatus = MaritalStatusEnum.Married,
                NationalId = "29212140102523",
                NumberOfChilds = 1
            };
            
            List<MemberAttendanceLog> Logs = new List<MemberAttendanceLog>
            {
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                },
                new MemberAttendanceLog
                {
                    Id = 1,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-3).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-3)
                },
                new MemberAttendanceLog
                {
                    Id = 2,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-2).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-2)
                },
                new MemberAttendanceLog
                {
                    Id = 4,
                    MemberId = id,
                    SignIn = DateTime.Now.AddDays(-1).AddHours(-2),
                    SignOut = DateTime.Now.AddDays(-1)
                },
                new MemberAttendanceLog
                {
                    Id = 7,
                    MemberId = id,
                    SignIn = DateTime.Now.AddHours(-2),
                    SignOut = DateTime.Now
                }
            };

            dgMemberLogs.ItemsSource = Logs;

            if(!string.IsNullOrEmpty(member.Image))
                memberImage.Source = new BitmapImage(new Uri(member.Image));
            memberNameTB.Text = member.Name;
            nationalIDTB.Text = member.NationalId;
            passportNumberTB.Text = member.PassportNumber;
            genderTB.Text = member.Gender.ToString();
            nationalityTB.Text = member.Nationality;
            maritalStatusTB.Text = member.MaritalStatus.ToString();
            if(member.NumberOfChilds.HasValue) numberOfChildsTB.Text = member.NumberOfChilds.Value.ToString();
            addressTB.Text = member.Address;
            telephoneTB.Text = member.TelephoneNumber;
            mobileTB.Text = member.MobileNumber;
            dobTB.Text = member.DateOfBirth.ToString("d");
            jobTitleTB.Text = member.JobTitle;
            comapanyTB.Text = member.Company;
            messageTB.Text = member.Message;
        }

        void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()+1).ToString();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ExtractBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowContractsBtn_Click(object sender, RoutedEventArgs e)
        {
            ContractsFrm form = new ContractsFrm(_memberID, false);
            form.ShowDialog();
        }
    }
}
