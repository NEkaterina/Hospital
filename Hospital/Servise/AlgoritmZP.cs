using Hospital.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Servise
{
    public partial class AlgoritmZP : Form
    {
        public AlgoritmZP()
        {
            InitializeComponent();
            DataTable dt = ConnectionDB.getResult(@"SELECT CONCAT(' ', surname,firstname,otchestvo)  FROM  [Doctor];");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboFio.Items.Add(dt.Rows[i][0]);
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            raschetTime();          
        }

        private void comboFio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ConnectionDB.getResult("select oklad from [Post] join [Doctor] on Doctor.id_post= Post.id where CONCAT(' ', surname,firstname,otchestvo) =N'" + comboFio.Text + "' ; ");
            maskedOklad.Text = Convert.ToString(dt.Rows[0][0]);

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            insertSalary();
            Close();
        }
        void insertSalary()
        {
            Salary salary = new Salary();
            int time = Convert.ToInt32(maskedTime.Text);
            int prize = Convert.ToInt32(maskedPrize.Text);
            int oklad = Convert.ToInt32(maskedOklad.Text);
            int zarplata = raschetZarplat(time, prize, oklad);
            DataTable dt = ConnectionDB.getResult(@"SELECT id  FROM  [Doctor] where CONCAT(' ', surname,firstname,otchestvo) = N'" + comboFio.Text + "'; ");

            int id = (int)dt.Rows[0][0];

            if (salary.butPere.Text == "Расчитать") {

            ConnectionDB.queryExecute(@"insert into [Salary] (id_doctor,timeWok,prize,salary,dataNach,dataFin)  VALUES(N'"
  + id + "',N'" + maskedTime.Text + "',N'" + maskedPrize.Text + "',N'" + zarplata + "',N'" + dateS.Text + "',N'" + dateF.Text + "');");
            }
        }
         void raschetTime()
        {
            DateTime dt1 = dateS.Value;
            DateTime dt2 = dateF.Value;

            int days = (int)(dt2 - dt1).TotalDays;
            int week = days / 7;
            int calc = 0;
            int p = 0;
            DataTable dt = ConnectionDB.getResult("select DATEDIFF(hh, timeS,timeF) from [TimeTable] join [Doctor] on TimeTable.id_doctor= Doctor.id where CONCAT(' ', surname,firstname,otchestvo) =N'" + comboFio.Text + "' ; ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                calc += Convert.ToInt32(dt.Rows[i][0]);

            }

            maskedTime.Text = Convert.ToString(calc * week);
        }
       public  int raschetZarplat(int VR, int Premia, int Oklad)
        {
            int zarplata = 0;
            string n = "";
            if (radioButton1.Checked == true) { zarplata = Oklad * VR; }
            if (radioButton2.Checked == true) { zarplata = Oklad * VR + Premia; }
            if (radioButton3.Checked == true) { zarplata = Oklad; }
            if (radioButton4.Checked == true)
            {
                zarplata = Oklad + Premia;
            }


            return zarplata;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedPrize.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTime.Enabled = false;
            maskedPrize.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            maskedTime.Enabled = false;
        }
    }
}
