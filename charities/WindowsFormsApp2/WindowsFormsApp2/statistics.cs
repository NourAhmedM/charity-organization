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
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DAT.charity_org' table. You can move, or remove it, as needed.
            this.charity_orgTableAdapter.Fill(this.DAT.charity_org);
            // TODO: This line of code loads data into the 'DAT.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.DAT.stock);
            // TODO: This line of code loads data into the 'DAT.Volunteer' table. You can move, or remove it, as needed.
            this.VolunteerTableAdapter.Fill(this.DAT.Volunteer);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
