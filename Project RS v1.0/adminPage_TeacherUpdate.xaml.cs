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
    /// Interaction logic for adminPage_TeacherUpdate.xaml
    /// </summary>
    public partial class adminPage_TeacherUpdate : Page
    {
        public adminPage_TeacherUpdate()
        {
            InitializeComponent();
        }

        private void update_button_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update info set fName=@a,lName=@b,fatherName=@c,motherName=@d,addr=@e,phn_no=@f  where id_number='" + teacher_id.Text + "'";

            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = fname.Text;
            sqlcmd.Parameters.Add("@b", SqlDbType.VarChar).Value = lname.Text;
            sqlcmd.Parameters.Add("@c", SqlDbType.VarChar).Value = fathername.Text;
            sqlcmd.Parameters.Add("@d", SqlDbType.VarChar).Value = mothername.Text;
            sqlcmd.Parameters.Add("@e", SqlDbType.VarChar).Value = addr.Text;
            sqlcmd.Parameters.Add("@f", SqlDbType.VarChar).Value = phnno.Text;

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            gridView();
            if (rows == 1)
                MessageBox.Show("Information Has Been Updated.", "Success!!");
        }

        private void delete_stu_btn_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "delete from info where id_number= @x";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@x", SqlDbType.VarChar).Value = teacher_id.Text;
            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            gridView();
            if (rows > 0)
                MessageBox.Show("Information Has Been Deleted.", "Success");
        }

        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            gridView();
        }
        void gridView()
        {
            string con = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery2 = "Select id_number as [ID number],fName as [First Name],lName as [Last Name],fatherName as [Father Name],motherName as [Mother Name],dob as [Date of Birth],addr as Address,phn_no as [Phone Number] from info where id_number = '" + searchbox.Text + "'";

            SqlCommand sqlcmd2 = new SqlCommand(sqlquery2, sqlcon);
            SqlDataAdapter data_adapter2 = new SqlDataAdapter(sqlcmd2);
            DataTable dt2 = new DataTable("info");

            data_adapter2.Fill(dt2);
            grid_adminstudentUpdate.ItemsSource = dt2.DefaultView;
            data_adapter2.Update(dt2);

            sqlcon.Close();
        }

        private void grid_adminstudentUpdate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                teacher_id.Text = row_selected["ID number"].ToString();
                fname.Text = row_selected["First Name"].ToString();
                lname.Text = row_selected["Last Name"].ToString();
                fathername.Text = row_selected["Father Name"].ToString();
                mothername.Text = row_selected["Mother Name"].ToString();
                dob.Text = row_selected["Date of Birth"].ToString();
                addr.Text = row_selected["Address"].ToString();
                phnno.Text = row_selected["Phone Number"].ToString();
            }
        }
    }
}
