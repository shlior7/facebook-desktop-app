using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly MyAssistant m_FacyTheAssistant;
        private readonly User m_LoggedInUser;
        private readonly PostingProxy postingManager;
        private FormAppSettings m_FormAppSettings = null;
        private System.Timers.Timer m_ReminderTimer;
        private bool m_Logout;
        private readonly Fetcher m_Fetcher;

        public FormMain(User i_LoggedInUser)
        {
            if (i_LoggedInUser != null)
            {
                m_Logout = false;
                m_LoggedInUser = i_LoggedInUser;
                postingManager = new PostingProxy(m_LoggedInUser);
                InitializeComponent();
                fetchUserInfo();
                m_FacyTheAssistant = MyAssistant.GetAssistantInstance;
                m_Fetcher = Fetcher.getFetcherInstance(i_LoggedInUser);
                FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            }
            else
            {
                this.Load += (s, e) => Close();
            }
        }

        /// <summary>
        /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
        /// You can then save the result.AccessToken for future auto-connect to this user:
        /// The documentation regarding facebook login and permissions can be found here: 
        /// <seealso cref="https://developers.facebook.com/docs/permissions/reference"/>
        /// </summary>
        /// <remarks>
        /// DEPRECATED_PERMISSIONS:
        /// publish_to_groups
        /// groups_access_member_info
        /// "user_about_me",
        /// "user_education_history",
        /// "user_actions.video",
        /// "user_actions.news",
        /// "user_actions.music",
        /// "user_actions.fitness",
        /// "user_actions.books",
        /// "user_games_activity",
        /// "user_managed_groups",
        /// "user_relationships",
        /// "user_relationship_details",
        /// "user_religion_politics",
        /// "user_tagged_places",
        /// "user_website",
        /// "user_work_history",
        /// "read_custom_friendlists",
        /// "read_page_mailboxes",
        /// "manage_pages",
        /// "publish_pages",
        /// "publish_actions",
        /// "rsvp_event"
        /// "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
        /// "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
        /// "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
        /// </remarks>
        public bool Logout
        {
            get
            {
                return m_Logout;
            }

            set
            {
                m_Logout = value;
            }
        }

        private void fetchAll()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => Fetcher.fetchEvents(listBoxEvents)));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => Fetcher.fetchGroups(listBoxGroups)));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => Fetcher.fetchAlbums(listBoxAlbums)));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => Fetcher.fetchFavoriteTeams(listBoxFavoriteTeams)));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => Fetcher.fetchLikedPages(listBoxPages)));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => Fetcher.fetchPosts(listBoxPosts)));
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = postingManager.PostStatus(textBoxStatus.Text);
                m_FacyTheAssistant.Speak("Status Posted!");
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Fetcher.ToggleFetches(linkPosts, listBoxPosts, FetchingFields.Posts);
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Fetcher.ToggleFetches(linkAlbums, listBoxAlbums, FetchingFields.Albums, pictureBoxAlbum);
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Fetcher.ToggleFetches(labelEvents, listBoxEvents, FetchingFields.Events, pictureBoxEvent, showOrUnshowReminderSetting);
        }

        private void linkFavoriteTeams_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Fetcher.ToggleFetches(linkFavoriteTeams, listBoxFavoriteTeams, FetchingFields.FavoriteTeams, pictureBoxFavoriteTeam);
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Fetcher.ToggleFetches(linkPages, listBoxPages, FetchingFields.LikedPages, pictureBoxPage);
        }

        private void labelGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Fetcher.ToggleFetches(linkLabelFetchGroups, listBoxGroups, FetchingFields.Groups, pictureBoxGroup);
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;
                m_FacyTheAssistant.Speak($"{selectedTeam.Name} Team!");
                pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                m_FacyTheAssistant.Speak($"{selectedEvent.Name} Event");
                m_FacyTheAssistant.Speak($"Location At {selectedEvent.Location}");
                m_FacyTheAssistant.Speak($"Startting At {selectedEvent.TimeString}");
                if (selectedEvent.Cover != null)
                {
                    pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
                }
                showOrUnshowReminderSetting(true);
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                m_FacyTheAssistant.Speak($"{selectedGroup.Name} Group!");
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                m_FacyTheAssistant.Speak($"{selectedPage.Name} Page!");
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            listBoxPostComments.DisplayMember = "Message";
            m_FacyTheAssistant.Speak($"{selected.Name} Post!");
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void linkUserActions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string actionType = comboBoxActionType.SelectedItem.ToString();
            FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
            dynamic actionsData = FacebookService.GetDynamicData(actionType);
            dataGridViewActions.DataSource = actions;
        }

        private void showOrUnshowReminderSetting(bool i_Show)
        {
            if (i_Show && TimeBeforeNumeric.Visible == false)
            {
                TimeBeforeNumeric.Value = 5;
                TimeUnitDropdown.SelectedIndex = 0;
            }

            TimeBeforeNumeric.Visible = i_Show;
            TimeUnitDropdown.Visible = i_Show;
            SetEventReminderLabel.Visible = i_Show;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_Logout = true;
            this.Close();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void listBoxPostComments_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPostComments.SelectedItems.Count == 1)
            {
                try
                {
                    (listBoxPostComments.SelectedItem as Comment).Like();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
        @"posting LIKEs is no longer supported :(
(OAuthException - #3) 
Publishing likes through the API is only available for page access tokens");
                }
            }
        }

        private void saveReminders()
        {
            TimeSpan timeBefore;
            bool didntFound;
            int[] timeUnits;

            timeUnits = new int[3]; // minutes, hours, days
            timeUnits[TimeUnitDropdown.SelectedIndex] += (int)TimeBeforeNumeric.Value;
            timeBefore = new TimeSpan(timeUnits[2], timeUnits[1], timeUnits[0], 0);
            foreach (Event selectedEvent in listBoxEvents.SelectedItems)
            {
                didntFound = true;
                DateTime EventsDate = (DateTime)selectedEvent.StartTime;
                if (EventsDate != null)
                {
                    if (AppSettings.s_EventReminders == null)
                    {
                        AppSettings.s_EventReminders = new List<EventReminder>();
                    }

                    foreach (EventReminder reminder in AppSettings.s_EventReminders)
                    {
                        if (reminder.Event.Id == selectedEvent.Id)
                        {
                            reminder.TimeToAlert = EventsDate.Subtract(timeBefore);
                            didntFound = false;
                        }
                    }

                    if (didntFound)
                    {
                        if (AppSettings.s_EventReminders.Count == 0)
                        {
                            m_ReminderTimer.Start();
                        }

                        EventReminder eventReminder = new EventReminder(selectedEvent, EventsDate.Subtract(timeBefore));
                        AppSettings.s_EventReminders.Add(eventReminder);
                        eventReminderBindingSource.Add(eventReminder);
                    }

                    MessageBox.Show("Reminder Saved!");
                }
                else
                {
                    MessageBox.Show("This event doesnt have a start time!");
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings();
            }

            m_FormAppSettings.ShowDialog();
            m_FacyTheAssistant.AuditoryAssistant = m_FormAppSettings.AuditoryAssistant;
        }

        private void buttonSettings_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Settings");
        }

        private void buttonLogout_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Logout");
        }

        private void linkPosts_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Fetch Posts");
        }

        private void linkAlbums_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Fetch Albums");
        }

        private void labelEvents_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Fetch Events");
        }

        private void linkLabelFetchGroups_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Fetch Groups");
        }

        private void linkFavoriteTeams_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Fetch Favorite Teams");
        }

        private void linkPages_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak("Fetch Liked Pages");
        }

        private void buttonSetStatus_MouseHover(object sender, EventArgs e)
        {
            m_FacyTheAssistant.Speak($"Post status: {textBoxStatus.Text}");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_ReminderTimer = new System.Timers.Timer();
            m_ReminderTimer.Interval = 1000;
            m_ReminderTimer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            foreach (EventReminder reminder in AppSettings.s_EventReminders)
            {
                if (currentTime.Equals(reminder.TimeToAlert))
                {
                    MessageBox.Show(reminder.ToString(), "Upcoming Event", MessageBoxButtons.OK);
                }
            }
        }

        private void SetEventReminderLabel_Click(object sender, EventArgs e)
        {
            saveReminders();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridViewReminders.Columns[e.ColumnIndex].Name;
            if (dataGridViewReminders.Columns[e.ColumnIndex].Name == "DeleteDataGridButtonColumn")
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AppSettings.s_EventReminders.Remove((EventReminder)eventReminderBindingSource.Current);
                    eventReminderBindingSource.RemoveCurrent();
                    if (AppSettings.s_EventReminders.Count == 0)
                    {
                        m_ReminderTimer.Stop();
                    }
                }
            }
        }

        private void fetchAllButton_Click(object sender, EventArgs e)
        {
            fetchAll();
        }
    }
}
