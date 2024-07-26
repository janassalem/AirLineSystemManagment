using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineSystemManagment
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet10.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.masterDataSet10.ADMIN);
            // TODO: This line of code loads data into the 'masterDataSet10.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter1.Fill(this.masterDataSet10.FLIGHT);
            // TODO: This line of code loads data into the 'masterDataSet9.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.masterDataSet9.FLIGHT);
            // TODO: This line of code loads data into the 'masterDataSet9.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.masterDataSet9.BOOKS);
            // TODO: This line of code loads data into the 'masterDataSet9.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.masterDataSet9.BOOK);

        }

        private void masterDataSet10BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
