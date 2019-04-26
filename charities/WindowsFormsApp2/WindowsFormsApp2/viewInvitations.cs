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
    public partial class viewInvitations : Form
    {
        Controller controllerObj;
        string user_name;
        public viewInvitations(string userName)
        {
            InitializeComponent();
            controllerObj = new Controller();
            user_name = userName;
            setinvitations();            
        }

        private void viewInvitations_Load(object sender, EventArgs e)
        {

        }

        private void setinvitations()
        {
            DataTable dt = controllerObj.SelectRecievedInvitations(user_name);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["donor_ssn"].Visible = false;
            dataGridView1.Columns["campaign_id"].Visible = false;
            dataGridView1.Columns["branch_no"].Visible = false;
            dataGridView1.Columns["charity_id"].Visible = false;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRowCount = -1;
            selectedRowCount =  dataGridView1.CurrentRow.Index;
            if (selectedRowCount > -1) {
               
                controllerObj.UpdatebranchInvitations( Convert.ToUInt16(dataGridView1.Rows[selectedRowCount].Cells[6].Value), //donor ssn
                                                       Convert.ToUInt16(dataGridView1.Rows[selectedRowCount].Cells[7].Value), //campaign_id
                                                       Convert.ToUInt16(dataGridView1.Rows[selectedRowCount].Cells[8].Value), //branch_no
                                                       Convert.ToUInt16(dataGridView1.Rows[selectedRowCount].Cells[9].Value) //charity_id
                                                      ); 
            }
            setinvitations();
        }
    }
}
