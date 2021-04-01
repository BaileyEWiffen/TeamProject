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

        private String user;
        private string[] us = new string[2];
        public F_Home(String u )
        {
            InitializeComponent();
            user = u;
            us = user.Split(',');
            MessageBox.Show("Hello " + us[0] + "!");
        }

        private void BT_ADMN_Click(object sender, EventArgs e)
        {
            F_Admn fu = new F_Admn();
            this.Hide();
            fu.ShowDialog();
            this.Show();
        }

        private void BT_PROC_Click(object sender, EventArgs e)
        {
            F_Proc fp = new F_Proc(user);
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void BT_ACCT_Click(object sender, EventArgs e)
        {
            F_Acct fa = new F_Acct();
            this.Hide();
            fa.ShowDialog();
            this.Show();

        }

        private void BT_REPT_Click(object sender, EventArgs e)
        {
            F_Rept fp = new F_Rept();
            this.Hide();
            fp.ShowDialog();
            this.Show();

        }

      

        private void F_Home_Load(object sender, EventArgs e)
        {
            if(us[0] == "Shift Manager")
            {
                BT_CUST.Hide();
                BT_ADMN.Hide();

            }
            else if (us[0] == "Receptionist")
            {
                BT_CUST.Hide();
                BT_ADMN.Hide();
                BT_PROC.Hide();
                BT_REPT.Hide();

            }
            else if (us[0] == "Technician")
            {
                BT_CUST.Hide();
                BT_ADMN.Hide();
                BT_ACCT.Hide();
                BT_REPT.Hide();
                BT_PAYM.Hide();

            }
        }

        private void BT_CUST_Click(object sender, EventArgs e)
        {
            F_Cust fp = new F_Cust();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void BT_PAYM_Click(object sender, EventArgs e)
        {
            F_Paym fp = new F_Paym();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }
    }
}
