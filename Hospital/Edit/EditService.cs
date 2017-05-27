using Hospital.Entities;
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
    public partial class EditService : Form
    {
        public EditService()
        {
            InitializeComponent();
            
        }
       
        private void butOk_Click(object sender, EventArgs e)
        {
            editService();
            Close();
        }
       
        void editService()
        {
            Service service = new Service();
            Connection.queryExecute(@"update [Service] set nameS=N'" + textBname.Text + "' , priceS =N'" + maskedPrize.Text  + "' where id=" + id.Text + ";");

        }
    }
}
