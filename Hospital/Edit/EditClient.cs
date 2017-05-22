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
    
    public partial class EditClient : Form
    {
        
        
        public EditClient()
        {
            InitializeComponent();
            comboSex.Items.Add("М");
            comboSex.Items.Add("Ж");
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            ConnectionDB.queryExecute(@"update [Client] set surname=N'" + tSurname.Text + "' , firstname =N'" + tFirstname.Text + "' , otchestvo =N'" + tOtchestvo.Text + "' , sex =N'" + comboSex.Text + @"' , dateOfBirth ='" + dateOfBirth.Text + "', passportSeries ='" + mSeries.Text + "' , passportNumber ='" + mNumber.Text + "' , city =N'" + tCity.Text + "' , street =N'" + tStreet.Text + "' , house ='" + mHouse.Text + "' , apartment ='" + mApartment.Text + "' , phoneNumber ='" + mPhone.Text + "' , email =N'" + tEmail.Text + "', policy='" + mPolicy.Text + "' where id=" + id.Text+ ";");


            this.Close();

        }

        private void EditClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialog = MessageBox.Show(
            //         "Вы действительно хотите отменить редактирование?",
            //                  "Завершение программы",
            //                   MessageBoxButtons.YesNo,
            //                    MessageBoxIcon.Warning);
            //if (dialog == DialogResult.Yes)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
