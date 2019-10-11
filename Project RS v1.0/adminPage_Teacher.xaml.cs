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
    /// Interaction logic for adminPage_Teacher.xaml
    /// </summary>
    public partial class adminPage_Teacher : Page
    {
        public adminPage_Teacher()
        {
            InitializeComponent();
        }

        private void teach_reg_btn_Click(object sender, RoutedEventArgs e)
        {
            frameAdminTeacher.NavigationService.Navigate(new adminPage_TeacherReg());
        }

        private void teach_up_btn_Click(object sender, RoutedEventArgs e)
        {
            frameAdminTeacher.NavigationService.Navigate(new adminPage_TeacherUpdate());
        }
    }
}
