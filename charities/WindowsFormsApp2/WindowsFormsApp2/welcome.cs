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
    public enum Privileges
    {
        ADMIN = 0,
        DONOR = 1,
        VOLUNTEER = 2,
        SPONSOR = 3
    }
    public partial class welcome : Form
    {
        
        //type is one if the button pressed is volunteer and zero if it is donor
        Privileges priv;
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            priv = (Privileges)1;

            signUpDonor donor = new signUpDonor(priv);
            donor.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            priv = (Privileges)2;
            signUpDonor volunteer = new signUpDonor(priv);
            volunteer.Show();
        }

        private void signUpAsSponsor_Click(object sender, EventArgs e)
        {
            priv = (Privileges)3;
            signAsSponsor sponsor=new signAsSponsor(priv);
            sponsor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign_in si = new sign_in();
            si.Show();
        }
    }
}
