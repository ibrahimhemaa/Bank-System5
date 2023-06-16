using System;
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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet2.customer' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bankSystemDataSet1.customer' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bankSystemDataSet.customer' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter2.Fill(this.bankSystemDataSet2.customer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }
    }
}
