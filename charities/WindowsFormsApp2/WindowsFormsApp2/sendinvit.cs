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
    public partial class sendinvit : Form
    {
        Controller controllerObj;
        public sendinvit()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt2 = controllerObj.getCharities();
            DataTable dt = controllerObj.getdonor();
           
            comboBox5.DataSource = dt2;
            comboBox3.DataSource = dt;
            

            comboBox5.DisplayMember = "CH_NAME";
            comboBox5.ValueMember = "CH_ID";
            comboBox3.DisplayMember = "lname";
            comboBox3.ValueMember = "ssn";
            
        }

        private void sendinvit_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            int r = controllerObj.sendinv(Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox5.SelectedValue));
             if (r > 0)

               MessageBox.Show("you succesfully sent the invitaion");
            else

                MessageBox.Show("you've already sent the invitation");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dt3 = controllerObj.getevent(Convert.ToInt32(comboBox5.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
            comboBox4.DataSource = dt3;
            
            comboBox4.DisplayMember = "campaign_name";
            comboBox4.ValueMember = "campaign_id";
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "ADRESS";
            comboBox2.ValueMember = "BRANCH_NO";
            DataTable dt = controllerObj.getbranchesforcharity(Convert.ToInt32(comboBox5.SelectedValue));
            comboBox2.DataSource = dt;
            
        }
    }
}
