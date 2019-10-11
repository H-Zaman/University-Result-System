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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string name;
        public static string pass;
        public static int k;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            name = textBox.Text;
            pass = passwordBox.Password;
            class_login instance = new class_login();
            instance.admin(name,pass);
            instance.teacher(name,pass);
            instance.student(name,pass);
            instance.loginchcker();
            this.Close();
        }
    }
}
