using Hospital.Action;
using Hospital.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Entities
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
           
        }

        private void Service_Load(object sender, EventArgs e)
        {
            comboBox();
          //  dataGridService.Visible = false;
        }

        private void butAddService_Click(object sender, EventArgs e)
        {
            AddService add = new AddService();
            this.Hide();
            add.ShowDialog();

            this.Show();
        }

        private void butEditService_Click(object sender, EventArgs e)
        {
            EditService edit = new EditService();
            edit.id.Text = dataGridService.CurrentRow.Cells[0].Value.ToString();
            edit.textBname.Text = dataGridService.CurrentRow.Cells[1].Value.ToString();
            edit.maskedPrize.Text = dataGridService.CurrentRow.Cells[2].Value.ToString();

            this.Hide();
            edit.ShowDialog();
            update();
            this.Show();
        }

        private void butDelService_Click(object sender, EventArgs e)
        {
            delService();
            update();
           
        }

        void update()
        {
            dataGridService.DataSource = Connection.getResult(@"SELECT ser.id, nameS, priceS  FROM  [Service] ser join [Specialty] sp on ser.id_specialty = sp.id where specialty=N'" + specialty.Text + "' ;");
            dataGridService.Columns[0].HeaderText = "id";
            dataGridService.Columns[1].HeaderText = "Наименование";
            dataGridService.Columns[2].HeaderText = "Стоимость";
            


            dataGridService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  dataGridService.Visible = true;
            update();

        }
        void comboBox()
        {
           DataTable dt = Connection.getResult(@"Select specialty From [Specialty]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                specialty.Items.Add(dt.Rows[i][0]);
            }
        }
        void delService()
        {
            Connection.queryExecute("DELETE FROM [Service] WHERE id = " + dataGridService.CurrentRow.Cells[0].Value.ToString());

        }
       

    }
}
