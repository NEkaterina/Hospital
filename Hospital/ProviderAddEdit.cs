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
    public partial class ProviderAddEdit : Form
    {
        public ProviderAddEdit()
        {
            InitializeComponent();
        }

        private void ProviderAddEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicineCentreDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.medicineCentreDataSet.Provider);

        }

        private void provider_save_Click(object sender, EventArgs e)
        {

        }

        private void provider_cancel_Click(object sender, EventArgs e)
        {

        }

        private void providerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
