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
using System.Data;
using System.Data.SqlClient;

namespace Project_RS_v1._0
{
    /// <summary>
    /// Interaction logic for adminPage_SubjectsUpdate.xaml
    /// </summary>
    public partial class adminPage_SubjectsUpdate : Page
    {
        public adminPage_SubjectsUpdate()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            gridView();
        }

        private void delete_stu_btn_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "delete from courses where course_id= @x";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@x", SqlDbType.VarChar).Value = course_id.Text;
            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            gridView();
            if (rows > 0)
                MessageBox.Show("Information Has Been Deleted.", "Success");
        }

        private void update_button_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update courses set course_id=@a,course_title=@b,credit=@c,year=@d,semester=@e,dept=@f  where course_id='" + course_id.Text + "'";

            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = course_id.Text;
            sqlcmd.Parameters.Add("@b", SqlDbType.VarChar).Value = course_title.Text;
            sqlcmd.Parameters.Add("@c", SqlDbType.VarChar).Value = credit.Text;
            sqlcmd.Parameters.Add("@d", SqlDbType.VarChar).Value = year.Text;
            sqlcmd.Parameters.Add("@e", SqlDbType.VarChar).Value = semester.Text;
            sqlcmd.Parameters.Add("@f", SqlDbType.VarChar).Value = dept.Text;

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            gridView();
            if (rows == 1)
                MessageBox.Show("Information Has Been Updated.", "Success!!");
        }

        private void grid_adminstudentUpdate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                course_id.Text = row_selected["Course Code"].ToString();
                course_title.Text = row_selected["Course Title"].ToString();
                credit.Text = row_selected["Credit"].ToString();
                year.Text = row_selected["Year"].ToString();
                semester.Text = row_selected["Semester"].ToString();
                dept.Text = row_selected["Department"].ToString();
            }
        }
        void gridView()
        {
            string con = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery2 = "Select course_id as [Course Code],course_title as [Course Title],credit as Credit,year as Year,semester as Semester,dept as Department from courses where course_id = '" + searchbox.Text + "'";

            SqlCommand sqlcmd2 = new SqlCommand(sqlquery2, sqlcon);
            SqlDataAdapter data_adapter2 = new SqlDataAdapter(sqlcmd2);
            DataTable dt2 = new DataTable("courses");

            data_adapter2.Fill(dt2);
            grid_adminstudentUpdate.ItemsSource = dt2.DefaultView;
            data_adapter2.Update(dt2);

            sqlcon.Close();
        }
    }
}
