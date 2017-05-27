using Hospital.Add;
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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            update();
        }

        void update()
        {
            dataGridView1.DataSource = Connection.getResult(@"SELECT l.id, companyName, name, type, date, l.amount, price, sum  FROM  [LogSupply] l join [Product] on l.id_product=Product.id join [Provider] on l.id_provider=Provider.id ;");
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Поставщик";
            dataGridView1.Columns[2].HeaderText = "Наименование товара";
            dataGridView1.Columns[3].HeaderText = "Тип";
            dataGridView1.Columns[4].HeaderText = "Дата";
            dataGridView1.Columns[5].HeaderText = "Количество";
            dataGridView1.Columns[6].HeaderText = "Цена";
            dataGridView1.Columns[7].HeaderText = "Сумма";
        

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }
        private void butNew_Click(object sender, EventArgs e)
        {
            AddOrder order = new AddOrder();
            this.Hide();
            order.ShowDialog();
            update();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.queryExecute("DELETE FROM [Product] WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            update();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
