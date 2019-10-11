using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Project_RS_v1._0
{
    class class_login
    {
        static public string iddata;
        public static int i = 0;
        public void admin(string a,string b)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from admin";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();
            while (read.Read())
            {
                if (read[0].ToString() == a && read[1].ToString() == b)
                {
                    if (read[2].ToString() == "1")
                    {
                        i = 1;
                        admin_panel h = new admin_panel();
                        h.Show();
                    }
                }
            }
            sqlcon.Close();
        }
        public void student(string a, string b)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select stu_id,stu_password,acc_type from student";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();
            while (read.Read())
            {
                if (read[0].ToString() == a && read[1].ToString() == b)
                {
                    if (read[2].ToString() == "3")
                    {
                        i = 1;
                        Student_panel h = new Student_panel();
                        h.loggdInas.Content = a;
                        iddata = a;
                        h.Show();
                    }
                }
            }
            sqlcon.Close();
        }
        public void teacher(string a, string b)
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select teach_id,teach_password,acc_type from teacher";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();
            while (read.Read())
            {
                if (read[0].ToString() == a && read[1].ToString() == b)
                {
                    if (read[2].ToString() == "2")
                    {
                        i = 1;
                        teacher_panel h = new teacher_panel();
                        h.Show();
                    }
                }
            }
            sqlcon.Close();
        }
        public void loginchcker()
        {
            if (i == 0)
            {
                MessageBox.Show("Incorrect data.","Error");
                MainWindow mw = new MainWindow();
                mw.Show();
            }
            else
            {
                MessageBox.Show("Login Success", "Welcome");
            }
        }
    }
}
