using System;
using System.Windows.Forms;

namespace TestExam
{
    public partial class PatientMenuForm : Form
    {
        public PatientMenuForm()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            PatientProfileForm frm = new PatientProfileForm();
            frm.ShowDialog();
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            GraficForm frm = new GraficForm();
            frm.Show();
        }

        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            DataGridForm frm = new DataGridForm();
            frm.Show();
        }

        private void btnGridReport_Click(object sender, EventArgs e)
        {
            GridReportSortForm frm = new GridReportSortForm();
            frm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
    }
}
