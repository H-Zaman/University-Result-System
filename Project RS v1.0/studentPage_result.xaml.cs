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
    /// Interaction logic for studentPage_result.xaml
    /// </summary>
    public partial class studentPage_result : Page
    {
        public studentPage_result()
        {
            InitializeComponent();
            resultGridShow();
        }

        public void resultGridShow()
        {
            string connectionstring = @"Data Source=TAZ-PC\SQL;Initial Catalog=ResultSystem;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            sqlcon.Open();
            string commandstring = "select course_id as [Course ID],grade as Grade,grade_point as [Grade Point] from courseRegAndMark  where stu_id=@pre";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@pre", SqlDbType.VarChar).Value = class_login.iddata;
            sqlcmd.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable("Course_Registration");
            dataAdp.Fill(dt);
            grid_stu_result.ItemsSource = dt.DefaultView;
            dataAdp.Update(dt);

            sqlcon.Close();

        }
    }
}
