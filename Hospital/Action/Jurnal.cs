using Hospital.Add;
using Hospital.Servise;
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

namespace Hospital.Action
{
    public partial class Jurnal : Form
    {
        DataTable dt;
        public Jurnal()
        {
            InitializeComponent();
            updateTime();
            update();
        }
        void update()
        {
              perfomend.DataSource = Connection.getResult(@"SELECT j.id, nameS, priceS, skidka, itog FROM [Journal] j join [Priem] p on j.id_priem = p.id join [Service] s on p.id_service=s.id ;");
            perfomend.Columns[0].HeaderText = "№";
            perfomend.Columns[1].HeaderText = "Наименование";
            perfomend.Columns[2].HeaderText = "Цена";
            perfomend.Columns[3].HeaderText = "Скидка";
            perfomend.Columns[4].HeaderText = "Сумма";
        }
        void updateTime()
        {
            timeTable.DataSource = Connection.getResult(@"SELECT Priem.id, date , time , CONCAT('',surname,' ',firstname,' ',otchestvo)  FROM [Priem] join [Client] on Priem.id_client = Client.id where date = CAST(GETDATE() AS DATE);");
            timeTable.Columns[0].HeaderText = "№";
            timeTable.Columns[1].HeaderText = "Дата";
            timeTable.Columns[2].HeaderText = "Время";
            timeTable.Columns[3].HeaderText = "Пациент";
           
        }

            void insert()
        {
            

            if (timeTable.CurrentRow != null)
            {
                DataTable dt = Connection.getResult(@"Select priceS From [Priem] p join [Service] s on p.id_service = s.id where p.id= " + timeTable.CurrentRow.Cells[0].Value.ToString() + ";");
                int sum = (int)dt.Rows[0][0];
                int skidka = (int)Rskidka();
                int itog = sum - (sum * skidka / 100);

                

                Connection.queryExecute(@"Insert into [Journal] (id_priem, skidka, itog) VALUES(" + timeTable.CurrentRow.Cells[0].Value.ToString() + "," + skidka + "," + itog + ");");

            }
            else MessageBox.Show("Выбирите клиента");
    }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void raschet_Click(object sender, EventArgs e)
        {
            // prov();
            insert();
            sudAmount();
            update();
            // Connection.queryExecute("DELETE FROM [Journal] WHERE id = " + perfomend.CurrentRow.Cells[0].Value.ToString());

        }
        int Rskidka()
        {
            int skidk = 0;
             dt = Connection.getResult(@"Select count(Client.id) from [Journal] s join [Priem] p on s.id_priem=p.id join [Client] on p.id_client = Client.id where CONCAT('',surname,firstname,otchestvo) = N'"+timeTable.CurrentRow.Cells[3].Value.ToString()+"'; ");
            int kol = (int)dt.Rows[0][0];
           if (kol > 1 && kol < 15)
            {
                skidk = 7;
            }
            else
            if (kol >= 15)
            {
                skidk = 15;
            }
            else
                skidk = 0;
            
            return skidk;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timeTable.DataSource = Connection.getResult(@"SELECT Priem.id, date as Дата, time as Время, CONCAT('',surname,firstname,otchestvo) as Пациент FROM [Priem] join [Client] on Priem.id_client = Client.id where date='" + dateTimePicker1.Text + "';");
        }

        private void Jurnal_Load(object sender, EventArgs e)
        {
            
             
        }
        void sudAmount()
        {
            ArrayList list = new ArrayList();
            dt = Connection.getResult(@"Select max(id) from [Journal]");
            int id_journal = (int)dt.Rows[0][0];
            
            dt = Connection.getResult(@"Select s.id from [Service] s join [Priem] p on s.id = p.id_service join [Journal] j on j.id_priem=p.id where j.id =" + id_journal + " ;");
            int id_service = (int)dt.Rows[0][0];
         
            dt = Connection.getResult(@"Select p.id from [Product] p join [SerProd] s on s.id_product = p.id join [Service] ser on s.id_service=ser.id where ser.id =" + id_service + " ;");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][0]);
            }
            for (int i = 0; i < list.Count; i++)
            {
                dt = Connection.getResult(@"Select amount from [Product] where id =" + list[i] + " ;");
                int num = Convert.ToInt32(dt.Rows[0][0]);
                int sumAmount = num - 2;

                Connection.queryExecute(@"update [Product] set amount=" + sumAmount + " where id =" + list[i] + " ;");



            }


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
                             "На складе осталось минимальное(либо меньше) количество" + " " + s + ". " + "Оформить заказ?",
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


        //public bool DF()
        //{
        //    ArrayList list = new ArrayList();
        //    DataTable dt = Connection.getResult(@"Select id_priem from [Journal] ;");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        list.Add(dt.Rows[i][0]);
        //    }
        //    ArrayList list1 = new ArrayList();
        //    dt = Connection.getResult(@"Select id from [Priem] ;");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        list1.Add(dt.Rows[i][0]);
        //    }
        //    for(int i=0;i<timeTable.Rows.Count; i++) { 
        //    for (int j = 0; j < list.Count; j++)
        //    {

        //        if (list[j] == timeTable.CurrentRow.Cells[0].Value)
        //        {
        //            return false;
        //         }
        //    }
        //    }
        //    return true;
        //}
    }
}
