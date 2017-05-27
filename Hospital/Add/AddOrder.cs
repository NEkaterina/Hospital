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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            comboBox();
        }

        private void radioNew_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void radioOld_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
           

        }
       
        private void butNewOk_Click(object sender, EventArgs e)
        {
            addNewZakaz();
        }

        private void butOldOk_Click(object sender, EventArgs e)
        {
            addOrderOld();
        }
        public void comboBox()
        {
            DataTable dt = Connection.getResult("select companyName from "
                    + "[Provider]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboProvid.Items.Add(dt.Rows[i][0]);
                comboProv.Items.Add(dt.Rows[i][0]);
            }
        }
        void comboBox2()
        {
            DataTable dt = Connection.getResult("select name from "
              + "[Product]");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboOldName.Items.Add(dt.Rows[i][0]);

            }
        }
        void addNewZakaz()
        {

            Connection.queryExecute(@"insert into [Product] (type,name,amount)  VALUES(N'"
+ type.Text + "',N'" + textBname.Text + "',N'" + maskedNewNum.Text + "');");


            DataTable dt = Connection.getResult(@"SELECT max(id) FROM [Product];");
            int id_product = (int)dt.Rows[0][0];



            dt = Connection.getResult(@"SELECT id FROM [Provider] where companyName =N'" + comboProvid.Text + "';");
            int id_provide = (int)dt.Rows[0][0];



            int s = Convert.ToInt32(maskedNewNum.Text);
            int um = Convert.ToInt32(maskedNewPrice.Text);
            int sum = s * um;


            Connection.queryExecute(@"insert into [LogSupply] (id_provider,id_product, date, amount, price,sum)  VALUES(N'"
 + id_provide + "',N'" + id_product + "', getdate(),N'" + maskedNewNum.Text + "',N'"
 + maskedNewPrice.Text + "',N'" + sum + "');");

            Close();
        }

        void addOrderOld()
        {
            DataTable dt = Connection.getResult(@"SELECT p.amount, p.id FROM [Product] p join [LogSupply] l on p.id = l.id_product join [Provider] on Provider.Id=l.id_provider  where companyName = N'" + comboProv.Text + "' AND name = N'"  + comboOldName.Text + "'; ");
            int amount = (int)dt.Rows[0][0];
            int id = (int)dt.Rows[0][1];


            //int num = Convert.ToInt32(maskedOldNum.Text);
            //int sumAmount = amount + num;                         
           
            //Connection.queryExecute(@"update [Product] set amount="+ sumAmount + " where id ="+id+" ;");
            



            dt = Connection.getResult(@"SELECT id FROM [Provider] where companyName =N'" + comboProv.Text + "';");
            int id_provide = (int)dt.Rows[0][0];

            int s = Convert.ToInt32(maskedOldNum.Text);
            int um = Convert.ToInt32(maskedOldPrice.Text);
            int sum = s * um;


            Connection.queryExecute(@"insert into [LogSupply] (id_provider,id_product, date, amount, price,sum)  VALUES(N'"
 + id_provide + "',N'" + id + "', getdate(),N'" + maskedOldNum.Text + "',N'"
 + maskedOldPrice.Text + "',N'" + sum + "');");

            Close();
        }

        private void comboProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2();
        }
    }
}
