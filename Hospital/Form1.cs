using Hospital.Action;
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
            dataGridView1.DataSource = Connection.getResult(@"SELECT date as Date, time as Time, CONCAT('',surname,firstname,otchestvo) as Client FROM [Priem] join [Client] on Priem.id_client = Client.id;");
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
           Salary sal = new Salary();
            this.Hide();
            sal.ShowDialog();

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
            TimeTable table = new TimeTable();
            this.Hide();
            table.ShowDialog();

            this.Show();
        }

        private void medRasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedRashodniky medRas = new MedRashodniky();
            this.Hide();
            medRas.ShowDialog();

            this.Show();
        }

        private void medObrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedOboryd medObr = new MedOboryd();
            this.Hide();
            medObr.ShowDialog();

            this.Show();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider provid = new Provider();
            this.Hide();
            provid.ShowDialog();

            this.Show();
        }

        private void zakazTovarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order  order = new Order();
            this.Hide();
            order.ShowDialog();

            this.Show();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Service service = new Service();
            this.Hide();
            service.ShowDialog();

            this.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Priem priem = new Priem();
            this.Hide();
            priem.ShowDialog();

            this.Show();
        }

        private void JurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jurnal jurnal = new Jurnal();
            this.Hide();
            jurnal.ShowDialog();

            this.Show();
        }
    }
}
