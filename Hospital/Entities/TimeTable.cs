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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
            comboBox();
        }
        void updateData()
        {
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT t.id,day, timeS, timeF  FROM  [TimeTable] t join [Doctor] on t.id_doctor = Doctor.id join [Post] on Doctor.id_post = Post.id join [Specialty] on Post.id_specialty = Specialty.id ;");
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "День";
            dataGridView1.Columns[2].HeaderText = "Начало работы";
            dataGridView1.Columns[3].HeaderText = "Окончание";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;

        }
       public void comboBox()
        {
            DataTable dt = ConnectionDB.getResult("select specialty from "
                    + "[Specialty]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboSpecialty.Items.Add(dt.Rows[i][0]);
            }



            

        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddTable ins = new AddTable();
            this.Hide();
            ins.ShowDialog();
            this.Show();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            EditTable upcl = new EditTable();
            upcl.id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            upcl.dayBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            upcl.maskedStart.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            upcl.maskedFinish.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           

            this.Hide();
            upcl.ShowDialog();
            updateData();
            this.Show();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            ConnectionDB.queryExecute("DELETE FROM [TimeTable] WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            updateData();
        }

        private void comboSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ConnectionDB.getResult(@"SELECT CONCAT(' ', surname,firstname,otchestvo)  FROM  [Doctor] d join [Post] on d.id_post = Post.id join [Specialty] on Post.id_specialty = Specialty.id where specialty = N'" + comboSpecialty.Text + "';");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboDoctor.Items.Add(dt.Rows[i][0]);
            }
                       
        }

        private void comboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT d.id, day, timeS, timeF  FROM  [Doctor] d join [TimeTable] on d.id = TimeTable.id_doctor  where CONCAT(' ', surname,firstname,otchestvo) = N'" + comboDoctor.Text + "';");

        }

        
    }
}
