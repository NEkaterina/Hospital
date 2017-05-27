using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class ProviderAddEdit : Form
    {
        public ProviderAddEdit()
        {
            InitializeComponent();
        }

        private void ProviderAddEdit_Load(object sender, EventArgs e)
        {
           
        }

        private void provider_save_Click(object sender, EventArgs e)
        {
           
                addProvider();
             Close();
        }
        void addProvider()
        {
        Provider prov = new Provider();
        if (prov.provider_addbutton.Text == "Добавить")
        {
            Connection.queryExecute(@"insert into [Provider] (companyName,city,street,phone,email,houseNumber)  VALUES(N'"
      + tCompanyName.Text + "',N'" + tCity.Text + "',N'" + tStreet.Text + "',N'" + tPhone.Text + "',N'" + tEmail.Text + "',N'" + tHouseNumber.Text + "');");
        }
        }
        private void provider_cancel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
