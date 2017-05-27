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
            update();
        }

        void update()
        {
            dataGridView1.DataSource = Connection.getResult(@"SELECT t.id,CONCAT(' ', surname, firstname, otchestvo),timeWok, prize, salary, CONCAT(' ', dataNach, '-',dataFin)  FROM  [Salary] t join [Doctor] on t.id_doctor = Doctor.id  ;");
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Время работы";
            dataGridView1.Columns[3].HeaderText = "Премия";
            dataGridView1.Columns[4].HeaderText = "Зарплата";
            dataGridView1.Columns[5].HeaderText = "Период";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }
        private void butRasch_Click(object sender, EventArgs e)
        {
            AlgoritmZP alg = new AlgoritmZP();
            this.Hide();
            alg.ShowDialog();
            update();
            this.Show();
        }

        private void butPere_Click(object sender, EventArgs e)
        {
            AlgoritmZP alg = new AlgoritmZP();
            alg.comboFio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            alg.maskedTime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            alg.maskedPrize.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.Hide();
            alg.ShowDialog();
            int time = Convert.ToInt32(alg.maskedTime.Text);
            int prize = Convert.ToInt32(alg.maskedPrize.Text);
            int oklad = Convert.ToInt32(alg.maskedOklad.Text);
            int zarplata = alg.raschetZarplat(time, prize, oklad);
            Connection.queryExecute(@"update [Salary] set timeWok=N'" + alg.maskedTime.Text + "',prize=N'" + alg.maskedPrize.Text + "',salary = N'" + zarplata + "' where id =" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";");
            update();
            this.Show();

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            Connection.queryExecute("DELETE FROM [Salary] WHERE  id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString()+"';");
            update();
        }
    }
}
