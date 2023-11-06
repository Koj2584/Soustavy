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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            int dec = int.Parse(textBox1.Text);
            List<byte> list = new List<byte>();
            while (dec > 0)
            {
                list.Add(Convert.ToByte(dec % 2));
                dec /= 2;
            }
            list.Reverse();
            foreach(byte b in list)
            {
                label1.Text += b;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||e.KeyChar>'9')&&e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
