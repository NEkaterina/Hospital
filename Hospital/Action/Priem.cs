using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Action
{
    public partial class Priem : Form
    {
        public Priem()
        {
            InitializeComponent();
            comboBoxSpec();
            dataClient.DataSource = Connection.getResult(@"Select id,CONCAT(' ',surname,' ', firstname,' ',otchestvo) as ФИО from [Client]");
        }


        //void Time()
        //{
        //    //DateTime date = datePriem.Value;
        //    //string day = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToString("dddd", CultureInfo.GetCultureInfo("ru-ru")));

        //    DataTable dt  = Connection.getResult(@"Select timeS From [TimeTable] t join [Doctor] d on t.id_doctor=d.id where d.surname =N'" + comboDoctorF.Text + "' and d.firstname =N'" + comboDoctorI.Text + "' and d.otchestvo=N'" + comboDoctorO + "' and day=N'"+day+"';");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        comboTime.Items.Add( dt.Rows[i][0]);
        //    }
        //    //DateTime date1 = Convert.ToDateTime(dt.Rows[0][0]);
        //    //DateTime date2 = Convert.ToDateTime(dt.Rows[0][1]);
        //    //int time = 15;
        //    //while (date1 == date2)
        //    //{

        //    //    comboTime.Items.Add(date1.AddMinutes(15));
        //    //}


        //}

       private void butZapis_Click(object sender, EventArgs e)
       {
            int id_doctor = (int)dataDoctor.CurrentRow.Cells[0].Value;

            int id_client = (int)dataClient.CurrentRow.Cells[0].Value;

           DataTable dt = Connection.getResult(@"select id from "
                   + "[Service] where nameS=N'" + comboService.Text + "';");
            int id_service = (int)dt.Rows[0][0];
            Connection.queryExecute(@"insert into [Priem] (date,time,id_client,id_doctor,room,id_service)  VALUES(N'"
  + datePriem.Text + "',N'" + maskedTextBox1.Text + "'," + id_client + "," + id_doctor + ","
  + maskedKab.Text + "," + id_service + ");");
            Close();

        }

       
        void comboBoxSpec()
        {
            DataTable dt = Connection.getResult("select specialty from "
                    + "[Specialty]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0]);
            }

        }
        void comboBoxService()
        {
            DataTable dt = Connection.getResult("select id from "
                    + "[Specialty] where specialty =N'"+ comboBox1.Text+"';");
            int id = (int)dt.Rows[0][0];
             dt = Connection.getResult("select nameS from "
                    + "[Service] where id_specialty="+id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboService.Items.Add(dt.Rows[i][0]);
            }

        }

        private void datePriem_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDoctor.DataSource = Connection.getResult(@"Select id,CONCAT('',surname,' ', firstname,' ',otchestvo) as ФИО from [Doctor]");
           
            comboBoxService();
        }

    }
}
