using Hospital.Entities;
using System;
using System.Collections;
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
    public partial class EditService : Form
    {
        public EditService()
        {
            InitializeComponent();
           


        }
       
        private void butOk_Click(object sender, EventArgs e)
        {
            editService();
            //Close();
        }
        DataTable dt;
        void editService()
        {
            Service service = new Service();
            Connection.queryExecute(@"update [Service] set nameS=N'" + textBname.Text + "' , priceS =N'" + maskedPrize.Text + "' where id=" + id.Text + ";");
            //for (int i = 0; i < checkedList.Items.Count; i++)
            //{
            //    if (checkedList.GetItemChecked(i)&& )
            //    {
            //        dt = Connection.getResult(@"Select id From [Product] where name =N'" + listProduct.Items[i].ToString() + "';");
            //        int id_product = (int)dt.Rows[0][0];
            //        Connection.queryExecute(@"Insert into [SerProd] (id_service, id_product) VALUES(" + id_service + "," + id_product + ");");


            //    }
            //}
        }
        void listCheked()
        {
            dt = Connection.getResult(@"Select name From [Product]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedList.Items.Add(dt.Rows[i][0]);
            }
            dt = Connection.getResult(@"Select id from [Service] where nameS =N'" + textBname.Text + "';");
            int id_service = (int)dt.Rows[0][0];

            ArrayList list = new ArrayList();
            dt = Connection.getResult(@"Select name from [Product] join [SerProd] on Product.id = SerProd.id_product join [Service] on Service.id=SerProd.id_service where SerProd.id_service= " + id_service + ";");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][0]);
            }
            for (int i = 0; i < checkedList.Items.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {

                    if (list[j].ToString() == checkedList.Items[i].ToString())
                    {
                        textBname.Text = checkedList.Items[i].ToString();
                        checkedList.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            listCheked();
        }
    }
            
}
