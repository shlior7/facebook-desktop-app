
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.textBoxPermissions = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPermissionToAdd = new System.Windows.Forms.TextBox();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddAppID = new System.Windows.Forms.Button();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.assistantLabel = new System.Windows.Forms.Label();
            this.assistantToggle = new BasicFacebookFeatures.RJToggleButton();
            this.SuspendLayout();
            // 
            // comboAppID
            // 
            this.comboAppID.Items.AddRange(new object[] {
            "1450160541956417",
            "696056928008003"});
            this.comboAppID.Location = new System.Drawing.Point(84, 7);
            this.comboAppID.Margin = new System.Windows.Forms.Padding(4);
            this.comboAppID.Name = "comboAppID";
            this.comboAppID.Size = new System.Drawing.Size(203, 28);
            this.comboAppID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "APP ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Permissions:";
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
            this.listBoxPermissions.Location = new System.Drawing.Point(20, 69);
            this.listBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPermissions.Name = "listBoxPermissions";
            this.listBoxPermissions.Size = new System.Drawing.Size(1147, 508);
            this.listBoxPermissions.Sorted = true;
            this.listBoxPermissions.TabIndex = 8;
            // 
            // textBoxPermissions
            // 
            this.textBoxPermissions.Location = new System.Drawing.Point(412, 69);
            this.textBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissions.Multiline = true;
            this.textBoxPermissions.Name = "textBoxPermissions";
            this.textBoxPermissions.Size = new System.Drawing.Size(384, 92);
            this.textBoxPermissions.TabIndex = 9;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(701, 519);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(95, 35);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPermissionToAdd
            // 
            this.textBoxPermissionToAdd.Location = new System.Drawing.Point(20, 441);
            this.textBoxPermissionToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissionToAdd.Name = "textBoxPermissionToAdd";
            this.textBoxPermissionToAdd.Size = new System.Drawing.Size(203, 26);
            this.textBoxPermissionToAdd.TabIndex = 12;
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Location = new System.Drawing.Point(230, 441);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(174, 23);
            this.buttonAddPermission.TabIndex = 13;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(610, 450);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(186, 26);
            this.textBoxUserName.TabIndex = 15;
            this.textBoxUserName.Text = "design.patterns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Username:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(610, 481);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(186, 26);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.Text = "design.patterns20cc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 484);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password:";
            // 
            // buttonAddAppID
            // 
            this.buttonAddAppID.Location = new System.Drawing.Point(505, 7);
            this.buttonAddAppID.Name = "buttonAddAppID";
            this.buttonAddAppID.Size = new System.Drawing.Size(49, 23);
            this.buttonAddAppID.TabIndex = 19;
            this.buttonAddAppID.Text = "Add";
            this.buttonAddAppID.UseVisualStyleBackColor = true;
            this.buttonAddAppID.Click += new System.EventHandler(this.buttonAddAppID_Click);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(306, 7);
            this.textBoxAppID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(192, 26);
            this.textBoxAppID.TabIndex = 18;
            // 
            // assistantLabel
            // 
            this.assistantLabel.AutoSize = true;
            this.assistantLabel.Location = new System.Drawing.Point(492, 168);
            this.assistantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assistantLabel.Name = "assistantLabel";
            this.assistantLabel.Size = new System.Drawing.Size(145, 20);
            this.assistantLabel.TabIndex = 24;
            this.assistantLabel.Text = this.assistantToggle.Text;
            // 
            // assistantToggle
            // 
            this.assistantToggle.Location = new System.Drawing.Point(411, 168);
            this.assistantToggle.Name = "assistantToggle";
            this.assistantToggle.Size = new System.Drawing.Size(74, 29);
            this.assistantToggle.TabIndex = 22;
            this.assistantToggle.Text = "Auditory Assistant";
            this.assistantToggle.UseVisualStyleBackColor = true;
            this.assistantToggle.CheckedChanged += new System.EventHandler(this.Assistant_CheckedChanged);
            // 
            // FormAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 566);
            this.Controls.Add(this.assistantLabel);
            this.Controls.Add(this.assistantToggle);
            this.Controls.Add(this.buttonAddAppID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddPermission);
            this.Controls.Add(this.textBoxPermissionToAdd);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxPermissions);
            this.Controls.Add(this.listBoxPermissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAppID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(838, 613);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(838, 613);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listBoxPermissions;
        private System.Windows.Forms.TextBox textBoxPermissions;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPermissionToAdd;
        private System.Windows.Forms.Button buttonAddPermission;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddAppID;
        private System.Windows.Forms.TextBox textBoxAppID;
        private RJToggleButton assistantToggle;
        private System.Windows.Forms.Label assistantLabel;
    }
}