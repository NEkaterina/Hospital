using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Add
{
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
            comboBox();
            dayBox.Items.Add("Понедельник");
            dayBox.Items.Add("Вторник");
            dayBox.Items.Add("Среда");
            dayBox.Items.Add("Четверг");
            dayBox.Items.Add("Пятница");
            dayBox.Items.Add("Суббота");
            dayBox.Items.Add("Воскресенье");
        }

        private void butOk_Click(object sender, EventArgs e)
        {
           
            DataTable dt = Connection.getResult(@"SELECT *  FROM [Doctor] where  CONCAT(' ', surname,firstname,otchestvo) = N'" + docBox.Text + "'; ");

            int id = (int)dt.Rows[0][0];
            Connection.queryExecute(@"insert into [TimeTable] (day,timeS,timeF,id_doctor)  VALUES(N'"
 + dayBox.Text + "',N'" + maskedStart.Text + "',N'" + maskedFinish.Text + "',N'" + id +  "');");
            Close();

        }
        public void comboBox()
        {
            DataTable dt = Connection.getResult("select specialty from "
                    + "[Specialty]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                specBox.Items.Add(dt.Rows[i][0]);
            }

           

        }

        private void specBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Connection.getResult("select CONCAT(' ', surname,firstname,otchestvo) from "
                   + "[Doctor] d join[Post] on d.id_post = Post.id join[Specialty] on Post.id_specialty = Specialty.id where specialty = N'" + specBox.Text + "'; ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                docBox.Items.Add(dt.Rows[i][0]);
            }
        }
    }
}
