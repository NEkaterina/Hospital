using Hospital.Entities;
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
            this.Hide();
            inscl.ShowDialog();
            this.Show();
        }

        private void specialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specialty specialty = new Specialty();
            this.Hide();
            specialty.ShowDialog();     
            this.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Salary doc = new Salary();
            this.Hide();
            doc.ShowDialog();

            this.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            this.Hide();
            doc.ShowDialog();
           
            this.Show();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeTable doc = new TimeTable();
            this.Hide();
            doc.ShowDialog();

            this.Show();
        }
    }
}
