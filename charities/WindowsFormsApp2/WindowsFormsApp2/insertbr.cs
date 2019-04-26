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
    public partial class insertbr : Form
    {
        Controller controllerObj;
        public insertbr()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt2 = controllerObj.getCharities();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "CH_NAME";
            comboBox1.ValueMember = "CH_ID";
        }

        private void insertbr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.insertbranch(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToString(textBox4.Text), Convert.ToString(textBox2.Text), Convert.ToInt32(textBox1.Text));
            if (r > 0)

                MessageBox.Show("you succesfully inserted a branch");
            else

                MessageBox.Show("please fill all of the boxes");
        }
    }
}
