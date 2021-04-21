using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class zad16 : Form
    {
        public zad16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string reverseStr = "";
            label1.Text = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i]; 
            }
            if (str == reverseStr)
            {
                label1.Text = "Палиндром!";
            }
            else
            {
                label1.Text = "Не палиндром!";
            }
        }
    }
}
