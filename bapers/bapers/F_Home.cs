﻿using System;
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
        public F_Home(String u )
        {
            InitializeComponent();
            user = u;
            //MessageBox.Show("Hello " + user + "!");
        }

        private void BT_ADMN_Click(object sender, EventArgs e)
        {
            F_UserSearch fu = new F_UserSearch();
            this.Hide();
            fu.ShowDialog();
            this.Show();
        }

        private void BT_PROC_Click(object sender, EventArgs e)
        {
            F_Proc fp = new F_Proc();
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
            F_CustCreation fc = new F_CustCreation();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }
    }
}
