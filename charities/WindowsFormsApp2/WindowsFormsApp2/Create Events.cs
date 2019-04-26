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
    public partial class Create_Events : Form
    { Controller controllerObj;
        public Create_Events()
        {
            InitializeComponent();
            controllerObj = new Controller();
            
            DataTable dt2 = controllerObj.getCharities();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "CH_NAME";
            comboBox2.ValueMember = "CH_ID";

            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16( comboBox2.SelectedValue));
            comboBox1.DataSource=dt;
            comboBox1.DisplayMember = "BRANCH_NAME";
            comboBox1.ValueMember = "branch_no";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Create_Events_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int r= controllerObj.createevent(Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(comboBox2.SelectedValue),textBox2.Text, textBox1.Text, richTextBox1.Text, dateTimePicker1.Value,dateTimePicker2.Value);
            if (r > 0)
                MessageBox.Show("campaign created");
            else
                MessageBox.Show("failed to create campaign");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16(comboBox2.SelectedValue));
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "BRANCH_NAME";
            comboBox1.ValueMember = "branch_no";
        }
    }
}
