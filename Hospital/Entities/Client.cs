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
      
        public Client()
        {
            InitializeComponent();

            updateData();
            comboBox();
        }
        void updateData()
        {
            dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] ;");
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
            dataGridView1.Columns[6].HeaderText = "Полис";
            dataGridView1.Columns[7].HeaderText = "Серия паспорта";
            dataGridView1.Columns[8].HeaderText = "Номер паспорта";
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
            Connection.queryExecute("DELETE FROM [Client] WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            updateData();
        }

        void Sort()
        {
            switch (comboSort.Text)
            {
                case "id":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where id =" + textSort.Text +" ;");
                    break;
                case "Фамилия":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where surname = '" + textSort.Text + "';");
                    break;
                case "Имя":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where firstname = '" + textSort.Text + "' ;");
                    break;
                case "Отчество":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where otchestvo = '" + textSort.Text + "';");
                   break;
                case "Пол":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where sex = '" + textSort.Text + "' ;");
                    break;
                case "Дата Рождения":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where dateOfBirth = '" + textSort.Text + "' ;");
                    break;
                case "Полис":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where policy = " + textSort.Text + " ;");
                    break;
                case "Серия паспорта":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where passportSeries= " + textSort.Text + ";");
                    break;
                case "Номер паспорта":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where  passportNumber = " + textSort.Text + ";");
                   break;
                case "Город":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where city = '" + textSort.Text + "' ;");
                    break;
                case "Улица":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where street = '" + textSort.Text + "' ;");
                    break;
                case "Дом":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where house =" + textSort.Text + " ;");
                    break;
                case "Квартира":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where apartment =" + textSort.Text + ";");
                    break;
                case "Телефон":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where phoneNumber =" + textSort.Text + " ;");
                    break;
                case "Email":
                    dataGridView1.DataSource = Connection.getResult(@"SELECT id, surname, firstname, otchestvo, sex, dateOfBirth, policy, passportSeries, passportNumber, city, street,house,apartment, phoneNumber, email  FROM  [Client] Where email ='" + textSort.Text + "' ;");
                    break;
            }
        }

        void comboBox()
        {
            comboSort.Items.Add("id");
            comboSort.Items.Add("Фамилия");
            comboSort.Items.Add("Имя");
            comboSort.Items.Add("Отчество");
            comboSort.Items.Add("Пол");
            comboSort.Items.Add("Дата рождения");
            comboSort.Items.Add("Полис");
            comboSort.Items.Add("Серия паспорта");
            comboSort.Items.Add("Номер паспорта");
            comboSort.Items.Add("Город");
            comboSort.Items.Add("Улица");
            comboSort.Items.Add("Дом");
            comboSort.Items.Add("Квартира");
            comboSort.Items.Add("Телефон");
            comboSort.Items.Add("Email");
           

        }

      
        private void textSort_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (textSort.Text == "" || e.KeyCode == Keys.Enter)
            {
                updateData();
            }
            else Sort();
           
        }
           
}
    }

