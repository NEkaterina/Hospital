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
            comboBoxCliF();
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
            DataTable dt = Connection.getResult(@"select id from "
                    + "[Doctor]  where surname=N'" + comboDoctorF.Text + "' and firstname=N'" + comboDoctorI.Text + "' and otchestvo=N'" + comboDoctorO.Text + "';");
             int id_doctor = (int)dt.Rows[0][0];

            dt = Connection.getResult(@"select id from "
                    + "[Client] where surname=N'" + comboClientF.Text + "' and firstname=N'" + comboClientI.Text + "' and otchestvo=N'" + comboClientO.Text + "';");
            int id_client = (int)dt.Rows[0][0];

            dt = Connection.getResult(@"select id from "
                   + "[Service] where nameS=N'" + comboService.Text + "';");
            int id_service = (int)dt.Rows[0][0];
            Connection.queryExecute(@"insert into [Priem] (date,time,id_client,id_doctor,room,id_service)  VALUES(N'"
  + datePriem.Text + "',N'" + maskedTextBox1.Text + "'," + id_client + "," + id_doctor + ","
  + maskedKab.Text + "," + id_service  + ");");
            Close();

        }

        void comboBoxDocF()
        {
            DataTable dt = Connection.getResult("select surname from "
                    + "[Doctor]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboDoctorF.Items.Add(dt.Rows[i][0]);
            }

        }
        void comboBoxCliF()
        {
            DataTable dt = Connection.getResult("select surname from "
                    + "[Client]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboClientF.Items.Add(dt.Rows[i][0]);
            }

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

        private void comboClientF_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Connection.getResult("select firstname from "
                    + "[Client] where surname=N'"+comboClientF.Text+"'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboClientI.Items.Add(dt.Rows[i][0]);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Connection.getResult("select otchestvo from "
                   + "[Client] where firstname=N'" + comboClientI.Text + "'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboClientO.Items.Add(dt.Rows[i][0]);
            }
        }
        private void comboClientO_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboDoctorI_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Connection.getResult("select otchestvo from "
                   + "[Doctor] where firstname=N'" + comboDoctorI.Text + "'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboDoctorO.Items.Add(dt.Rows[i][0]);
            }
        }

        private void comboDoctorF_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Connection.getResult("select firstname from "
                   + "[Doctor] where surname=N'" + comboDoctorF.Text + "'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboDoctorI.Items.Add(dt.Rows[i][0]);
            }
        }

        private void comboDoctorO_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void datePriem_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDocF();
            comboBoxService();
        }

    }
}
