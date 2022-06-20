using System;
using System.Windows.Forms;

namespace TestExam
{
    public partial class GraficForm : Form
    {
        public GraficForm()
        {
            InitializeComponent();

            numericA.Controls[0].Visible = false;
            numericB.Controls[0].Visible = false;
            numericH.Controls[0].Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = ((double)numericA.Value);
            double b = ((double)numericB.Value);
            double h = ((double)numericH.Value);
            double x, y;

            chart1.Series[0].Points.Clear();

            if (a != 0 && b != 0 && h >= 0) {
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }

        }
    }
}
