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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nATIONALITYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nATIONALITYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet9);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet9.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.masterDataSet9.CUSTOMER);
            // TODO: This line of code loads data into the 'masterDataSet9.NATIONALITY' table. You can move, or remove it, as needed.
            this.nATIONALITYTableAdapter.Fill(this.masterDataSet9.NATIONALITY);

        }
    }
}
