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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 ob = new Form11();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 ob = new Form13();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 ob = new Form12();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        public static implicit operator Form5(Form8 v)
        {
            throw new NotImplementedException();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form17 ob = new Form17();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 ob = new Form19();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into employyee (Name , id , Branch_number)values('" + textBox1.Text + "', " + textBox2.Text + ", " + textBox3.Text + ")";
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("employee Added Successfully");
        }
    }
}
