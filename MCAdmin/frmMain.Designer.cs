namespace MCAdmin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.skin = new jSkin.ctlModernBlack();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnNewServer = new System.Windows.Forms.Button();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.skin.SuspendLayout();
            this.SuspendLayout();
            // 
            // skin
            // 
            this.skin.Controls.Add(this.btnSendCommand);
            this.skin.Controls.Add(this.btnAbout);
            this.skin.Controls.Add(this.btnNewServer);
            this.skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skin.FixedSingle = false;
            this.skin.Location = new System.Drawing.Point(0, 0);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(731, 385);
            this.skin.Stretch = false;
            this.skin.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(644, 36);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnNewServer
            // 
            this.btnNewServer.Location = new System.Drawing.Point(530, 36);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(108, 23);
            this.btnNewServer.TabIndex = 2;
            this.btnNewServer.Text = "Create New Server";
            this.btnNewServer.UseVisualStyleBackColor = true;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(644, 350);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(75, 23);
            this.btnSendCommand.TabIndex = 4;
            this.btnSendCommand.Text = "Send";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 385);
            this.Controls.Add(this.skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCAdmin";
            this.skin.ResumeLayout(false);
            this.skin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack skin;
        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSendCommand;
    }
}

