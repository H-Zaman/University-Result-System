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

namespace Project_RS_v1._0
{
    /// <summary>
    /// Interaction logic for adminPage_Subjects.xaml
    /// </summary>
    public partial class adminPage_Subjects : Page
    {
        public adminPage_Subjects()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            frameAdminSubjects.NavigationService.Navigate(new adminPage_SubjectsUpdate());
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            frameAdminSubjects.NavigationService.Navigate(new adminPage_SubjectsReg());
        }
    }
}
