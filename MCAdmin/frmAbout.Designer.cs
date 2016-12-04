namespace MCAdmin
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.skin = new jSkin.ctlModernBlack();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBanner = new System.Windows.Forms.PictureBox();
            this.skin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // skin
            // 
            this.skin.Controls.Add(this.btnClose);
            this.skin.Controls.Add(this.lblAbout);
            this.skin.Controls.Add(this.pictureBanner);
            this.skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skin.FixedSingle = true;
            this.skin.Location = new System.Drawing.Point(0, 0);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(579, 284);
            this.skin.Stretch = false;
            this.skin.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbout.Location = new System.Drawing.Point(10, 134);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(557, 109);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "MCAdmin\r\nA Minecraft server wrapper that helps you administrate your server.\r\n\r\nV" +
    "ersion 1.0 - Built in 2016\r\nBuilt with love by LewisTehMinerz\r\nBanner by Plaguef" +
    "ox";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBanner
            // 
            this.pictureBanner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBanner.Image")));
            this.pictureBanner.Location = new System.Drawing.Point(10, 33);
            this.pictureBanner.Name = "pictureBanner";
            this.pictureBanner.Size = new System.Drawing.Size(557, 99);
            this.pictureBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBanner.TabIndex = 2;
            this.pictureBanner.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 284);
            this.Controls.Add(this.skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About MCAdmin";
            this.skin.ResumeLayout(false);
            this.skin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack skin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pictureBanner;
    }
}