using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExam
{
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laboratoryDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.laboratoryDataSet.Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laboratoryDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.laboratoryDataSet.Users);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            servicesBindingSource.AddNew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Validate();
            servicesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(laboratoryDataSet);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            servicesBindingSource.RemoveCurrent();
        }
    }
}
