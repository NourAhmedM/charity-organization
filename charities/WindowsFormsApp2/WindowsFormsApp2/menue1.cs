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
    public partial class menue1 : Form
    {
        string user_name;
        public menue1(string username)
        {
            user_name = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertDonation id = new insertDonation(user_name);
            id.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewCases vc = new viewCases(user_name);
            vc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewCharityInfoormation id = new ViewCharityInfoormation();
            id.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewInvitations id = new viewInvitations(user_name);
            id.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new updatePassword(user_name).Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new welcome().Show();
        }
    }
}
