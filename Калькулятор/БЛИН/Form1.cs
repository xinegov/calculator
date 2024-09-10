using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double epsilon = 0.0000001; //Точность

            double poexala = BisectionMethod(a, b, epsilon);
            textBox4.Text = poexala.ToString();
        }
        public double Function(double x)
        {
            return x * x * x - 5 * x + 4; //Уравнение
        }

        private double BisectionMethod(double a, double b, double epsilon)
        {
            double fa = Function(a);
            double fb = Function(b);

            if (fa * fb >= 0)
            {
                textBox3.Text = "Корней";
                textBox3.BackColor = BackColor;
                textBox3.BorderStyle = BorderStyle.None;
                return 0;
            }
            double c;
            while (Math.Abs(b - a) >= epsilon)
            {
                    c = (a + b) / 2;
                    double fc = Function(c);

                    if (fc == 0)
                        break;
                    else if (fa * fc < 0)
                        b = c;
                    else
                        a = c;
            }
            return (a + b) / 2;
        }
    }
}
