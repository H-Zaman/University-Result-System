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
    public partial class adminPage_TeacherReg : Page
    {
        public static string dept;

        public adminPage_TeacherReg()
        {
            InitializeComponent();
            comboxFilldept();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            query1();
            query2();
        }
        void comboxFilldept()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select distinct dept from courses";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                dept = read[0].ToString();
                comboBoxDept.Items.Add(dept);
            }
        }
        void query1()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into info(id_number,fName,lName,fatherName,motherName,dob,addr,phn_no) values(@a,@b,@c,@d,@e,@f,@g,@h)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = teach_id.Text.ToString();
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = fname.Text.ToString();
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = lname.Text.ToString();
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = fatherName.Text.ToString();
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = motherName.Text.ToString();
            cmd.Parameters.Add("@f", SqlDbType.Date).Value = dob.SelectedDate.Value.ToShortDateString();
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = addr.Text.ToString();
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = phnNO.Text.ToString();

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        void query2()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into teacher(teach_id,teach_password,teach_dept,acc_type) values(@a,@b,@c,@d)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = teach_id.Text.ToString();
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = pass.Text.ToString();
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = dept;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = "2";

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Registered", "Success");
            else
                MessageBox.Show("Registration Failed", "Error");
            sqlcon.Close();
        }
    }
}
