using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica__4__Cilindro
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radius, Height;
            double BArea, LArea, TotArea;
            double Volumen;

            Radius = double.Parse(textBox1.Text);
            Height = double.Parse(textBox2.Text);

            BArea = Radius * Radius + Math.PI;
            LArea = 2 * Math.PI * Radius * Height;
            TotArea = 2 * Math.PI * Radius * (Height + Radius);
            Volumen = Math.PI * Radius * Radius * Height;

            textBox3.Text = BArea.ToString("0.##");
            textBox4.Text = LArea.ToString("0.##");
            textBox5.Text = TotArea.ToString("0.##");
            textBox6.Text = Volumen.ToString("0.##");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
