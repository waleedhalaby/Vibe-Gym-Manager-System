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

namespace EGITSGymManager.Forms
{
    /// <summary>
    /// Interaction logic for EditMemberFrm.xaml
    /// </summary>
    public partial class EditMemberFrm : Window
    {
        private int _memberID;
        public EditMemberFrm(int id)
        {
            InitializeComponent();
            _memberID = id;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
