using Hospital.Add;
using Hospital.Edit;
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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
           
            updateData();
        }
        void updateData()
        {
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT d.id , surname, firstname, otchestvo, sex, dateOfBirth,  passportSeries, passportNumber, specialty, post, oklad,  phoneNumber, email  FROM  [Doctor] d join [Post] on d.id_post = Post.id join [Specialty] on Post.id_specialty = Specialty.id ;");
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
            dataGridView1.Columns[6].HeaderText = "Серия паспорта";
            dataGridView1.Columns[7].HeaderText = "Номер паспорта";
            dataGridView1.Columns[8].HeaderText = "Специальность";
            dataGridView1.Columns[9].HeaderText = "Должность";
            dataGridView1.Columns[10].HeaderText = "Оклад";
            dataGridView1.Columns[11].HeaderText = "Телефон";
            dataGridView1.Columns[12].HeaderText = "E-mail";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;

        }
        private void addDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor ins = new AddDoctor();
            this.Hide();
            ins.ShowDialog();
            updateData();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "Post")
            //{
            //    DataTable dt = ConnectionDB.getResult(@"SELECT * FROM [Post];");
            //    dataGridView1.DataSource = dt;

            //}
            //else
            //{
            //    dataGridView1.DataSource = ConnectionDB.getResult("select * from [Doctor];");
            //}
        }

        private void delDoctor_Click(object sender, EventArgs e)
        {
            ConnectionDB.queryExecute("DELETE FROM [Post] WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            updateData();
        }

        private void edirDoctor_Click(object sender, EventArgs e)
        {
            EditDoctor upcl = new EditDoctor();
            upcl.id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            upcl.textBsur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            upcl.textBname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            upcl.textBotch.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            upcl.comboBsex.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            upcl.dateBirth.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            upcl.maskedSer.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            upcl.maskedNum.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            upcl.comboSpecialty.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            upcl.textBpost.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            upcl.maskedOklad.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            upcl.maskedPhone.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            upcl.textBemail.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        

            this.Hide();
            upcl.ShowDialog();
            updateData();
            this.Show();
        }
    }
}
