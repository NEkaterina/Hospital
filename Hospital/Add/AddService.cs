using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Action
{
    public partial class AddService : Form
    {
        DataTable dt;
        public AddService()
        {
            InitializeComponent();
            comboBoxService();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            addServise();
            Close();
        }

        void addServise()
        {
            dt = Connection.getResult(@"Select id From [Specialty] where specialty =N'" + comboSpecialty.Text + "';");
            int id_specialty = (int)dt.Rows[0][0];

            Connection.queryExecute(@"Insert into [Service] (id_specialty, nameS,priceS) VALUES(" + id_specialty + ",N'" + textBname.Text + "'," + maskedPrize.Text + ");");
        }
        void comboBoxService()
        {
             dt = Connection.getResult(@"Select specialty From [Specialty]");
            for(int i = 0; i< dt.Rows.Count; i++)
            {
                comboSpecialty.Items.Add(dt.Rows[i][0]);
            }

        }
    }
}
