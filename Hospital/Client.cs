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
    public partial class Client : Form
    {
        SqlDataAdapter da;
        public Client()
        {
            InitializeComponent();

            updateData();
        }
        void updateData()
        {
            dataGridView1.DataSource = ConnectionDB.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] ;");
            dataGridView1.Columns[1].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
            dataGridView1.Columns[6].HeaderText = "Полис";
            dataGridView1.Columns[7].HeaderText = "Серия";
            dataGridView1.Columns[8].HeaderText = "Номер";
            dataGridView1.Columns[9].HeaderText = "Город";
            dataGridView1.Columns[10].HeaderText = "Улица";
            dataGridView1.Columns[11].HeaderText = "Дом";
            dataGridView1.Columns[12].HeaderText = "Квартира";
            dataGridView1.Columns[13].HeaderText = "Телефон";
            dataGridView1.Columns[14].HeaderText = "E-mail";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddClient ins = new AddClient();            
            this.Hide();
            ins.ShowDialog();
            updateData();
            this.Show();
          
        }
        private void butEdit_Click(object sender, EventArgs e)
        {
            EditClient upcl = new EditClient();
            upcl.id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            upcl.tSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            upcl.tFirstname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            upcl.tOtchestvo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            upcl.comboSex.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            upcl.dateOfBirth.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            upcl.mSeries.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            upcl.mNumber.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            upcl.mPolicy.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            upcl.tCity.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            upcl.tStreet.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            upcl.mHouse.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            upcl.mApartment.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            upcl.mPhone.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            upcl.tEmail.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

            this.Hide();
            upcl.ShowDialog();
            updateData();
            this.Show();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            ConnectionDB.queryExecute("DELETE FROM [Client] WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            updateData();
        }
    }
}
