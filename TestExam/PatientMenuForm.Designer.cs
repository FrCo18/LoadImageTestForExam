namespace TestExam
{
    partial class PatientMenuForm
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.btnGridReport = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(279, 40);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(175, 58);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Профиль";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(279, 104);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(175, 58);
            this.btnGrafic.TabIndex = 1;
            this.btnGrafic.Text = "График";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.Location = new System.Drawing.Point(279, 168);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(175, 58);
            this.btnDataGrid.TabIndex = 2;
            this.btnDataGrid.Text = "DataGrid";
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.Click += new System.EventHandler(this.btnDataGrid_Click);
            // 
            // btnGridReport
            // 
            this.btnGridReport.Location = new System.Drawing.Point(279, 232);
            this.btnGridReport.Name = "btnGridReport";
            this.btnGridReport.Size = new System.Drawing.Size(175, 58);
            this.btnGridReport.TabIndex = 3;
            this.btnGridReport.Text = "Отчёт Grid + сортировка";
            this.btnGridReport.UseVisualStyleBackColor = true;
            this.btnGridReport.Click += new System.EventHandler(this.btnGridReport_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(513, 40);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(175, 58);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Сделать заказ";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // PatientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnGridReport);
            this.Controls.Add(this.btnDataGrid);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.btnProfile);
            this.Name = "PatientMenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.Button btnDataGrid;
        private System.Windows.Forms.Button btnGridReport;
        private System.Windows.Forms.Button btnOrders;
    }
}