﻿using System;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 ob = new Form15();
            if (ob == null)
            {
                ob.Parent = this;

            }
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into Branch (Branch_number , Address , Code)values('" + textBox1.Text + "', '" + textBox2.Text + "', " + textBox3.Text + ")";
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Branch Added Successfully");
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }
    }
}
