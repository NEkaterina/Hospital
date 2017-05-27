using Hospital.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Add
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
            comboBox();
           
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }



            DataTable dt = Connection.getResult(@"SELECT *  FROM [Specialty] where specialty = N'" + comboSpecialty.Text + "'; ");

            int inSpec = (int)dt.Rows[0][0];
            Connection.queryExecute(@"insert into [Post] (id_specialty,post,oklad)  VALUES(N'"
+ inSpec + "',N'" + textBpost.Text + "',N'" + maskedOklad.Text + "');");


            dt = Connection.getResult(@"SELECT max(id) FROM [Post];");
            int ID = (int)dt.Rows[0][0];




            Connection.queryExecute(@"insert into [Doctor] (surname,firstname,otchestvo,dateOfBirth,passportSeries,passportNumber,phoneNumber, email,id_post,sex)  VALUES(N'"
 + textBsur.Text + "',N'" + textBname.Text + "',N'" + textBotch.Text + "',N'" + dateBirth.Text + "',N'"
 + maskedSer.Text + "',N'" + maskedNum.Text + "',N'" + maskedPhone.Text + "',N'"
 + textBemail.Text + "',N'" + ID + "',N'" + comboBsex.Text + "');");

            Close();
        }

        private void butCanel_Click(object sender, EventArgs e)
        {
           
        }

        public void comboBox()
        {
            DataTable dt = Connection.getResult("select specialty from "
                    + "[Specialty]"); 

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboSpecialty.Items.Add(dt.Rows[i][0]);
            }
            
         }

        public bool check()
        {
            if (textBsur.Text == "")
            {
                MessageBox.Show("Поле Фамилия не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBname.Text  == "")
            {
                MessageBox.Show("Поле Имя не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if ( textBotch.Text  == "")
            {
                MessageBox.Show("Поле Отчество не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (comboBsex.Text == "")
            {
                MessageBox.Show("Поле Пол не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (maskedSer.Text == "")
            {
                MessageBox.Show("Поле Серия паспорта не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if ( maskedNum.Text  == "")
            {
                MessageBox.Show("Поле Номер паспорта не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           
            if (maskedPhone.Text == "")
            {
                MessageBox.Show("Поле Телефон не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBemail.Text == "")
            {
                MessageBox.Show("Поле E-mail не заполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }

        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
