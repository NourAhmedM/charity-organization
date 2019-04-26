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
    public partial class menue3 : Form
    {
        string user_name;
        public menue3(string username)
        {
            user_name = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new insert_case().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new insertcharity().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Create_Events().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Create_Events().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new sendinvit().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new acceptdonations().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new insertAdmin().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new updatePassword(user_name).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new insertbr().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new welcome().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new statistics().Show();
        }
    }
}
