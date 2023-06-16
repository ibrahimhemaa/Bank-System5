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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 ob = new Form8();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet2.loan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bankSystemDataSet1.loan' table. You can move, or remove it, as needed.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into take_by (loan_number , SSN)values(" + textBox1.Text + ", " + textBox2.Text + ")";
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Request sent Successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.loanTableAdapter1.Fill(bankSystemDataSet2.loan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var select = "select * from loan";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
