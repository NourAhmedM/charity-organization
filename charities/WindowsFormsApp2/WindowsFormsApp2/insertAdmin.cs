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
    public partial class insertAdmin : Form
    {
        Controller controllerObj;
        public insertAdmin()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result=controllerObj.insertUserBasic(textBox1.Text,textBox2.Text,0);
            if (result != 0)
                MessageBox.Show("successful adding admin");
            else
                MessageBox.Show("unsuccessful adding admin");

        }
    }
}
