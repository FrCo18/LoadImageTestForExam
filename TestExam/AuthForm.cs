using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestExam
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            txtLogin.Text = "nmably1";
            txtPassword.Text = "ukM0e6";
            //txtPassword.Text = "dadadawdkawda";
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string email = txtLogin.Text;

            var users = Program.app.db.Users.Where(
                u => u.login == txtLogin.Text && u.password == txtPassword.Text
                ).ToList();


            if (users.Count() != 0)
            {
                Users user = users[0];
                if (user.type == "patient")
                {
                    var patient = Program.app.db.Patients.Where(
                        p => p.id_user == user.id
                        ).ToList();

                    Program.app.patient = patient[0];
                    PatientMenuForm patientForm = new PatientMenuForm();
                    patientForm.Show();
                }
                else if (user.type == "laborant")
                {

                }
            }
            else
            {
                MessageBox.Show("Не верны имя пользователя или пароль!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //PatientMenuForm patientForm = new PatientMenuForm();
            //patientForm.Show();
        }

        private void btnShowPass_Click(object sender, System.EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = txtPassword.UseSystemPasswordChar ? false : true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
