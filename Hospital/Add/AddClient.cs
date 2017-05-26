using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            comboSex.Items.Add("М");
            comboSex.Items.Add("Ж");

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            addClient();
            Close();
        }

        void addClient()
        {
            if (!check())
            {
                return;
            }

            ConnectionDB.queryExecute(@"insert into [Client] (surname,firstname,otchestvo,sex,dateOfBirth,passportSeries,passportNumber,city,street,house,apartment,phoneNumber, email,policy)  VALUES(N'"
  + tSurname.Text + "',N'" + tFirstname.Text + "',N'" + tOtchestvo.Text + "',N'" + comboSex.Text + "','" + dateOfBirth.Text + "','" + mSeries.Text + "','" + mNumber.Text + "',N'" + tCity.Text + "',N'"
  + tStreet.Text + "','" + mHouse.Text + "','" + mApartment.Text + "','" + mPhone.Text + "',N'" + tEmail.Text + "','" + mPolicy.Text + "');");

        }

        public bool check()
        {
            if (tSurname.Text == "")
            {
                MessageBox.Show("Поле Фамилия не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tFirstname.Text == "")
            {
                MessageBox.Show("Поле Имя не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tOtchestvo.Text == "")
            {
                MessageBox.Show("Поле Отчество не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (comboSex.Text == "")
            {
                MessageBox.Show("Поле Пол не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mSeries.Text == "")
            {
                MessageBox.Show("Поле Серия паспорта не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (mNumber.Text == "")
            {
                MessageBox.Show("Поле Номер паспорта не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tCity.Text == "")
            {
                MessageBox.Show("Поле Город не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tStreet.Text == "")
            {
                MessageBox.Show("Поле Улица не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (mHouse.Text == "")
            {
                MessageBox.Show("Поле Дом не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (mApartment.Text == "")
            {
                MessageBox.Show("Поле Квартира не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (mPhone.Text == "")
            {
                MessageBox.Show("Поле Телефон не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tEmail.Text == "")
            {
                MessageBox.Show("Поле E-mail не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (mPolicy.Text == "")
            {
                MessageBox.Show("Поле Полис не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

       
    }
}
