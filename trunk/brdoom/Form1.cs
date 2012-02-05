using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrDOOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mtbIpAddress.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtbPlayers.Enabled = false;
            mtbFragLimit.Enabled = false;
            mtbTimeLimit.Enabled = false;
            mtbIpAddress.Enabled = false;
        }

        private void cbHost_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHost.Checked)
            {
                mtbPlayers.Enabled = true;
                mtbFragLimit.Enabled = true;
                mtbTimeLimit.Enabled = true;
                mtbIpAddress.Enabled = true;
            }
            else
            {
                mtbPlayers.Enabled = false;
                mtbFragLimit.Enabled = false;
                mtbTimeLimit.Enabled = false;
                mtbIpAddress.Enabled = false;
            }
        }

        private void rbCooperative_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCooperative.Checked)
            {
                
            }
        }

    }
}
