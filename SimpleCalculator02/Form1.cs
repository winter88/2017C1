﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetResult(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetResult(int i)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            switch (i)
            {
                case 1:
                    label1.Text = (x + y).ToString();
                    break;
                case 2:
                    label1.Text = (x - y).ToString();
                    break;
                case 3:
                    label1.Text = (x * y).ToString();
                    break;
                case 4:
                    label1.Text = (x / y).ToString();
                    break;

            }
            /*if (i)
            {
                label1.Text = (x + y).ToString();
            }
            else
            {
                label1.Text = (x - y).ToString();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetResult(2);
        }
    }
}
