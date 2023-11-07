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
    public partial class Form2 : Form
    {
        Form1 f;
        public Form2(Form1 f)
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
            if ((e.KeyChar < '0' || e.KeyChar > '1') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.Length <= 31)
                label1.Text = BinToDec(textBox1.Text).ToString();
            else
                label1.Text = "-";
        }

        int BinToDec(string bin)
        {
            int vysl = 0;
            try { 
                while(bin.Length > 0)
                {
                    if (bin[0] == '1')
                    {
                        checked { vysl += Pow(2, bin.Length - 1); }
                    }
                    bin = bin.Substring(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return vysl;
        }

        int Pow(int a, int n)
        {
            int vysl = 1;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    vysl *= a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return vysl;
        }
    }
}
