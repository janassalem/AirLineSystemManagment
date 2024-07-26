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



namespace AirLineSystemManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=JANASCOMPUTER\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " INSERT INTO ADMIN VALUES('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"', '"+textBox6.Text+"')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion was successfully completed");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.ADMIN' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'masterDataSet.ADMIN' table. You can move, or remove it, as needed.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=JANASCOMPUTER\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True;Encrypt=False");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE ADMIN SET USERNAME = '" + textBox3.Text + "' WHERE AGE = '" + textBox6.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update was successfully completed");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=JANASCOMPUTER\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True;Encrypt=False");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM ADMIN WHERE USERNAME = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.aDMINTableAdapter1.Fill(this.masterDataSet1.ADMIN);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            MessageBox.Show("welcome to our app!");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            MessageBox.Show("welcome to our app!");
        }
    }
}
