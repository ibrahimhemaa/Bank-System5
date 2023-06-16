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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into loan (loan_type , loan_number , loan_amount , Branch_number , id)values('" + textBox1.Text + "', " + textBox2.Text + ", " + textBox3.Text + ", " + textBox5.Text + ", " + textBox6.Text + ")";
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("loan Added Successfully");
        }
    }
}
