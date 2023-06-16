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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into customer (FristName, LastName, Address , SSN , id , phone)values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "'," + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ")";
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Customer Added Successfully");
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
