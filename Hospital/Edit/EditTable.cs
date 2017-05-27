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
    public partial class EditTable : Form
    {
        public EditTable()
        {
            InitializeComponent();
            dayBox.Items.Add("Понедельник");
            dayBox.Items.Add("Вторник");
            dayBox.Items.Add("Среда");
            dayBox.Items.Add("Четверг");
            dayBox.Items.Add("Пятница");
            dayBox.Items.Add("Суббота");
            dayBox.Items.Add("Воскресенье");
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            Connection.queryExecute(@"update [TimeTable] set day=N'" + dayBox.Text + "' , timeS =N'" + maskedStart.Text + "' , timeF =N'" + maskedFinish.Text +  "' where id=" + id.Text + ";");


            this.Close();
        }
    }
}
