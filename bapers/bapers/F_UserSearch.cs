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
    public partial class F_UserSearch : Form
    {
        public F_UserSearch()
        {
            InitializeComponent();
        }

        private void BT_newUser_Click(object sender, EventArgs e)
        {
            F_NewUser nu = new F_NewUser();
            this.Hide();
            nu.ShowDialog();
            this.Show();
        }
    }
}
