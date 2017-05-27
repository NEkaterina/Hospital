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

namespace Hospital.Entities
{
    public partial class MedRashodniky : Form
    {
        public MedRashodniky()
        {
            InitializeComponent();
            update();
        }

        void update()
        {
            dataGridView1.DataSource = Connection.getResult(@"select id, name,amount,minAmount FROM [Product] where type = N'Расходники'");
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[3].HeaderText = "Минимальное количество";
        }
        void prov()
        {
            DataTable dt = Connection.getResult(@"Select minAmount from [Product]");
            int min = (int)dt.Rows[0][0];

            dt = Connection.getResult(@"Select amount from [Product]");


            int calc = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                calc = (int)dt.Rows[i][0];
                if (calc <= min)
                {
                    dt = Connection.getResult(@"Select name from [Product] where amount<=minAmount");
                    string s = dt.Rows[0][0].ToString();
                    DialogResult dialog = MessageBox.Show(
                             "На складе осталось минимальное(либо меньше) количество" + " "+s+". " + "Оформить заказ?",
                                      "Уведомление",
                                       MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        AddOrder order = new AddOrder();
                        this.Hide();
                        order.ShowDialog();
                        this.Show();
                    }

                }


            }

        }

        

        private void MedRashodniky_Load(object sender, EventArgs e)
        {
            prov();
        }
    }
    }

