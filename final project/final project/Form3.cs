using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Data was successfully inserted");
        }

        
    }
}
