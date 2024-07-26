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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirLineSystemManagment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet5.FLIGHT' table. You can move, or remove it, as needed.
            

            // TODO: This line of code loads data into the 'masterDataSet1.FLIGHT' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=JANASCOMPUTER\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = " INSERT INTO fLIGHT VALUES('" + fLIGHTIDTextBox.Text + "', '" + aDMINIDTextBox.Text+ "', '" + aIRCRAFTIDTextBox.Text + "', '" + aDMINIDTextBox.Text + "', '" + fARETextBox.Text + "' , '"+aRRIVALDATETextBox.Text+ "' , '"+dEPARTUREDATETextBox.Text+ "' , '"+sOURCETextBox.Text+ "' , '"+dESTINATIONTextBox.Text+ "' , '"+aVAILBLESEATSTextBox.Text+ "' , '"+tOTALSEATSTextBox.Text+ "' , '"+aIRCRAFT_IDTextBox.Text+ "' , '"+cLASSTextBox.Text+"')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion was successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.fLIGHTTableAdapter4.Fill(this.masterDataSet5.FLIGHT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=JANASCOMPUTER\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True;Encrypt=False");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE FLIGHT SET FLIGHTID = '" + fLIGHTIDTextBox.Text + "' WHERE SOURCE = '" + sOURCETextBox.Text + "'";
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
            sqlCommand.CommandText = "DELETE FROM FLIGHT WHERE SOURCE = '" + sOURCETextBox.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            MessageBox.Show("welcome to our app!");
        }
    }
}
