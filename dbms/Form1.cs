using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.modelDataSet.Customers);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.Checked == true)
                genderCheckBox.Text = "Male";
            else if (genderCheckBox.Checked == false)
                genderCheckBox.Text = "Female";

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
