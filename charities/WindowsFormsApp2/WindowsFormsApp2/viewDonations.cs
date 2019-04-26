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
    public partial class viewDonations : Form
    {
        Controller controllerObj;
     
        public viewDonations(string userName)
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectPreviousDonations(userName);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void viewDonations_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
