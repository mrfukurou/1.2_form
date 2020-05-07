using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            double c = Convert.ToDouble(C.Text);
            if((a + b > c) && (b + c > a) && (c + a > b))
            Rez.Text = Convert.ToString("Такой треугольник существует");
            else Rez.Text = Convert.ToString("Такой треугольник не существует");

        }
    }
}
