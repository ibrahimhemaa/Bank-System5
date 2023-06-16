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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var select = "select Branch_number from Branch except (select employyee.Branch_number from(employyee inner join customer on employyee.id = customer.id))";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var select = "select Branch_number from Branch except (select Branch_number from employyee )";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView3.ReadOnly = true;
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var select = "SELECT id, COUNT(id) as number_of_loans FROM loan  GROUP BY id having count(id) = (select max(loan.mycount)from(select  id, count(id) as mycount from loan group by id)loan); ";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView5.ReadOnly = true;
            dataGridView5.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var select = "SELECT SSN, COUNT(SSN) as number_of_loans FROM take_by  GROUP BY SSN having count(SSN) = (select max(take_by.mycount)from(select  SSN, count(SSN) as mycount from take_by group by SSN)take_by);";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var select = "select * from customer where SSN IN (select SSN from customer except select SSN from take_by);";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView4.ReadOnly = true;
            dataGridView4.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var select = "SELECT FristName, LastName,Address, SSN, phone,count(id) as Emp_num FROM CUSTOMER GROUP BY id, SSN, FristName, LastName, phone, Address";
            var c = new SqlConnection("Data Source=LAPTOP-O9LVC43D\\MSSQL;Initial Catalog=BankSystem;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView6.ReadOnly = true;
            dataGridView6.DataSource = ds.Tables[0];
        }
    }
}
