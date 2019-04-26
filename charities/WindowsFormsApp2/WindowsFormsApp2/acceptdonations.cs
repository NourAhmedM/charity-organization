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
    public partial class acceptdonations : Form
    {
        Controller controllerObj;
        public acceptdonations()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectAlldonations();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            
        }

        private void acceptdonations_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    int r = controllerObj.acceptdon(Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[0].Value));
                    if (r > 0)

                    {
                        int r1 = controllerObj.instock(Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[0].Value));
                        if (r1 > 0)

                        {

                        }
                        else
                        {

                            int r2 = controllerObj.addqty(Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[0].Value));
                            if (r2 <= 0)
                                MessageBox.Show("failed");

                        }

                        dataGridView1.Rows.Remove(row);
                        
                    }
                    else

                        MessageBox.Show("failed to send");
                }
                
            }



            MessageBox.Show("You have accepted the donation and added them to the stock");
            dataGridView1.Refresh();


        }
    }
}
