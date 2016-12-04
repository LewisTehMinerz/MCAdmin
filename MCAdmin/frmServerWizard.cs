using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAdmin
{
    public partial class frmServerWizard : Form
    {
        public frmServerWizard()
        {
            InitializeComponent();
            comboServerType.SelectedIndex = 0;
        }

        private static bool combo = false;
        private static bool text = false;

        private void comboServerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboServerType.SelectedIndex == 0)
            {
                combo = false;
            } else if (comboServerType.SelectedIndex == 1)
            {
                MessageBox.Show("This server is not fully supported, as MCAdmin cannot run its own tools on it. Use at your own risk. (Currently can only support Minecraft 1.11)", "MCAdmin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combo = true;
            } else
            {
                combo = true;
            }
            btnCreate.Enabled = combo && text ? true : false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            if (txtServerName.Text != "")
            {
                text = true;
            } else
            {
                text = false;
            }
            btnCreate.Enabled = combo && text ? true : false;
        }
    }
}
