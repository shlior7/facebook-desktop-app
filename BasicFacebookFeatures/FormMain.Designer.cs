namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.postStatusLabel = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.linkFavoriteTeams = new System.Windows.Forms.LinkLabel();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProfileTab = new System.Windows.Forms.TabPage();
            this.SetEventReminderLabel = new System.Windows.Forms.Label();
            this.TimeBeforeNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimeUnitDropdown = new System.Windows.Forms.ComboBox();
            this.buttonSettings = new BasicFacebookFeatures.StyledButton();
            this.pictureBoxFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new BasicFacebookFeatures.StyledButton();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.linkLabelFetchGroups = new System.Windows.Forms.LinkLabel();
            this.buttonSetStatus = new BasicFacebookFeatures.StyledButton();
            this.ActionTab = new System.Windows.Forms.TabPage();
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.linkUserActions = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBeforeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.ActionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(20, 484);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(249, 180);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 42;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Click += new System.EventHandler(this.pictureBoxAlbum_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Location = new System.Drawing.Point(1146, 4);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(208, 132);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 41;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.White;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 34;
            this.listBoxAlbums.Location = new System.Drawing.Point(20, 245);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(250, 140);
            this.listBoxAlbums.TabIndex = 37;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 34;
            this.listBoxEvents.Location = new System.Drawing.Point(290, 245);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(250, 140);
            this.listBoxEvents.TabIndex = 40;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // label3
            // 
            this.postStatusLabel.AutoSize = true;
            this.postStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.postStatusLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.postStatusLabel.Location = new System.Drawing.Point(375, 15);
            this.postStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postStatusLabel.Name = "postStatusLabel";
            this.postStatusLabel.Size = new System.Drawing.Size(166, 38);
            this.postStatusLabel.TabIndex = 44;
            this.postStatusLabel.Text = "Post Status:";
            this.postStatusLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(509, 21);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(465, 42);
            this.textBoxStatus.TabIndex = 45;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 34;
            this.listBoxPosts.Location = new System.Drawing.Point(8, 64);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(412, 38);
            this.listBoxPosts.TabIndex = 40;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEvent.Location = new System.Drawing.Point(290, 484);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(249, 180);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEvent.TabIndex = 42;
            this.pictureBoxEvent.TabStop = false;
            // 
            // linkAlbums
            // 
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.BackColor = System.Drawing.Color.Transparent;
            this.linkAlbums.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkAlbums.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkAlbums.Location = new System.Drawing.Point(-2, 197);
            this.linkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(406, 75);
            this.linkAlbums.TabIndex = 47;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
            this.linkAlbums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            this.linkAlbums.MouseHover += new System.EventHandler(this.linkAlbums_MouseHover);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.BackColor = System.Drawing.Color.Transparent;
            this.labelEvents.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEvents.Location = new System.Drawing.Point(292, 196);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(379, 75);
            this.labelEvents.TabIndex = 48;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.labelEvents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            this.labelEvents.MouseHover += new System.EventHandler(this.labelEvents_MouseHover);
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.BackColor = System.Drawing.Color.Transparent;
            this.linkPosts.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkPosts.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkPosts.Location = new System.Drawing.Point(75, 12);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(407, 75);
            this.linkPosts.TabIndex = 49;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments!)\r\n";
            this.linkPosts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkPosts.UseCompatibleTextRendering = true;
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            this.linkPosts.MouseHover += new System.EventHandler(this.linkPosts_MouseHover);
            // 
            // linkFavoriteTeams
            // 
            this.linkFavoriteTeams.AutoSize = true;
            this.linkFavoriteTeams.BackColor = System.Drawing.Color.Transparent;
            this.linkFavoriteTeams.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.linkFavoriteTeams.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
            this.linkFavoriteTeams.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkFavoriteTeams.Location = new System.Drawing.Point(1146, 197);
            this.linkFavoriteTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkFavoriteTeams.Name = "linkFavoriteTeams";
            this.linkFavoriteTeams.Size = new System.Drawing.Size(255, 41);
            this.linkFavoriteTeams.TabIndex = 50;
            this.linkFavoriteTeams.TabStop = true;
            this.linkFavoriteTeams.Text = "Fetch Favorite Teams \r\n";
            this.linkFavoriteTeams.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkFavoriteTeams.UseCompatibleTextRendering = true;
            this.linkFavoriteTeams.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFavoriteTeams_LinkClicked);
            this.linkFavoriteTeams.MouseHover += new System.EventHandler(this.linkFavoriteTeams_MouseHover);
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.DisplayMember = "name";
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 34;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(1100, 245);
            this.listBoxFavoriteTeams.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(250, 140);
            this.listBoxFavoriteTeams.TabIndex = 40;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProfileTab);
            this.tabControl1.Controls.Add(this.ActionTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 703);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.ProfileTab.BackColor = System.Drawing.Color.DarkOrange;
            this.ProfileTab.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.brown_view;
            this.ProfileTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileTab.Controls.Add(this.SetEventReminderLabel);
            this.ProfileTab.Controls.Add(this.TimeBeforeNumeric);
            this.ProfileTab.Controls.Add(this.TimeUnitDropdown);
            this.ProfileTab.Controls.Add(this.buttonSettings);
            this.ProfileTab.Controls.Add(this.pictureBoxFavoriteTeam);
            this.ProfileTab.Controls.Add(this.pictureBoxAlbum);
            this.ProfileTab.Controls.Add(this.buttonLogout);
            this.ProfileTab.Controls.Add(this.listBoxPostComments);
            this.ProfileTab.Controls.Add(this.pictureBoxPage);
            this.ProfileTab.Controls.Add(this.pictureBoxGroup);
            this.ProfileTab.Controls.Add(this.pictureBoxEvent);
            this.ProfileTab.Controls.Add(this.linkFavoriteTeams);
            this.ProfileTab.Controls.Add(this.listBoxAlbums);
            this.ProfileTab.Controls.Add(this.listBoxPages);
            this.ProfileTab.Controls.Add(this.linkPages);
            this.ProfileTab.Controls.Add(this.listBoxGroups);
            this.ProfileTab.Controls.Add(this.linkLabelFetchGroups);
            this.ProfileTab.Controls.Add(this.listBoxEvents);
            this.ProfileTab.Controls.Add(this.labelEvents);
            this.ProfileTab.Controls.Add(this.listBoxFavoriteTeams);
            this.ProfileTab.Controls.Add(this.linkAlbums);
            this.ProfileTab.Controls.Add(this.listBoxPosts);
            this.ProfileTab.Controls.Add(this.buttonSetStatus);
            this.ProfileTab.Controls.Add(this.pictureBoxProfile);
            this.ProfileTab.Controls.Add(this.textBoxStatus);
            this.ProfileTab.Controls.Add(this.postStatusLabel);
            this.ProfileTab.Controls.Add(this.linkPosts);
            this.ProfileTab.Location = new System.Drawing.Point(4, 43);
            this.ProfileTab.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileTab.Name = "tabPage1";
            this.ProfileTab.Padding = new System.Windows.Forms.Padding(4);
            this.ProfileTab.Size = new System.Drawing.Size(1374, 656);
            this.ProfileTab.TabIndex = 1;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SetEventReminderLabel
            // 
            this.SetEventReminderLabel.AutoSize = true;
            this.SetEventReminderLabel.Location = new System.Drawing.Point(291, 457);
            this.SetEventReminderLabel.Name = "SetEventReminderLabel";
            this.SetEventReminderLabel.Size = new System.Drawing.Size(245, 34);
            this.SetEventReminderLabel.TabIndex = 57;
            this.SetEventReminderLabel.Text = "Save Event Reminder";
            this.SetEventReminderLabel.Visible = false;
            this.SetEventReminderLabel.Click += new System.EventHandler(this.SetEventReminderLabel_Click);
            // 
            // TimeBeforeNumeric
            // 
            this.TimeBeforeNumeric.Location = new System.Drawing.Point(290, 420);
            this.TimeBeforeNumeric.Name = "TimeBeforeNumeric";
            this.TimeBeforeNumeric.Size = new System.Drawing.Size(80, 42);
            this.TimeBeforeNumeric.TabIndex = 56;
            this.TimeBeforeNumeric.Visible = false;
            // 
            // TimeUnitDropdown
            // 
            this.TimeUnitDropdown.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days"});
            this.TimeUnitDropdown.Location = new System.Drawing.Point(394, 420);
            this.TimeUnitDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.TimeUnitDropdown.Name = "TimeUnitDropdown";
            this.TimeUnitDropdown.Size = new System.Drawing.Size(145, 42);
            this.TimeUnitDropdown.TabIndex = 55;
            this.TimeUnitDropdown.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.MistyRose;
            this.buttonSettings.BZBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonSettings.DisplayText = "_";
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSettings.Location = new System.Drawing.Point(1128, 144);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.MouseClickColor1 = System.Drawing.Color.DarkSalmon;
            this.buttonSettings.MouseHoverColor = System.Drawing.Color.DarkSalmon;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(118, 49);
            this.buttonSettings.TabIndex = 54;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonSettings.MouseHover += new System.EventHandler(this.buttonSettings_MouseHover);
            // 
            // pictureBoxFavoriteTeam
            // 
            this.pictureBoxFavoriteTeam.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFavoriteTeam.Location = new System.Drawing.Point(1100, 484);
            this.pictureBoxFavoriteTeam.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFavoriteTeam.Name = "pictureBoxFavoriteTeam";
            this.pictureBoxFavoriteTeam.Size = new System.Drawing.Size(249, 180);
            this.pictureBoxFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFavoriteTeam.TabIndex = 53;
            this.pictureBoxFavoriteTeam.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.Color.MistyRose;
            this.buttonLogout.BZBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonLogout.DisplayText = "_";
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.Location = new System.Drawing.Point(1252, 144);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.MouseClickColor1 = System.Drawing.Color.DarkSalmon;
            this.buttonLogout.MouseHoverColor = System.Drawing.Color.DarkSalmon;
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 49);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.MouseHover += new System.EventHandler(this.buttonLogout_MouseHover);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPostComments.DisplayMember = "name";
            this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 29;
            this.listBoxPostComments.Location = new System.Drawing.Point(443, 104);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(465, 31);
            this.listBoxPostComments.TabIndex = 51;
            this.listBoxPostComments.DoubleClick += new System.EventHandler(this.listBoxPostComments_DoubleClick);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPage.Location = new System.Drawing.Point(560, 484);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(249, 180);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPage.TabIndex = 42;
            this.pictureBoxPage.TabStop = false;
            this.pictureBoxPage.Click += new System.EventHandler(this.pictureBoxPage_Click);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGroup.Location = new System.Drawing.Point(830, 484);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(249, 180);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGroup.TabIndex = 42;
            this.pictureBoxGroup.TabStop = false;
            this.pictureBoxGroup.Click += new System.EventHandler(this.pictureBoxGroup_Click);
            // 
            // listBoxPages
            // 
            this.listBoxPages.DisplayMember = "name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 34;
            this.listBoxPages.Location = new System.Drawing.Point(560, 245);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(250, 140);
            this.listBoxPages.TabIndex = 40;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.BackColor = System.Drawing.Color.Transparent;
            this.linkPages.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.linkPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkPages.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkPages.Location = new System.Drawing.Point(564, 194);
            this.linkPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(363, 75);
            this.linkPages.TabIndex = 48;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages \r\n(Click on a page to view it\'s picture)";
            this.linkPages.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkPages.UseCompatibleTextRendering = true;
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
            this.linkPages.MouseHover += new System.EventHandler(this.linkPages_MouseHover);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 34;
            this.listBoxGroups.Location = new System.Drawing.Point(830, 245);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(250, 140);
            this.listBoxGroups.TabIndex = 40;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // linkLabelFetchGroups
            // 
            this.linkLabelFetchGroups.AutoSize = true;
            this.linkLabelFetchGroups.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelFetchGroups.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold);
            this.linkLabelFetchGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchGroups.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelFetchGroups.Location = new System.Drawing.Point(829, 194);
            this.linkLabelFetchGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFetchGroups.Name = "linkLabelFetchGroups";
            this.linkLabelFetchGroups.Size = new System.Drawing.Size(384, 75);
            this.linkLabelFetchGroups.TabIndex = 48;
            this.linkLabelFetchGroups.TabStop = true;
            this.linkLabelFetchGroups.Text = "Fetch Groups \r\n(Click on an group to view it\'s picture)";
            this.linkLabelFetchGroups.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelFetchGroups.UseCompatibleTextRendering = true;
            this.linkLabelFetchGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelGroups_LinkClicked);
            this.linkLabelFetchGroups.MouseHover += new System.EventHandler(this.linkLabelFetchGroups_MouseHover);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.BackColor = System.Drawing.Color.MistyRose;
            this.buttonSetStatus.BZBackColor = System.Drawing.Color.Snow;
            this.buttonSetStatus.DisplayText = "_";
            this.buttonSetStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetStatus.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSetStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSetStatus.Location = new System.Drawing.Point(982, 10);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetStatus.MouseClickColor1 = System.Drawing.Color.DarkSalmon;
            this.buttonSetStatus.MouseHoverColor = System.Drawing.Color.DarkSalmon;
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(118, 49);
            this.buttonSetStatus.TabIndex = 46;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = false;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            this.buttonSetStatus.MouseHover += new System.EventHandler(this.buttonSetStatus_MouseHover);
            // 
            // tabPage2
            // 
            this.ActionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ActionTab.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.brown_view;
            this.ActionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ActionTab.Controls.Add(this.comboBoxActionType);
            this.ActionTab.Controls.Add(this.dataGridViewActions);
            this.ActionTab.Controls.Add(this.linkUserActions);
            this.ActionTab.Location = new System.Drawing.Point(4, 43);
            this.ActionTab.Margin = new System.Windows.Forms.Padding(4);
            this.ActionTab.Name = "tabPage2";
            this.ActionTab.Padding = new System.Windows.Forms.Padding(4);
            this.ActionTab.Size = new System.Drawing.Size(1374, 656);
            this.ActionTab.TabIndex = 2;
            this.ActionTab.Text = "Actions";
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
            this.comboBoxActionType.Location = new System.Drawing.Point(172, 7);
            this.comboBoxActionType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(219, 42);
            this.comboBoxActionType.TabIndex = 23;
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToAddRows = false;
            this.dataGridViewActions.AllowUserToDeleteRows = false;
            this.dataGridViewActions.AllowUserToOrderColumns = true;
            this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActions.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewActions.Location = new System.Drawing.Point(14, 41);
            this.dataGridViewActions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.ReadOnly = true;
            this.dataGridViewActions.RowHeadersWidth = 62;
            this.dataGridViewActions.Size = new System.Drawing.Size(1306, 574);
            this.dataGridViewActions.TabIndex = 22;
            // 
            // linkUserActions
            // 
            this.linkUserActions.AutoSize = true;
            this.linkUserActions.BackColor = System.Drawing.Color.Transparent;
            this.linkUserActions.Location = new System.Drawing.Point(11, 11);
            this.linkUserActions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkUserActions.Name = "linkUserActions";
            this.linkUserActions.Size = new System.Drawing.Size(227, 34);
            this.linkUserActions.TabIndex = 14;
            this.linkUserActions.TabStop = true;
            this.linkUserActions.Text = "Fetch User Actions";
            this.linkUserActions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUserActions_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1400, 750);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facy";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBeforeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.ActionTab.ResumeLayout(false);
            this.ActionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label postStatusLabel;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.LinkLabel linkFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.TabPage ActionTab;
        private System.Windows.Forms.ComboBox comboBoxActionType;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.LinkLabel linkUserActions;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeam;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.LinkLabel linkLabelFetchGroups;
        private System.Windows.Forms.NumericUpDown TimeBeforeNumeric;
        private System.Windows.Forms.ComboBox TimeUnitDropdown;
        private System.Windows.Forms.Label SetEventReminderLabel;
        private StyledButton buttonSetStatus;
        private StyledButton buttonLogout;
        private StyledButton buttonSettings;
    }
}

