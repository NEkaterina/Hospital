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
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client inscl = new Client();
            inscl.Hide();
            inscl.Show();
        }
    }
}
