using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT date as Date, time as Time, CONCAT('',surname,firstname,otchestvo) as Client FROM [Priem] join [Client] on Priem.id_client = Client.id;");


            //con = new SqlConnection();
            //con.ConnectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\MyDB.mdf; Integrated Security = True; Connect Timeout = 30";
            //con.Open();

            //cmd = new SqlCommand("select * from [Table]");
            //cmd.Connection = con;
            //da = new SqlDataAdapter(cmd);
            //dt = new DataTable("[Table]");
            //da.Fill(dt);

            //dataGrid.ItemsSource = dt.DefaultView;
            //con.Close();
        }
    }
}
