using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class viewCases : Form
    {
        Controller controllerObj; // declare an object to class controller
        string USERNAME;
        public viewCases(string userName)
        {
            InitializeComponent();
            USERNAME = userName;

            controllerObj = new Controller();  // initialize the controllerObj
            DataTable dt = controllerObj.SelectCharityNum_and_Name();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CH_NAME";
            comboBox1.ValueMember = "CH_ID";
            
        }

        private void viewCases_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewCases(Convert.ToUInt16(comboBox1.SelectedValue), Convert.ToUInt16(comboBox2.SelectedValue));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["SSN"].Visible = false;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d_ssn = controllerObj.getDonorSSN(USERNAME);

            int selectedRowCount = -1;
            selectedRowCount = dataGridView1.CurrentRow.Index;
            if (selectedRowCount > -1)
            {
                controllerObj.InsertCaseDonation( d_ssn, Convert.ToInt32(dataGridView1.Rows[selectedRowCount].Cells[10].Value) );

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16(comboBox1.SelectedValue));
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "BRANCH_NAME";
            comboBox2.ValueMember = "BRANCH_NO";
        }
    }
}
