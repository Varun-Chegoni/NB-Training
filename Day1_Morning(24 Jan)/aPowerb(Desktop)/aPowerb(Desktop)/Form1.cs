using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aPowerb_Desktop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Print Power of Base and Exponent Numbers(Desktop) By Varun
            // Varialbe Declaration // User Input
            int p = 1;
            int b = Convert.ToInt32(textBox1.Text);
            int ex = Convert.ToInt32(textBox2.Text);

            // Logic
            for (int i = 1; i <= ex; i++)
                p = p * b;

            // Print Output
            Console.WriteLine("Power = " + p);
            textBox3.Text = p.ToString();
        }
    }
}
