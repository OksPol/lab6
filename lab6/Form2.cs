﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count0 = 0;
            int count1 = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '0')
                    count0++;
                else if (str[i] == '1')
                    count1++;
                i++;
            }
            label1.Text = "Количество 0 = " +
                count0.ToString();
            label2.Text = "Количество 1 = " +
                count1.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
