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
    public partial class sign_in : Form
    {
        Controller controllerObj;
        public sign_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int login = controllerObj.CheckPassword_Basic(username.Text, password.Text);
            if (login > -1) // Successful Login
            {

               
                //here we should put the main screen according to the priv
                if(login==1)
                    new menue1(username.Text).Show();
                else if(login==2)
                    new menue2(username.Text).Show();
                else if(login==3)
                    new menue1(username.Text).Show();
                else if (login == 0)
                    new menue3(username.Text).Show();
                    
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }     
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
    }
}
