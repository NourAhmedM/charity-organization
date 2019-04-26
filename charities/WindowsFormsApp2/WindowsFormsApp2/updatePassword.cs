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
    public partial class updatePassword : Form
    {

        Controller controllerObj;
        string user_name;
        public updatePassword(string username)
        {
            user_name = username;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result=controllerObj.updatepassword(user_name, textBox1.Text);
            if (result != 0)
                MessageBox.Show("password changed successfully");
            else
                MessageBox.Show("password did not change successfully");

        }
    }
}
