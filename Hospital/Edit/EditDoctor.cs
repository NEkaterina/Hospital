using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Edit
{
    public partial class EditDoctor : Form
    {
        public EditDoctor()
        {
            InitializeComponent();
            comboBox();
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
        private void butOk_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            DataTable dt = Connection.getResult(@"SELECT *  FROM [Specialty] where specialty = N'" + comboSpecialty.Text + "'; ");

            int inSpec = (int)dt.Rows[0][0];
            Connection.queryExecute(@"update [Doctor] d, [Post] p set d.surname=N'" + textBsur.Text + "' , d.firstname =N'" + textBname.Text + "' , d.otchestvo =N'" + textBotch.Text +  @"' , d.dateOfBirth ='" + dateBirth.Text + "', d.passportSeries ='" + maskedSer.Text + "' , d.passportNumber ='" + maskedNum.Text + "' , p.id_specialty =N'" + inSpec + "' , p.post =N'" + textBpost.Text + "' , p.oklad='" + maskedOklad.Text + "' , d.phoneNumber ='" + maskedPhone.Text + "' , d.email =N'" + textBemail.Text  + "' where d.id_post= p.id AND id=" + id.Text + ";");


            this.Close();
        }
    }
}
