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
        ConnectionDB connect = new ConnectionDB();
        public static SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=B:\MedicineCentre.mdf;Integrated Security=True;Connect Timeout=30");
       
       
        public Provider()
        {
            InitializeComponent();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicineCentreDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.medicineCentreDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicineCentreDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.medicineCentreDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicineCentreDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.medicineCentreDataSet.Provider);

        }

        private void show_button_Click(object sender, EventArgs e)
        {

       //     SQLiteConnection sql = new SQLiteConnection(@"Data Source=B:\productfeatdb.sqlite;Version=3");
            sql.Open();
            string s = @"SELECT * FROM Provider;";
            SqlCommand sqlcon = new SqlCommand(s,sql);
            sqlcon.CommandText = s;
            SqlDataReader sdr = sqlcon.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGrid_provider.DataSource = dt;
            sdr.Close();
            sql.Close();
            ConnectionDB.getResult(s);
            providerTableAdapter.Update(this.medicineCentreDataSet.Provider);

           
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
        private void delete_button_Click(object sender, EventArgs e)
        {
            ConnectionDB.executeQuery("DELETE FROM [Provider] WHERE Id = " + dataGrid_provider.CurrentRow.Cells[0].Value);
            providerTableAdapter.Update(this.medicineCentreDataSet.Provider);
            providerBindingSource.EndEdit();
        }

        private void provider_addbutton_Click(object sender, EventArgs e)
        {
           
            ProviderAddEdit providerChange = new ProviderAddEdit();
            providerChange.tCompanyName.Clear();
            providerChange.tCity.Clear();
            providerChange.tStreet.Clear();
            providerChange.tHouseNumber.Clear();
            providerChange.tPhone.Clear();
            providerChange.tEmail.Clear();

            if (providerChange.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConnectionDB.executeQuery(@"insert into [Provider] (companyName,city,street,houseNumber,phone,email)  VALUES(N'"
      + providerChange.tCompanyName.Text + "',N'" + providerChange.tCity.Text + "',N'" + providerChange.tStreet.Text + "',N'" + providerChange.tHouseNumber.Text + "',N'" + providerChange.tPhone.Text + "',N'" + providerChange.tEmail.Text + "');");
               
                 providerTableAdapter.Update(this.medicineCentreDataSet.Provider);
                providerBindingSource.EndEdit();
                ConnectionDB.executeQuery(@"select * from [Provider];");
            }
            else
                providerBindingSource.CancelEdit();
         

           
        }

        private void provider_editbuttom_Click(object sender, EventArgs e)
        {
            ProviderAddEdit providerChange = new ProviderAddEdit();
          
            if (providerChange.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConnectionDB.executeQuery(@"update [Provider] set companyName=N'" + providerChange.tCompanyName.Text + "' , city =N'" + providerChange.tCity.Text + "' , street =N'" + providerChange.tCity.Text + "' , houseNumber =N'" + providerChange.tHouseNumber.Text + @"' , phone ='" + providerChange.tPhone.Text + "', email ='" + providerChange.tEmail.Text + "'  where id=" + dataGrid_provider.CurrentRow.Cells[0].Value + ";");
                providerTableAdapter.Update(this.medicineCentreDataSet.Provider);
                providerBindingSource.EndEdit();
            }
           

        }
    }
}
