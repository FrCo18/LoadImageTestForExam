using System.Linq;
using System.Windows.Forms;

namespace TestExam
{
    public partial class GridReportSortForm : Form
    {
        public GridReportSortForm()
        {
            InitializeComponent();
            patientsBindingSource.DataSource = Program.app.db.Patients.ToList();
        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (patientsDataGridView.SelectedCells.Count == 1)
            {
                var item = patientsDataGridView.SelectedRows;
                var i = 0;
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            Validate();
            patientsBindingSource.EndEdit();
            patientsTableAdapter1.Update(laboratoryDataSet1);
            Program.app.db.SaveChanges();
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            var patient = patientsBindingSource.Current as Patients;
            Program.app.db.Users.Remove(patient.Users);
            Program.app.db.Patients.Remove(patientsBindingSource.Current as Patients);

            Program.app.db.SaveChanges();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            patientsBindingSource.AddNew();
        }

        private void GridReportSortForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laboratoryDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.laboratoryDataSet1.Users);

        }
    }
}
