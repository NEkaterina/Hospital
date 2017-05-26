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
    public partial class Specialty : Form
    {
        public Specialty()
        {
            InitializeComponent();
            updateData();
        }
        void updateData()
        {
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT * FROM  [Specialty] ;");
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Специализации врачей клиники";
        }

        private void butAddSpec_Click(object sender, EventArgs e)
        {
            if (textSpec.Text != "") { 
            ConnectionDB.queryExecute(@"insert into [Specialty] (specialty)  VALUES(N'"+ textSpec.Text + "');");
                updateData();
            } else
            {
                MessageBox.Show("Заполните поле");
            }

        }

        private void butDelSpec_Click(object sender, EventArgs e)
        {
            ConnectionDB.queryExecute("DELETE FROM [Specialty] WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            updateData();
        }

        private void textSpec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            { e.Handled = true; 

                MessageBox.Show("не допустимый ввод данных", "Ошибка:ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error); //выводим сообщение об ошибке
        }
        }
    }
}
