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
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void BT_ADMN_Click(object sender, EventArgs e)
        {

        }

        private void BT_PROC_Click(object sender, EventArgs e)
        {
            F_Proc fp = new F_Proc();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }
    }
}
