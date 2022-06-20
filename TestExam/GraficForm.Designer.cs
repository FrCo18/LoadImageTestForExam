namespace TestExam
{
    partial class GraficForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(117, 45);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(550, 252);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "График функции y=sin(x)";
            title1.Name = "Title1";
            title1.Text = "График функции y=sin(x)";
            this.chart1.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericA
            // 
            this.numericA.DecimalPlaces = 2;
            this.numericA.Location = new System.Drawing.Point(12, 345);
            this.numericA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericA.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(120, 22);
            this.numericA.TabIndex = 2;
            // 
            // numericB
            // 
            this.numericB.DecimalPlaces = 2;
            this.numericB.Location = new System.Drawing.Point(172, 345);
            this.numericB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericB.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(120, 22);
            this.numericB.TabIndex = 3;
            // 
            // numericH
            // 
            this.numericH.DecimalPlaces = 2;
            this.numericH.Location = new System.Drawing.Point(340, 345);
            this.numericH.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericH.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(120, 22);
            this.numericH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "H";
            // 
            // GraficForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericH);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "GraficForm";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}