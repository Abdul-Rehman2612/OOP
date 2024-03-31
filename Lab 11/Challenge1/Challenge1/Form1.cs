using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.BackColor==Color.Red)
            {
                textBox1.BackColor = Color.Green;
            }
            else if (textBox1.BackColor==Color.Green)
            {
                textBox1.BackColor = Color.Blue;
            }
            else if (textBox1.BackColor==Color.Blue)
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor==Color.Red)
            {
                textBox1.BackColor = Color.Blue;
            }
            else if (textBox1.BackColor==Color.Blue)
            {
                textBox1.BackColor = Color.Green;
            }
            else if (textBox1.BackColor==Color.Green)
            {
                textBox1.BackColor = Color.Red;
            }
        }
    }
}
