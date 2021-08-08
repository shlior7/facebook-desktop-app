
namespace BasicFacebookFeatures
{
    partial class FormAppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppSettings));
            this.comboAppID = new System.Windows.Forms.ComboBox();
            this.labelAppId = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.listBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.textBoxPermissions = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPermissionToAdd = new System.Windows.Forms.TextBox();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonAddAppID = new System.Windows.Forms.Button();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.assistantLabel = new System.Windows.Forms.Label();
            this.buttonRefreshPermissions = new System.Windows.Forms.Button();
            this.assistantToggle = new BasicFacebookFeatures.RJToggleButton();
            this.SuspendLayout();
            // 
            // comboAppID
            // 
            this.comboAppID.Items.AddRange(new object[] {
            "1450160541956417",
            "696056928008003"});
            this.comboAppID.Location = new System.Drawing.Point(109, 10);
            this.comboAppID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboAppID.Name = "comboAppID";
            this.comboAppID.Size = new System.Drawing.Size(263, 36);
            this.comboAppID.TabIndex = 6;
            // 
            // label2
            // 
            this.labelAppId.AutoSize = true;
            this.labelAppId.Location = new System.Drawing.Point(21, 15);
            this.labelAppId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAppId.Name = "label2";
            this.labelAppId.Size = new System.Drawing.Size(93, 30);
            this.labelAppId.TabIndex = 5;
            this.labelAppId.Text = "APP ID:";
            // 
            // label1
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Location = new System.Drawing.Point(21, 69);
            this.labelPermission.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPermission.Name = "label1";
            this.labelPermission.Size = new System.Drawing.Size(122, 30);
            this.labelPermission.TabIndex = 7;
            this.labelPermission.Text = "Permissions:";
            // 
            // listBoxPermissions
            // 
            this.listBoxPermissions.CheckOnClick = true;
            this.listBoxPermissions.FormattingEnabled = true;
            this.listBoxPermissions.Items.AddRange(new object[] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"});
            this.listBoxPermissions.Location = new System.Drawing.Point(26, 97);
            this.listBoxPermissions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxPermissions.Name = "listBoxPermissions";
            this.listBoxPermissions.Size = new System.Drawing.Size(396, 407);
            this.listBoxPermissions.Sorted = true;
            this.listBoxPermissions.TabIndex = 8;
            // 
            // textBoxPermissions
            // 
            this.textBoxPermissions.Location = new System.Drawing.Point(481, 97);
            this.textBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissions.Multiline = true;
            this.textBoxPermissions.Name = "textBoxPermissions";
            this.textBoxPermissions.Size = new System.Drawing.Size(489, 199);
            this.textBoxPermissions.TabIndex = 9;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(911, 727);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(123, 49);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPermissionToAdd
            // 
            this.textBoxPermissionToAdd.Location = new System.Drawing.Point(26, 547);
            this.textBoxPermissionToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissionToAdd.Name = "textBoxPermissionToAdd";
            this.textBoxPermissionToAdd.Size = new System.Drawing.Size(215, 36);
            this.textBoxPermissionToAdd.TabIndex = 12;
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Location = new System.Drawing.Point(248, 547);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(174, 37);
            this.buttonAddPermission.TabIndex = 13;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(793, 630);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(241, 36);
            this.textBoxUserName.TabIndex = 15;
            this.textBoxUserName.Text = "design.patterns";
            // 
            // label3
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Location = new System.Drawing.Point(682, 634);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsername.Name = "label3";
            this.labelUsername.Size = new System.Drawing.Size(110, 30);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(793, 673);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 36);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.Text = "design.patterns20cc";
            // 
            // label4
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.CausesValidation = false;
            this.labelPassword.Location = new System.Drawing.Point(682, 678);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "label4";
            this.labelPassword.Size = new System.Drawing.Size(102, 30);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password:";
            // 
            // buttonAddAppID
            // 
            this.buttonAddAppID.Location = new System.Drawing.Point(656, 10);
            this.buttonAddAppID.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAppID.Name = "buttonAddAppID";
            this.buttonAddAppID.Size = new System.Drawing.Size(71, 30);
            this.buttonAddAppID.TabIndex = 19;
            this.buttonAddAppID.Text = "Add";
            this.buttonAddAppID.UseVisualStyleBackColor = true;
            this.buttonAddAppID.Click += new System.EventHandler(this.buttonAddAppID_Click);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(398, 10);
            this.textBoxAppID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(248, 36);
            this.textBoxAppID.TabIndex = 18;
            // 
            // assistantLabel
            // 
            this.assistantLabel.AutoSize = true;
            this.assistantLabel.Location = new System.Drawing.Point(687, 566);
            this.assistantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assistantLabel.Name = "assistantLabel";
            this.assistantLabel.Size = new System.Drawing.Size(283, 30);
            this.assistantLabel.TabIndex = 24;
            this.assistantLabel.Text = "Facy the Auditory Assistant :";
            this.assistantLabel.Click += new System.EventHandler(this.assistantLabel_Click);
            // 
            // buttonRefreshPermissions
            // 
            this.buttonRefreshPermissions.Location = new System.Drawing.Point(481, 314);
            this.buttonRefreshPermissions.Name = "buttonRefreshPermissions";
            this.buttonRefreshPermissions.Size = new System.Drawing.Size(259, 60);
            this.buttonRefreshPermissions.TabIndex = 25;
            this.buttonRefreshPermissions.Text = "Show Permissions";
            this.buttonRefreshPermissions.UseVisualStyleBackColor = true;
            this.buttonRefreshPermissions.Click += new System.EventHandler(this.button1_Click);
            // 
            // assistantToggle
            // 
            this.assistantToggle.BackColor = System.Drawing.Color.White;
            this.assistantToggle.Location = new System.Drawing.Point(938, 557);
            this.assistantToggle.Margin = new System.Windows.Forms.Padding(4);
            this.assistantToggle.Name = "assistantToggle";
            this.assistantToggle.Size = new System.Drawing.Size(96, 41);
            this.assistantToggle.TabIndex = 22;
            this.assistantToggle.Text = "Auditory Assistant";
            this.assistantToggle.UseVisualStyleBackColor = false;
            this.assistantToggle.CheckedChanged += new System.EventHandler(this.Assistant_CheckedChanged);
            // 
            // FormAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 792);
            this.Controls.Add(this.buttonRefreshPermissions);
            this.Controls.Add(this.assistantLabel);
            this.Controls.Add(this.assistantToggle);
            this.Controls.Add(this.buttonAddAppID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonAddPermission);
            this.Controls.Add(this.textBoxPermissionToAdd);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxPermissions);
            this.Controls.Add(this.listBoxPermissions);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.comboAppID);
            this.Controls.Add(this.labelAppId);
            this.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(1084, 839);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1084, 839);
            this.Name = "FormAppSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Settings";
            this.Load += new System.EventHandler(this.FormAppSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAppID;
        private System.Windows.Forms.Label labelAppId;
        private System.Windows.Forms.Label labelPermission;
        private System.Windows.Forms.CheckedListBox listBoxPermissions;
        private System.Windows.Forms.TextBox textBoxPermissions;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPermissionToAdd;
        private System.Windows.Forms.Button buttonAddPermission;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonAddAppID;
        private System.Windows.Forms.TextBox textBoxAppID;
        private RJToggleButton assistantToggle;
        private System.Windows.Forms.Label assistantLabel;
        private System.Windows.Forms.Button buttonRefreshPermissions;
    }
}
