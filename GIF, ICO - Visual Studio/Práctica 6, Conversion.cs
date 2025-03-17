using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica__6__Conversion
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(textBox1.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            textBox2.Text = farh1.ToString();
            label2.Text = " Centigrados";
            label5.Text = " Fahrenheint";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(textBox1.Text);
            cent1 = (v1 - 32)*(5.0 / 9.0);
            textBox2.Text = cent1.ToString();
            label2.Text = " Fahrenheint";
            label5.Text = " Centigrados";
        }
    }
}
