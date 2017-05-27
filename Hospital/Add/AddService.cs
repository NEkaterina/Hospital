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
            listCheked();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            addServise();
           // Close();
        }

        void addServise()
        {
            dt = Connection.getResult(@"Select id From [Specialty] where specialty =N'" + comboSpecialty.Text + "';");
            int id_specialty = (int)dt.Rows[0][0];

            Connection.queryExecute(@"Insert into [Service] (id_specialty, nameS,priceS) VALUES(" + id_specialty + ",N'" + textBname.Text + "'," + maskedPrize.Text + ");");

            dt = Connection.getResult(@"Select max(id) from [Service]");
            int id_service = (int)dt.Rows[0][0];
            for (int i = 0; i<listProduct.Items.Count; i++)
            {
                if (listProduct.GetItemChecked(i))
                {
                    dt= Connection.getResult(@"Select id From [Product] where name =N'" + listProduct.Items[i].ToString()+ "';");
                    int id_product = (int)dt.Rows[0][0];
                    Connection.queryExecute(@"Insert into [SerProd] (id_service, id_product) VALUES(" + id_service + "," + id_product  + ");");


                }
            }
        }
        void comboBoxService()
        {
             dt = Connection.getResult(@"Select specialty From [Specialty]");
            for(int i = 0; i< dt.Rows.Count; i++)
            {
                comboSpecialty.Items.Add(dt.Rows[i][0]);
            }

        }
        void listCheked()
        {
            dt = Connection.getResult(@"Select name From [Product]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               listProduct.Items.Add(dt.Rows[i][0]);
            }
        }
    }
}
