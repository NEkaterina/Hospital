using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Action
{
    public partial class Jurnal : Form
    {
        public Jurnal()
        {
            InitializeComponent();
            dataGridView2.DataSource = Connection.getResult(@"SELECT Priem.id, date as Date, time as Time, CONCAT('',surname,firstname,otchestvo) as Client FROM [Priem] join [Client] on Priem.id_client = Client.id where date='" + dateTimePicker1.Text + "';");

        }

        void insert()
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void raschet_Click(object sender, EventArgs e)
        {

        }
        void skidka()
        {

        }
    }
}
