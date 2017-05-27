using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class Provider : Form
    {
        
       
        public Provider()
        {
            InitializeComponent();
            update();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Connection.queryExecute("DELETE FROM [Provider] WHERE Id = " + dataGrid_provider.CurrentRow.Cells[0].Value);
            update();
        }

        void update()
        {
            dataGrid_provider.DataSource = Connection.getResult(@"SELECT id,companyName,city,street,houseNumber,phone,email  FROM  [Provider] ;");
            dataGrid_provider.Columns[0].HeaderText = "№";
            dataGrid_provider.Columns[1].HeaderText = "Название компании";
            dataGrid_provider.Columns[2].HeaderText = "Город";
            dataGrid_provider.Columns[3].HeaderText = "Улица";
            dataGrid_provider.Columns[4].HeaderText = "Дом";
            dataGrid_provider.Columns[5].HeaderText = "Телефон";
            dataGrid_provider.Columns[6].HeaderText = "Email";
        }
        private void provider_addbutton_Click(object sender, EventArgs e)
        {
           
            ProviderAddEdit providerChange = new ProviderAddEdit();
            this.Hide();
            providerChange.ShowDialog();        
            update();
            this.Show();
        }

        private void provider_editbuttom_Click(object sender, EventArgs e)
        {
            ProviderAddEdit providerChange = new ProviderAddEdit();
            providerChange.id.Text = dataGrid_provider.CurrentRow.Cells[0].Value.ToString();
            providerChange.tCompanyName.Text = dataGrid_provider.CurrentRow.Cells[1].Value.ToString();
            providerChange.tCity.Text = dataGrid_provider.CurrentRow.Cells[2].Value.ToString();
            providerChange.tStreet.Text = dataGrid_provider.CurrentRow.Cells[3].Value.ToString();
            providerChange.tHouseNumber.Text = dataGrid_provider.CurrentRow.Cells[4].Value.ToString();
            providerChange.tPhone.Text = dataGrid_provider.CurrentRow.Cells[5].Value.ToString();
            providerChange.tEmail.Text = dataGrid_provider.CurrentRow.Cells[6].Value.ToString();


            this.Hide();
            providerChange.ShowDialog();
            if (provider_editbuttom.Text == "Изменить") { 
            Connection.queryExecute(@"update [Provider] set companyName=N'" + providerChange.tCompanyName.Text + "' , city =N'" + providerChange.tCity.Text + "' , street =N'" + providerChange.tCity.Text + "' , houseNumber =N'" + providerChange.tHouseNumber.Text + @"' , phone ='" + providerChange.tPhone.Text + "', email ='" + providerChange.tEmail.Text + "'  where id=" + dataGrid_provider.CurrentRow.Cells[0].Value + ";");
        }
            update();
            this.Show();
            
      }
       
        /* public bool checkStrings()
   { 
       ProviderAddEdit providerChange = new ProviderAddEdit();
       if (providerChange.tCompanyName.Text == "")
       {
           MessageBox.Show("Введите название компании");
           return false;
       }
       if (providerChange.tCity.Text == ""){
           MessageBox.Show("Введите город");
           return false;
       }
       if (providerChange.tStreet.Text == ""){
           MessageBox.Show("Введите улицу");
           return false;
       }
       if (providerChange.tHouseNumber.Text == "")
       {
           MessageBox.Show("Введите номер дома");
           return false;
       }
       if (providerChange.tPhone.Text == ""){
           MessageBox.Show("Введите номер телефона"); 
           return false;
       }
       if (providerChange.tEmail.Text == ""){
           MessageBox.Show("Введите адрес электронной почты");
           return false;
       }
       return true;


   }*/
    }
}
