namespace TestExam
{
    partial class OrdersForm
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
            System.Windows.Forms.Label created_atLabel;
            System.Windows.Forms.Label finish_atLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.lvOrders = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.created_at = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finish_at = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.laborant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.created_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finish_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbxServices = new System.Windows.Forms.ComboBox();
            this.cbxLaborants = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            created_atLabel = new System.Windows.Forms.Label();
            finish_atLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // created_atLabel
            // 
            created_atLabel.AutoSize = true;
            created_atLabel.Location = new System.Drawing.Point(35, 96);
            created_atLabel.Name = "created_atLabel";
            created_atLabel.Size = new System.Drawing.Size(70, 16);
            created_atLabel.TabIndex = 2;
            created_atLabel.Text = "created at:";
            // 
            // finish_atLabel
            // 
            finish_atLabel.AutoSize = true;
            finish_atLabel.Location = new System.Drawing.Point(51, 152);
            finish_atLabel.Name = "finish_atLabel";
            finish_atLabel.Size = new System.Drawing.Size(54, 16);
            finish_atLabel.TabIndex = 3;
            finish_atLabel.Text = "finish at:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 225);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 16);
            label1.TabIndex = 6;
            label1.Text = "service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(51, 277);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 16);
            label2.TabIndex = 8;
            label2.Text = "laborant";
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.created_at,
            this.finish_at,
            this.service,
            this.laborant,
            this.upc});
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(476, 62);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(561, 280);
            this.lvOrders.TabIndex = 0;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.SelectedIndexChanged += new System.EventHandler(this.lvOrders_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // created_at
            // 
            this.created_at.Text = "Дата создания";
            this.created_at.Width = 118;
            // 
            // finish_at
            // 
            this.finish_at.Text = "Дата завершения";
            this.finish_at.Width = 119;
            // 
            // service
            // 
            this.service.Text = "Услуга";
            this.service.Width = 87;
            // 
            // laborant
            // 
            this.laborant.Text = "Лаборант";
            this.laborant.Width = 98;
            // 
            // upc
            // 
            this.upc.Text = "UPC";
            // 
            // created_atDateTimePicker
            // 
            this.created_atDateTimePicker.Location = new System.Drawing.Point(111, 92);
            this.created_atDateTimePicker.Name = "created_atDateTimePicker";
            this.created_atDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.created_atDateTimePicker.TabIndex = 3;
            // 
            // finish_atDateTimePicker
            // 
            this.finish_atDateTimePicker.Location = new System.Drawing.Point(111, 148);
            this.finish_atDateTimePicker.Name = "finish_atDateTimePicker";
            this.finish_atDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.finish_atDateTimePicker.TabIndex = 4;
            // 
            // cbxServices
            // 
            this.cbxServices.FormattingEnabled = true;
            this.cbxServices.Location = new System.Drawing.Point(111, 222);
            this.cbxServices.Name = "cbxServices";
            this.cbxServices.Size = new System.Drawing.Size(200, 24);
            this.cbxServices.TabIndex = 5;
            // 
            // cbxLaborants
            // 
            this.cbxLaborants.FormattingEnabled = true;
            this.cbxLaborants.Location = new System.Drawing.Point(111, 274);
            this.cbxLaborants.Name = "cbxLaborants";
            this.cbxLaborants.Size = new System.Drawing.Size(200, 24);
            this.cbxLaborants.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(651, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 58);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 58);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(812, 424);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(155, 58);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 534);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(label2);
            this.Controls.Add(this.cbxLaborants);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbxServices);
            this.Controls.Add(finish_atLabel);
            this.Controls.Add(this.finish_atDateTimePicker);
            this.Controls.Add(created_atLabel);
            this.Controls.Add(this.created_atDateTimePicker);
            this.Controls.Add(this.lvOrders);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader created_at;
        private System.Windows.Forms.ColumnHeader finish_at;
        private System.Windows.Forms.ColumnHeader service;
        private System.Windows.Forms.ColumnHeader laborant;
        private System.Windows.Forms.DateTimePicker created_atDateTimePicker;
        private System.Windows.Forms.DateTimePicker finish_atDateTimePicker;
        private System.Windows.Forms.ComboBox cbxServices;
        private System.Windows.Forms.ComboBox cbxLaborants;
        private System.Windows.Forms.ColumnHeader upc;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
    }
}