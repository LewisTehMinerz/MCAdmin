using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAdmin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("java", "-jar server.jar nogui");
            startInfo.WorkingDirectory = Application.StartupPath;
            startInfo.RedirectStandardInput = startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process ServerProc = new Process();
            ServerProc.StartInfo = startInfo;
            ServerProc.EnableRaisingEvents = true;
            ServerProc.Exited += new EventHandler(ServerProc_Exited);

            ServerProc.Start();
            ServerProc.BeginErrorReadLine();

            
        }

        private void ServerProc_Exited(object sender, EventArgs e)
        {
            
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            frmServerWizard wizard = new frmServerWizard();
            wizard.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
