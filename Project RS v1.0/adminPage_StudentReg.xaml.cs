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
    /// Interaction logic for adminPage_StudentReg.xaml
    /// </summary>
    public partial class adminPage_StudentReg : Page
    {
        public static string dept;
        public static string semester;
        public adminPage_StudentReg()
        {
            InitializeComponent();
            comboxFilldept();
            comboxFillsem();
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
        void comboxFillsem()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select distinct semester from courses";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                semester = read[0].ToString();
                comboBoxSem.Items.Add(semester);
            }
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            query1();
            query2();
        }
        void query1()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into info(id_number,fName,lName,fatherName,motherName,dob,addr,phn_no) values(@a,@b,@c,@d,@e,@f,@g,@h)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = stu_id.Text.ToString();
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

            SqlCommand cmd = new SqlCommand("insert into student(stu_id,stu_password,stu_reg_info,stu_dept,stu_semester,acc_type) values(@a,@b,@c,@d,@e,@f)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = stu_id.Text.ToString();
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = pass.Text.ToString();
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = "0";
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = dept;
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = semester;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = "3";

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