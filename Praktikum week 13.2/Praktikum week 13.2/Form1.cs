using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_week_13._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "[ EMPTY ]")
            {
                label2.Text = textBox1.Text;
            }
            if (label2.Text != "[ EMPTY ]" && textBox1.Text == "DELETE")
            {
                label2.Text = "[ EMPTY ]";
            }
            if (label2.Text != "[ EMPTY ]" && textBox1.Text == "RED")
            {
                label2.ForeColor = Color.Red;
            }
            if (label2.Text != "[ EMPTY ]" && textBox1.Text == "GREEN")
            {
                label2.ForeColor = Color.Green;
            }
            if (label2.Text != "[ EMPTY ]" && textBox1.Text == "BLUE")
            {
                label2.ForeColor = Color.Blue;
            }
            if (label2.Text != "[ EMPTY ]" && textBox1.Text == "HIDE")
            {
                label2.Hide();
            }
            if (label2.Text != "[ EMPTY ]" && textBox1.Text == "SHOWN")
            {
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
