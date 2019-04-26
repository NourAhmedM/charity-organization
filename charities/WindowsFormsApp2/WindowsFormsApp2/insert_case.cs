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
    public partial class insert_case : Form
    { Controller controllerObj;
        int dublic;
        public insert_case()
        {
            InitializeComponent();
            controllerObj = new Controller() ;
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("F");
            comboBox2.Items.Add("Single");
            comboBox2.Items.Add("Married");
            comboBox2.Items.Add("Has children");
            
            DataTable dt2 = controllerObj.getCharities(); 
            comboBox4.DataSource = dt2;
            comboBox4.DisplayMember = "CH_NAME";
            comboBox4.ValueMember = "CH_ID";

            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16(comboBox4.SelectedValue));
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "BRANCH_NAME";
            comboBox3.ValueMember = "BRANCH_NO";
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {     if (checkBox1.Checked) dublic = 1;
            else dublic = 0;
            int r=controllerObj.insertcase(Convert.ToInt32(numericUpDown1.Value),textBox1.Text,textBox2.Text, Convert.ToInt32(numericUpDown2.Value),textBox3.Text,Convert.ToChar(comboBox1.SelectedValue),Convert.ToString(comboBox2.SelectedValue),textBox4.Text,textBox5.Text,Convert.ToInt32(comboBox3.SelectedValue),Convert.ToInt32(comboBox4.SelectedValue),textBox6.Text,dublic,richTextBox1.Text);
            if (r > 0)
                MessageBox.Show("case was inserted");
            else

               MessageBox.Show("failed to insert a new case");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToUInt16(comboBox4.SelectedValue));
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "BRANCH_NAME";
            comboBox3.ValueMember = "BRANCH_NO";
        }

       
    }
}
