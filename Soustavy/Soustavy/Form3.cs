using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soustavy
{
    public partial class Form3 : Form
    {
        Form1 f;
        public Form3(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int dec = -1;
            try
            {
                dec = int.Parse(textBox1.Text);
            }
            catch{ }
            
            if (textBox1.Text.Length > 0 && dec != -1)
                label1.Text = DecToBin(dec);
            else
                label1.Text = "-";
        }

        string DecToBin(int dec)
        {
            string s = "";
            while (dec > 0)
            {
                s = (dec % 2) + s;
                dec /= 2;
            }
            return s;
        }
    }
}
