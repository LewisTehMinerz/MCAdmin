namespace MCAdmin
{
    partial class frmServerWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerWizard));
            this.skin = new jSkin.ctlModernBlack();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.comboServerType = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.skin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // skin
            // 
            this.skin.Controls.Add(this.txtServerName);
            this.skin.Controls.Add(this.btnCancel);
            this.skin.Controls.Add(this.btnCreate);
            this.skin.Controls.Add(this.lblName);
            this.skin.Controls.Add(this.lblSelect);
            this.skin.Controls.Add(this.comboServerType);
            this.skin.Controls.Add(this.lblInfo);
            this.skin.Controls.Add(this.picLogo);
            this.skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skin.FixedSingle = true;
            this.skin.Location = new System.Drawing.Point(0, 0);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(622, 379);
            this.skin.Stretch = false;
            this.skin.TabIndex = 0;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(301, 293);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(234, 20);
            this.txtServerName.TabIndex = 7;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(316, 344);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(298, 273);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Server Name:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelect.Location = new System.Drawing.Point(58, 273);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(74, 13);
            this.lblSelect.TabIndex = 5;
            this.lblSelect.Text = "Select Server:";
            // 
            // comboServerType
            // 
            this.comboServerType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboServerType.DisplayMember = "0";
            this.comboServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServerType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboServerType.FormattingEnabled = true;
            this.comboServerType.Items.AddRange(new object[] {
            "Select a server...",
            "Vanilla",
            "Spigot",
            "CraftBukkit",
            "Other"});
            this.comboServerType.Location = new System.Drawing.Point(58, 292);
            this.comboServerType.Name = "comboServerType";
            this.comboServerType.Size = new System.Drawing.Size(234, 21);
            this.comboServerType.TabIndex = 4;
            this.comboServerType.SelectedIndexChanged += new System.EventHandler(this.comboServerType_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo.Location = new System.Drawing.Point(13, 144);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(595, 104);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(11, 32);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(597, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // frmServerWizard
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServerWizard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Server";
            this.skin.ResumeLayout(false);
            this.skin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack skin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox comboServerType;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblName;
    }
}