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
    public partial class insertcharity : Form
    {
        Controller controllerObj;
        public insertcharity()
        {
            InitializeComponent();

            controllerObj = new Controller();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.insertcharity(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, dateTimePicker1.Value);
            if (r > 0)
                MessageBox.Show("Charity inserted successfully");
            else
                MessageBox.Show("Error inserting charity");
            
        }

        private void insertcharity_Load(object sender, EventArgs e)
        {

        }
    }
}
