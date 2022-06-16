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
    }
}
