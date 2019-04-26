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
    public partial class ViewCharityInfoormation : Form
    {
        Controller controllerObj;
        public ViewCharityInfoormation()
        {
            controllerObj = new Controller();
            InitializeComponent();

            DataTable dt1 = controllerObj.getCharities();
            comboBox1.DataSource = dt1;

            comboBox1.DisplayMember = "CH_NAME";
            comboBox1.ValueMember = "CH_ID";


            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16(comboBox1.SelectedValue));
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "BRANCH_NAME";
            comboBox2.ValueMember = "BRANCH_NO";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16(comboBox1.SelectedValue));
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "BRANCH_NAME";
            comboBox2.ValueMember = "BRANCH_NO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = controllerObj.getInfoOfBranch(Convert.ToUInt16(comboBox1.SelectedValue),
                Convert.ToUInt16(comboBox2.SelectedValue));
            dataGridView2.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.getStockOfSpecificBranch(Convert.ToUInt16(comboBox1.SelectedValue),
                Convert.ToUInt16(comboBox2.SelectedValue));
            dataGridView1.Refresh();
        }

    }
}
