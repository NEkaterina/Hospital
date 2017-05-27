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

namespace Hospital.Entities
{
    public partial class MedOboryd : Form
    {
        public MedOboryd()
        {
            InitializeComponent();
            update();

        }
        void update()
        {
            dataGridView1.DataSource = Connection.getResult(@"SELECT id, name, amount, minAmount,  FROM  [Product] where type = N'Оборудование';");
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[3].HeaderText = "Минимальное количество";
           

            DataGridViewComboBoxColumn cell = new DataGridViewComboBoxColumn();
            cell.HeaderText = "Состояние";
            ArrayList row = new ArrayList();
            row.Add("Рабочее");
            row.Add("Нерабочее");

            cell.Items.AddRange(row.ToArray());
            dataGridView1.Columns.Add(cell);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
