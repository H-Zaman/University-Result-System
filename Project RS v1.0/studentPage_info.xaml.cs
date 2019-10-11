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
    /// Interaction logic for studentPage_info.xaml
    /// </summary>
    public partial class studentPage_info : Page
    {
        static public string xxx;
        public studentPage_info()
        {
            InitializeComponent();
            showData();
        }
        void showData()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from info where id_number =@x";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@x", SqlDbType.VarChar).Value = class_login.iddata;
            SqlDataReader read = sqlcmd.ExecuteReader();
            while (read.Read())
            {
                stuID.Content = read[0].ToString();
                fname.Content = read[1].ToString();
                lname.Content = read[2].ToString();
                fathername.Content = read[3].ToString();
                mothername.Content = read[4].ToString();
                dob.Content = read[5].ToString();
                addr.Content = read[6].ToString();
                phnnum.Content = read[7].ToString();
            }

            sqlcon.Close();
        }
    }
}
