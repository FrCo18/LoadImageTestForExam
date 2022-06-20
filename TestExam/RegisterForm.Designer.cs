namespace TestExam
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label born_dateLabel;
            System.Windows.Forms.Label passport_seriesLabel;
            System.Windows.Forms.Label passport_numberLabel;
            System.Windows.Forms.Label insurance_policyLabel;
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryDataSet = new TestExam.LaboratoryDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new TestExam.LaboratoryDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new TestExam.LaboratoryDataSetTableAdapters.TableAdapterManager();
            this.patientsTableAdapter = new TestExam.LaboratoryDataSetTableAdapters.PatientsTableAdapter();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.born_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.passport_seriesTextBox = new System.Windows.Forms.TextBox();
            this.passport_numberTextBox = new System.Windows.Forms.TextBox();
            this.insurance_policyTextBox = new System.Windows.Forms.TextBox();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            born_dateLabel = new System.Windows.Forms.Label();
            passport_seriesLabel = new System.Windows.Forms.Label();
            passport_numberLabel = new System.Windows.Forms.Label();
            insurance_policyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(57, 123);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(39, 16);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(27, 182);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(69, 16);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "password:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(270, 120);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(67, 16);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(269, 179);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(68, 16);
            last_nameLabel.TabIndex = 6;
            last_nameLabel.Text = "last name:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Location = new System.Drawing.Point(249, 231);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(88, 16);
            middle_nameLabel.TabIndex = 8;
            middle_nameLabel.Text = "middle name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(289, 284);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 16);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(294, 343);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "email:";
            // 
            // born_dateLabel
            // 
            born_dateLabel.AutoSize = true;
            born_dateLabel.Location = new System.Drawing.Point(466, 342);
            born_dateLabel.Name = "born_dateLabel";
            born_dateLabel.Size = new System.Drawing.Size(67, 16);
            born_dateLabel.TabIndex = 14;
            born_dateLabel.Text = "born date:";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(TestExam.Services);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataSource = typeof(TestExam.Patients);
            // 
            // laboratoryDataSet
            // 
            this.laboratoryDataSet.DataSetName = "LaboratoryDataSet";
            this.laboratoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.laboratoryDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministartorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaborantsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestExam.LaboratoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(102, 120);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(102, 179);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.laboratoryDataSet;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(343, 117);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(343, 176);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.last_nameTextBox.TabIndex = 7;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "middle_name", true));
            this.middle_nameTextBox.Location = new System.Drawing.Point(343, 228);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.middle_nameTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(343, 281);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(343, 340);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 13;
            // 
            // born_dateDateTimePicker
            // 
            this.born_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource1, "born_date", true));
            this.born_dateDateTimePicker.Location = new System.Drawing.Point(539, 338);
            this.born_dateDateTimePicker.Name = "born_dateDateTimePicker";
            this.born_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.born_dateDateTimePicker.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(793, 324);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(152, 52);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // passport_seriesLabel
            // 
            passport_seriesLabel.AutoSize = true;
            passport_seriesLabel.Location = new System.Drawing.Point(462, 120);
            passport_seriesLabel.Name = "passport_seriesLabel";
            passport_seriesLabel.Size = new System.Drawing.Size(103, 16);
            passport_seriesLabel.TabIndex = 17;
            passport_seriesLabel.Text = "passport series:";
            // 
            // passport_seriesTextBox
            // 
            this.passport_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "passport_series", true));
            this.passport_seriesTextBox.Location = new System.Drawing.Point(571, 117);
            this.passport_seriesTextBox.Name = "passport_seriesTextBox";
            this.passport_seriesTextBox.Size = new System.Drawing.Size(100, 22);
            this.passport_seriesTextBox.TabIndex = 18;
            // 
            // passport_numberLabel
            // 
            passport_numberLabel.AutoSize = true;
            passport_numberLabel.Location = new System.Drawing.Point(454, 176);
            passport_numberLabel.Name = "passport_numberLabel";
            passport_numberLabel.Size = new System.Drawing.Size(111, 16);
            passport_numberLabel.TabIndex = 19;
            passport_numberLabel.Text = "passport number:";
            // 
            // passport_numberTextBox
            // 
            this.passport_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "passport_number", true));
            this.passport_numberTextBox.Location = new System.Drawing.Point(571, 173);
            this.passport_numberTextBox.Name = "passport_numberTextBox";
            this.passport_numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.passport_numberTextBox.TabIndex = 20;
            // 
            // insurance_policyLabel
            // 
            insurance_policyLabel.AutoSize = true;
            insurance_policyLabel.Location = new System.Drawing.Point(458, 228);
            insurance_policyLabel.Name = "insurance_policyLabel";
            insurance_policyLabel.Size = new System.Drawing.Size(107, 16);
            insurance_policyLabel.TabIndex = 21;
            insurance_policyLabel.Text = "insurance policy:";
            // 
            // insurance_policyTextBox
            // 
            this.insurance_policyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource1, "insurance_policy", true));
            this.insurance_policyTextBox.Location = new System.Drawing.Point(571, 225);
            this.insurance_policyTextBox.Name = "insurance_policyTextBox";
            this.insurance_policyTextBox.Size = new System.Drawing.Size(100, 22);
            this.insurance_policyTextBox.TabIndex = 22;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 515);
            this.Controls.Add(insurance_policyLabel);
            this.Controls.Add(this.insurance_policyTextBox);
            this.Controls.Add(passport_numberLabel);
            this.Controls.Add(this.passport_numberTextBox);
            this.Controls.Add(passport_seriesLabel);
            this.Controls.Add(this.passport_seriesTextBox);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(born_dateLabel);
            this.Controls.Add(this.born_dateDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(middle_nameLabel);
            this.Controls.Add(this.middle_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Name = "RegisterForm";
            this.Text = "Регистрация пациента";
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private LaboratoryDataSet laboratoryDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LaboratoryDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private LaboratoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LaboratoryDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker born_dateDateTimePicker;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox passport_seriesTextBox;
        private System.Windows.Forms.TextBox passport_numberTextBox;
        private System.Windows.Forms.TextBox insurance_policyTextBox;
    }
}