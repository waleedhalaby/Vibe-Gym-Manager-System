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
    /// Interaction logic for Contracts.xaml
    /// </summary>
    public partial class ContractsFrm : Window
    {
        private int _memberId;
        public ContractsFrm(int memberId, bool isEdit)
        {
            InitializeComponent();
            _memberId = memberId;
            AddContractBtn.Visibility = isEdit ? Visibility.Visible : Visibility.Hidden;                

            Contract contract = new Contract
            {
                Id = 11232,
                Deleted = false,
                Expired = false,
                Discount = 0,
                IssueDate = DateTime.Today.AddDays(-256).Date,
                ExpiryDate = DateTime.Today.Date,
                FreezeRemaining = 25,
                FreezeTaken = 0,
                MemberId = memberId,
                TrainerId = 1121,
                Trainer = new Employee
                {
                    Id = 1221,
                    Name = "Waleed Halaby"
                },
                TotalAmount = 12331.92m,
                PackageId = 1,
                Package = new Package
                {
                    Duration = 365,
                    FreezeDuration = 25,
                    Id = 1,
                    Name = "Life Coach",
                    NumberOfSessions = 24,
                    Price = 12000.00m
                },
                PaidAmount = 12300.00m,
                SessionsRemaining = 220,
                SessionsTaken = 0
            };
            issueDateTB.Text = contract.IssueDate.ToString("d");
            expiryDateTB.Text = contract.ExpiryDate.ToString("d");
            packageIDTB.Text = contract.Package.Id.ToString();
            packageNameTB.Text = contract.Package.Name;
            packageDurationTB.Text = contract.Package.Duration.ToString();
            packageFreezeDurationTB.Text = contract.Package.FreezeDuration.ToString();
            packageNoOfSessionsTB.Text = contract.Package.NumberOfSessions.ToString();
            packagePriceTB.Text = contract.Package.Price.ToString("N1");
            DiscountTB.Text = contract.Discount.ToString("N1");
            totalAmountTB.Text = contract.TotalAmount.ToString("N1");
            if (contract.PaidAmount.HasValue) paidAmountTB.Text = contract.PaidAmount.Value.ToString("N1");
            sessionsTakenTB.Text = contract.SessionsTaken.ToString();
            sessionsRemainingTB.Text = contract.SessionsRemaining.ToString();
            freezeTakenTB.Text = contract.FreezeTaken.ToString();
            freezeRemainingTB.Text = contract.FreezeRemaining.ToString();
            expiredTB.Text = contract.Expired.ToString();
            trainerIDTB.Text = contract.Trainer.Id.ToString();
            trainerNameTB.Text = contract.Trainer.Name;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void AddContractBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
