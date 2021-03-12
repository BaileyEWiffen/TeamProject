using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bapers
{
    public partial class F_Proc : Form
    {
        public F_Proc()
        {
            InitializeComponent();
        }

        private void F_Proc_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'bapersDataSet.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.bapersDataSet.job);

        }

        private void BT_test_Click(object sender, EventArgs e)
        {
            
            DataRowView d = (DataRowView)B_job.Items[B_job.SelectedIndex];
            LB_test.Text = d.Row["job number"].ToString();
        }
    }
}
