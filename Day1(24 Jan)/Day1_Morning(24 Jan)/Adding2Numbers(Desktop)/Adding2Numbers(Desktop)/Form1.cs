using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding2Numbers_Desktop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Addition of Two Numbers (Desktop) By Varun
            // Varialbe Declaration // User Input
            int fn = Convert.ToInt32(textBox1.Text);
            int sn = Convert.ToInt32(textBox2.Text);
            
            // Logic
            int sum = fn + sn;

            // Print Output
            textBox3.Text = sum.ToString();

        }
    }
}
