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
using System.Data.SqlClient;
using System.Data;

namespace Project_RS_v1._0
{
    /// <summary>
    /// Interaction logic for adminPage_SubjectsReg.xaml
    /// </summary>
    public partial class adminPage_SubjectsReg : Page
    {
        public adminPage_SubjectsReg()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into courses(course_id,course_title,credit,year,semester,dept) values(@a,@b,@c,@d,@e,@f)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = course_id.Text.ToString();
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = course_title.Text.ToString();
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = credit.Text.ToString();
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = year.Text.ToString();
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = semester.Text.ToString();
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = dept.Text.ToString();

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            sqlcon.Close();
            if(rows > 0)
                MessageBox.Show("Subject Added", "Successfull!!");
            sqlcon.Close();
        }
    }
}
