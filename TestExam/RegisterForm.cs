using System;
using System.Linq;
using System.Windows.Forms;
using TestExam.Helpers;

namespace TestExam
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.login = loginTextBox.Text;
            user.password = passwordTextBox.Text;
            user.type = "patient";


            Patients patient = new Patients();

            Program.app.db.Users.Add(user);

            if (emailTextBox.Text != "")
            {
                if (StringHelper.isEmail(emailTextBox.Text))
                {
                    patient.email = emailTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Не правильно введён email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (phoneTextBox.Text != "")
            {
                if (StringHelper.isNumber(phoneTextBox.Text))
                {
                    patient.phone = phoneTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Не правильно введён телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            patient.passport_series = passport_seriesTextBox.Text ?? null;
            patient.passport_number = passport_numberTextBox.Text ?? null;
            patient.insurance_policy = insurance_policyTextBox.Text ?? null;
            patient.born_date = born_dateDateTimePicker.Value.Date;
            patient.first_name = first_nameTextBox.Text ?? null;
            patient.last_name = last_nameTextBox.Text ?? null;
            patient.middle_name = middle_nameTextBox.Text ?? null;

            Program.app.db.SaveChanges();

            user = Program.app.db.Users.Where(
                u => u.login == loginTextBox.Text && u.password == passwordTextBox.Text
                ).ToList()[0] ?? null;

            if (user != null)
            {
                patient.id_user = user.id;
            }
            else
            {
                MessageBox.Show("Ошибка решистрации", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Program.app.db.Patients.Add(patient);
            Program.app.db.SaveChanges();

            MessageBox.Show("Регистрация прошла успешно!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
