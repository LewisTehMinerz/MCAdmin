namespace MCAdmin
{
    partial class frmSync
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSync));
            this.skin = new jSkin.ctlModernBlack();
            this.progSync = new System.Windows.Forms.ProgressBar();
            this.lblSync = new System.Windows.Forms.Label();
            this.skin.SuspendLayout();
            this.SuspendLayout();
            // 
            // skin
            // 
            this.skin.Controls.Add(this.lblSync);
            this.skin.Controls.Add(this.progSync);
            this.skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skin.FixedSingle = true;
            this.skin.Location = new System.Drawing.Point(0, 0);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(501, 91);
            this.skin.Stretch = false;
            this.skin.TabIndex = 0;
            // 
            // progSync
            // 
            this.progSync.Location = new System.Drawing.Point(13, 62);
            this.progSync.Name = "progSync";
            this.progSync.Size = new System.Drawing.Size(476, 17);
            this.progSync.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progSync.TabIndex = 2;
            // 
            // lblSync
            // 
            this.lblSync.AutoSize = true;
            this.lblSync.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSync.Location = new System.Drawing.Point(203, 37);
            this.lblSync.Name = "lblSync";
            this.lblSync.Size = new System.Drawing.Size(108, 13);
            this.lblSync.TabIndex = 3;
            this.lblSync.Text = "Syncing with server...";
            // 
            // frmSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 91);
            this.Controls.Add(this.skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSync";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSync_FormClosing);
            this.skin.ResumeLayout(false);
            this.skin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack skin;
        private System.Windows.Forms.Label lblSync;
        private System.Windows.Forms.ProgressBar progSync;
    }
}