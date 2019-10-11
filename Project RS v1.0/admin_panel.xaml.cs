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

namespace Project_RS_v1._0
{
    /// <summary>
    /// Interaction logic for admin_panel.xaml
    /// </summary>
    public partial class admin_panel : Window
    {
        public admin_panel()
        {
            InitializeComponent();
            frame_admin.NavigationService.Navigate(new adminPage_Student());
        }

        private void buttonStudent_Click(object sender, RoutedEventArgs e)
        {
            frame_admin.NavigationService.Navigate(new adminPage_Student());
        }

        private void buttonTeacher_Click(object sender, RoutedEventArgs e)
        {
            frame_admin.NavigationService.Navigate(new adminPage_Teacher());
        }

        private void buttonSubject_Click(object sender, RoutedEventArgs e)
        {
            frame_admin.NavigationService.Navigate(new adminPage_Subjects());
        }

        private void buttonMarks_Click(object sender, RoutedEventArgs e)
        {
            frame_admin.NavigationService.Navigate(new adminPage_Marks());
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
