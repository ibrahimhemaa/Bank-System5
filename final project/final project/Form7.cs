﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 ob = new Form8();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }
    }
}
