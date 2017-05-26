using Hospital.Servise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Entities
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT CONCAT(' ', surname, firstname, otchestvo),timeWok, prize, salary, CONCAT(' ', dataNach, '-',dataFin)  FROM  [Salary] t join [Doctor] on t.id_doctor = Doctor.id  ;");
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Время работы";
            dataGridView1.Columns[2].HeaderText = "Премия";
            dataGridView1.Columns[3].HeaderText = "Зарплата";
            dataGridView1.Columns[4].HeaderText = "Период";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }

        private void butRasch_Click(object sender, EventArgs e)
        {
            AlgoritmZP ins = new AlgoritmZP();
            this.Hide();
            ins.ShowDialog();
            this.Show();
        }
    }
}
