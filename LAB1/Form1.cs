using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chislo_1 = Convert.ToInt32(textBox3.Text);
            int chislo_2 = Convert.ToInt32(textBox2.Text);
            int chislo_3 = Convert.ToInt32(textBox1.Text);
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            if (chislo_1 == 0 || chislo_2 == 0 || chislo_3 == 0)
            {
                label1.Text = "Треугольника не существует";
            }
            else if (chislo_1 == chislo_2 && chislo_2 == chislo_3 && chislo_3 == chislo_1)
            {
                label1.Text = "Треугольник равносторонний";
            }
            else if (chislo_1 == chislo_2 || chislo_2 == chislo_3 || chislo_3 == chislo_1)
            { 
                label1.Text = "Треугольник равнобедренный";
            }
            else
            {
                label1.Text = "Треугольник разносторонний";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
