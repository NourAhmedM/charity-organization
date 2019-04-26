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
    public partial class insertDonation : Form
    {   
        
        // to inable the button if all are checked
       
        int donationID = 0;
        Controller controllerObj;
        string USERNAME;

        public insertDonation(string userName)
        {
            InitializeComponent();
            USERNAME = userName;
            button1.Enabled = true;
            controllerObj = new Controller();  // initialize the controllerObj
            DataTable dt = controllerObj.SelectCharityNum_and_Name();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CH_NAME";
            comboBox1.ValueMember = "CH_ID";


            comboBox3.DataSource = new string[] { "Clothes", "Food", "Marriage Support", "Money"};
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                button1.Enabled = true;
                int donor_ssn = controllerObj.getDonorSSN(USERNAME);
                DateTime now = DateTime.Now;
                DateTime date = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                donationID = controllerObj.MaxDonationID() + 1;
                int check = controllerObj.InsertDonation( donor_ssn, donationID, date,
                                              Convert.ToUInt16(comboBox2.SelectedValue),
                                              Convert.ToUInt16(comboBox1.SelectedValue));
              
                if (check > 0)
                    MessageBox.Show("donation request has been sent");
                else
                    MessageBox.Show("please check that you entered all the required values");

               
                int textBoxValue = 0;
                if (int.TryParse(textBox1.Text, out textBoxValue ))
                {
                    textBoxValue = Convert.ToInt16( textBox1.Text.ToString());
                    
                }
                controllerObj.InsertKindOfDonation(donor_ssn, donationID,
                                                   (comboBox3.SelectedValue).ToString(),
                                                   (comboBox4.SelectedValue).ToString(),
                                                   textBoxValue);
                // donationID++;
              
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0) // selecteditem
                 comboBox4.DataSource = new string[] { "children wear", "Women wear", "Men wear" };
            else if (comboBox3.SelectedIndex == 1)
                comboBox4.DataSource = new string[] { "oil", "rice","sugar","meat" };
                
            else if (comboBox3.SelectedIndex == 2)
                 comboBox4.DataSource = new string[] { "fridge", "oven", "furniture" }; 
            else if (comboBox3.SelectedIndex == 3)
                comboBox4.DataSource = new string[] { "-" };

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectbranchNum_and_Name(Convert.ToInt32(comboBox1.SelectedValue));
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "BRANCH_NAME";
            comboBox2.ValueMember = "BRANCH_NO";
        }

        private void insertDonation_Load(object sender, EventArgs e)
        {

        }
    }
}
