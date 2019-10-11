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
    /// Interaction logic for adminPage_Marks.xaml
    /// </summary>
    public partial class adminPage_Marks : Page
    {
        public static string grade_point;
        public static string grade;
        public static string selectedsubj;
        public string sName;

        public adminPage_Marks()
        {
            InitializeComponent();
            comboBoxFill();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            dataGridshow();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string mark = mark_text.Text;
            int marks = Int32.Parse(mark.ToString());

            if (marks >= 80 && marks <= 100)
            {
                grade_point = "4.00";
                grade = "A+";

            }
            else if (marks >= 70 && marks <= 79)
            {
                grade_point = "3.50";
                grade = "A";
            }
            else if (marks >= 60 && marks <= 69)
            {
                grade_point = "3.00";
                grade = "A-";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade_point = "2.50";
                grade = "B+";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade_point = "2.00";
                grade = "B-";
            }
            else if (marks >= 0 && marks <= 39)
            {
                grade_point = "0.00";
                grade = "F";
            }

            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update courseRegAndMark set marks=@a,grade=@b,grade_point=@c  where stu_id='" + labelStu_id.Content + "' and course_id='" + labelStu_subj.Content + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = mark;
            sqlcmd.Parameters.Add("@b", SqlDbType.VarChar).Value = grade;
            sqlcmd.Parameters.Add("@c", SqlDbType.VarChar).Value = grade_point;

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            dataGridshow();
            sqlcon.Close();

            if (rows == 1)
                MessageBox.Show("Information Has Updated.");
        }
        void dataGridshow()
        {
            var temp = comboSelectSubj.SelectedItem;
            string selectedsubj = (String)temp;
            string con = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery2 = "Select stu_id as [Student ID],course_id as [Course ID],marks as Mark,grade as Grade from courseRegAndMark where course_id=@a";

            SqlCommand sqlcmd2 = new SqlCommand(sqlquery2, sqlcon);
            sqlcmd2.Parameters.Add("@a", SqlDbType.VarChar).Value = selectedsubj;
            SqlDataAdapter data_adapter2 = new SqlDataAdapter(sqlcmd2);
            DataTable dt2 = new DataTable("courseRegAndMark");

            data_adapter2.Fill(dt2);
            grid_teacher.ItemsSource = dt2.DefaultView;
            data_adapter2.Update(dt2);

            sqlcon.Close();
        }

        private void grid_teacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                labelStu_id.Content = row_selected["Student ID"].ToString();
                mark_text.Text = row_selected["Mark"].ToString();
                labelStu_subj.Content = row_selected["Course ID"].ToString();
            }
        }
        void comboBoxFill()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select course_id from courses";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                sName = read[0].ToString();
                comboSelectSubj.Items.Add(sName);
            }
        }
    }
}
