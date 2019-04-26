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
   
    public partial class signUpDonor : Form
    {

        Controller controllerObj;
        Privileges priv;
        

        public signUpDonor(Privileges privil)
        {
            InitializeComponent();
            priv = privil;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            int result=controllerObj.insertDonor(Convert.ToInt32(ssn.Text),firstName.Text,lastName.Text,address.Text
                ,email.Text,DateOfBirth.Value,Convert.ToInt32( phoneNumber.Text),job.Text
                ,marriageStatus.SelectedValue.ToString()
                ,studyStage.SelectedValue.ToString(),maleradioButton.Checked?"M":"F",Convert.ToUInt16( age.Text));
            if (result != 0)
            {
                MessageBox.Show("successful sign up");
                if (priv == (Privileges)2)
                {
                    result = controllerObj.insertVolunteer(Convert.ToInt32(ssn.Text));
                    if (result != 0)
                        MessageBox.Show("successful sign up volunteer");
                    else
                        MessageBox.Show("unsuccessful sign up volunteer");
                }
                resumeSignUp rs = new resumeSignUp(priv, Convert.ToInt32(ssn.Text));
                rs.Show();

            }
            else
                MessageBox.Show("unsuccessful sign up");
            
            

           
        }

        private void signUpDonor_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string[] DmarrigeStatus = new string[] {"Single","Married"};
            marriageStatus.DataSource = DmarrigeStatus;

            string[] DstudyStage = new string[] { "primary school", "prep school" ,"secondary school","college","other"};
            studyStage.DataSource = DstudyStage;

            

        }

       

        
    }
}
