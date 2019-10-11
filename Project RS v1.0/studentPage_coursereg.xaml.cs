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
    public partial class studentPage_coursereg : Page
    {
        class_student obj = new class_student();
        private string temp;
        public studentPage_coursereg()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            var temp = (ComboBoxItem)comboYear.SelectedItem;
            string year = (String)temp.Content;
            var tempp = (ComboBoxItem)comboSem.SelectedItem;
            string semester = (string)tempp.Content;

            string con = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery2 = "Select course_id as [Course ID],course_title as [Course Title],credit as [Credit] from courses where year=@a and semester=@b";

            SqlCommand sqlcmd2 = new SqlCommand(sqlquery2, sqlcon);
            sqlcmd2.Parameters.Add("@a", SqlDbType.VarChar).Value = year;
            sqlcmd2.Parameters.Add("@b", SqlDbType.VarChar).Value = semester;
            SqlDataAdapter data_adapter2 = new SqlDataAdapter(sqlcmd2);
            DataTable dt2 = new DataTable("courses");

            data_adapter2.Fill(dt2);
            grid_stuCourseReg.ItemsSource = dt2.DefaultView;
            data_adapter2.Update(dt2);

            sqlcon.Close();
        }

        public void btn_registerCourse_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select stu_reg_info from student where stu_id =@x ";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@x", SqlDbType.VarChar).Value = class_login.iddata;
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                if(read[0].ToString() == "0")
                {
                    sqlcon.Close();
                    string connstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
                    SqlConnection sqln = new SqlConnection(connstring);

                    SqlCommand cmd = new SqlCommand("insert into courseRegAndMark(stu_id,course_id) values(@a,@b)", sqln);

                    cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = class_login.iddata;
                    cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = temp;

                    sqln.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Registration Successfull", "Success");
                    sqln.Close();
                    obj.changeRegInfo();
                    goto gg;
                }
                else if(read[0].ToString() == "1")
                {
                    sqlcon.Close();
                    string connstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
                    SqlConnection sqln = new SqlConnection(connstring);

                    SqlCommand cmd = new SqlCommand("insert into courseRegAndMark(stu_id,course_id) values(@a,@b)", sqln);

                    cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = class_login.iddata;
                    cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = temp;

                    sqln.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Registration Successfull", "Success");
                    sqln.Close();
                    obj.changeRegInfo();
                    goto gg;
                }
                else if (read[0].ToString() == "2")
                {
                    sqlcon.Close();
                    string connstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
                    SqlConnection sqln = new SqlConnection(connstring);

                    SqlCommand cmd = new SqlCommand("insert into courseRegAndMark(stu_id,course_id) values(@a,@b)", sqln);

                    cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = class_login.iddata;
                    cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = temp;

                    sqln.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Registration Successfull", "Success");
                    sqln.Close();
                    obj.changeRegInfo();
                    goto gg;
                }
                else if (read[0].ToString() == "3")
                {
                    sqlcon.Close();
                    string connstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
                    SqlConnection sqln = new SqlConnection(connstring);

                    SqlCommand cmd = new SqlCommand("insert into courseRegAndMark(stu_id,course_id) values(@a,@b)", sqln);

                    cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = class_login.iddata;
                    cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = temp;

                    sqln.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Registration Successfull", "Success");
                    sqln.Close();
                    obj.changeRegInfo();
                    goto gg;
                }
                else
                {
                    MessageBox.Show("You are already registerd", "Error");
                }
            }
            gg:
            int zzz = 0;
        }

        private void grid_stuCourseReg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                temp = row_selected["Course ID"].ToString();
            }
        }

        void updateStuRegInfo()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update student set stu_reg_info=stu_reg_info+1 where stu_id='" + class_login.iddata + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
