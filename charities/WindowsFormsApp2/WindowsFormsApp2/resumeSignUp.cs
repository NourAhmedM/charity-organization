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
    public partial class resumeSignUp : Form
    {
        Controller controllerObj;
        Privileges priv;
        int SSN;
        public resumeSignUp(Privileges privil,int ssn)
        {
            controllerObj = new Controller();
            priv = privil;
            SSN = ssn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.insertUserBasic(userName.Text, password.Text, Convert.ToInt32(priv));
            if (result != 0)
            {
                MessageBox.Show("successful resume sign up");
                controllerObj.updatedonorbyusername(SSN, userName.Text);
                ////here we should put the main screen according to the priv
                if ((int)priv == 1)
                    new menue1(userName.Text).Show();
                else if ((int)priv == 2)
                    new menue2(userName.Text).Show();
                else if ((int)priv == 3)
                    new menue1(userName.Text).Show();
                
            }
            else
                MessageBox.Show("unsuccessful resume sign up");


        }
    }
}
