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
    /// Interaction logic for Student_panel.xaml
    /// </summary>
    public partial class Student_panel : Window
    {
        public Student_panel()
        {
            InitializeComponent();
            frame_student.NavigationService.Navigate(new studentPage_coursereg());
        }

        private void buttonCourseReg_Click(object sender, RoutedEventArgs e)
        {
            frame_student.NavigationService.Navigate(new studentPage_coursereg());
        }

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            frame_student.NavigationService.Navigate(new studentPage_result());
        }

        private void buttonInfo_Click(object sender, RoutedEventArgs e)
        {
            frame_student.NavigationService.Navigate(new studentPage_info());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
