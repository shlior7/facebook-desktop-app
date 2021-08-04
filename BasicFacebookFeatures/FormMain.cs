using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Timers;
using System.Media;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        static MyAssistant Facy;
        User m_LoggedInUser;
        bool m_Logout;
        System.Timers.Timer timer;
        List<DateTime> events;

        public FormMain(User LoggedInUser)
        {
            events = new List<DateTime>();
            if (LoggedInUser != null)
            {
                m_Logout = false;
                m_LoggedInUser = LoggedInUser;
                InitializeComponent();
                fetchUserInfo();
                Facy = MyAssistant.Instance;
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
        ///"user_about_me",
        ///"user_education_history",
        ///"user_actions.video",
        ///"user_actions.news",
        ///"user_actions.music",
        ///"user_actions.fitness",
        ///"user_actions.books",
        ///"user_games_activity",
        ///"user_managed_groups",
        ///"user_relationships",
        ///"user_relationship_details",
        ///"user_religion_politics",
        ///"user_tagged_places",
        ///"user_website",
        ///"user_work_history",
        ///"read_custom_friendlists",
        ///"read_page_mailboxes",
        ///"manage_pages",
        ///"publish_pages",
        ///"publish_actions",
        ///"rsvp_event"
        ///"read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
        ///"read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
        ///"manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
        ///</remarks>

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                Facy.Speak("Status Posted!");
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        /// <summary>
        /// Fetching posts *** made by the logged in user ***:
        /// </summary>
        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            Facy.Speak("Fetching Posts!");

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            Facy.Speak("Fetching Albums!");
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Facy.Speak("Displaying albums!");
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
            else
            {
                Facy.Speak("No albums to display!");
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBoxEvents.Items.Count > 0)
            {
                labelEvents.BackColor = Color.Transparent;
                pictureBoxEvent.Image = null;
                showOrUnshowEventAlert(false);
                listBoxEvents.Items.Clear();
                saveReminders();
            }
            else
            {
                labelEvents.BackColor = Color.Gray;
                fetchEvents();
            }
        }
        private void saveReminders()
        {
            int[] timeUnits = new int[3];// minutes, hours, days
            timeUnits[TimeUnitDropdown.SelectedIndex] += (int)TimeBeforeNumeric.Value;
            TimeSpan timeBefore = new TimeSpan(timeUnits[2], timeUnits[1], timeUnits[0], 0);
            bool didntFound = true;

            foreach (Event selectedEvent in listBoxEvents.SelectedItems)
            {
                didntFound = true;
                DateTime EventsDate = (DateTime)(selectedEvent.StartTime);
                if (EventsDate != null)
                {
                    foreach (EventReminder reminder in AppSettings.s_EventReminders)
                    {
                        if (reminder.Event.Id == selectedEvent.Id)
                        {
                            reminder.TimeToAlert = EventsDate.Subtract(timeBefore);
                            didntFound = false;
                        }
                    }
                    if (!didntFound)
                    {
                        EventReminder eventReminder = new EventReminder(selectedEvent, EventsDate.Subtract(timeBefore));
                        AppSettings.s_EventReminders.Add(eventReminder);
                    }
                }
            }
        }
        private void fetchEvents()
        {
            listBoxEvents.DisplayMember = "Name";
            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
                Facy.Speak("No Events to display!");
            }
            else
            {
                Facy.Speak("Displaying events!");
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(fbEvent);
                }
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;
                Facy.Speak($"Displaying {selectedTeam.Name} Page!");
                pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                Facy.Speak($"{selectedEvent.Name} Event");
                Facy.Speak($"Location At {selectedEvent.Location}");
                Facy.Speak($"Startting At {selectedEvent.TimeString}");

                pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
            }
            if (listBoxEvents.SelectedItems.Count > 0)
            {
                showOrUnshowEventAlert(true);
            }
            else
            {
                showOrUnshowEventAlert(false);
            }
        }
        private void showOrUnshowEventAlert(bool i_show)
        {
            TimeBeforeNumeric.Visible = i_show;
            TimeUnitDropdown.Visible = i_show;
        }
        private void linkFavoriteTeams_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Items.Clear();
            listBoxFavoriteTeams.DisplayMember = "Name";
            if (m_LoggedInUser.FavofriteTeams.Length == 0)
            {
                MessageBox.Show("No teams to retrieve :(");
                Facy.Speak("No Teams to display!");
            }
            else
            {
                Facy.Speak("Displaying Teams!");
                foreach (Page team in m_LoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeams.Items.Add(team);
                }
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                if (m_LoggedInUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                    Facy.Speak("No Liked Pages to display!");
                }
                else
                {
                    Facy.Speak("Displaying Liked Pages!");
                    foreach (Page page in m_LoggedInUser.LikedPages)
                    {
                        listBoxPages.Items.Add(page);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void linkUserActions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string actionType = comboBoxActionType.SelectedItem.ToString();
            FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
            dynamic actionsData = FacebookService.GetDynamicData(actionType);
            dataGridViewActions.DataSource = actions;
        }

        /// <summary>
        /// Fetching all comments *** made by the logged in user ***, to the selected post:
        /// </summary>
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
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

        FormAppSettings m_FormAppSettings = null;

        public bool Logout { get => m_Logout; set => m_Logout = value; }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings();
            }
            m_FormAppSettings.ShowDialog();
            Facy.AuditoryAssistant = m_FormAppSettings.AuditoryAssistant;
        }

        public class SharedStuff
        {
            private int m_events;
            private int m_posts;
            private int m_groups;
            private int m_pages;

            public int Events { get => m_events; set => m_events = value; }
            public int Posts { get => m_posts; set => m_posts = value; }
            public int Groups { get => m_groups; set => m_groups = value; }
            public int Pages { get => m_pages; set => m_pages = value; }

            public SharedStuff(int i_events = 0, int i_posts = 0, int i_groups = 0)
            {
                this.m_events = i_events;
                this.m_posts = i_posts;
                this.m_groups = i_groups;
            }

        }
        public class BySharedThings : IComparer<SharedStuff>
        {
            public int Compare(SharedStuff x, SharedStuff y)
            {
                int xSumSharedStuff = x.Posts + x.Pages + x.Events + x.Groups;
                int ySumSharedStuff = y.Posts + y.Pages + y.Events + y.Groups;

                return xSumSharedStuff.CompareTo(ySumSharedStuff);
            }
        }
        ///// DOTO To Style like the mf wants
        private void BestFriendButton_Click(object sender, EventArgs e)
        {
            // Friend curFriend = new Friend();
            //bool flag = false;
            Dictionary<User, SharedStuff> potentialBestiess = new Dictionary<User, SharedStuff>();
            SortedSet<SharedStuff> potentialBesties = new SortedSet<SharedStuff>(new BySharedThings());
            Dictionary<string, string> myPages = new Dictionary<string, string>();

            foreach (Group group in m_LoggedInUser.Groups)
            {
                foreach (User friend in group.Members)
                {
                    if (potentialBestiess.ContainsKey(friend))
                    {
                        potentialBestiess[friend].Groups++;
                    }
                    else
                    {
                        SharedStuff friendsSharedStuff = new SharedStuff(0, 0, 1);
                        potentialBestiess.Add(friend, friendsSharedStuff);
                        potentialBesties.Add(friendsSharedStuff);
                    }
                }
            }
            foreach (Post post in m_LoggedInUser.Posts)
            {
                foreach (User friend in post.LikedBy)
                {
                    if (!potentialBestiess.ContainsKey(friend))
                    {
                        SharedStuff friendsSharedStuff = new SharedStuff();
                        potentialBestiess.Add(friend, friendsSharedStuff);
                        potentialBesties.Add(friendsSharedStuff);
                    }
                    potentialBestiess[friend].Posts++;
                }
            }
            foreach (Event myEvent in m_LoggedInUser.Events)
            {
                foreach (User attending in myEvent.AttendingUsers)
                {
                    if (!potentialBestiess.ContainsKey(attending))
                    {
                        SharedStuff friendsSharedStuff = new SharedStuff();
                        potentialBestiess.Add(attending, friendsSharedStuff);
                        potentialBesties.Add(friendsSharedStuff);
                    }
                    potentialBestiess[attending].Events++;
                }
            }
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                foreach (Post post in page.Posts)
                {
                    foreach (User friend in post.LikedBy)
                    {
                        if (potentialBestiess.ContainsKey(friend))
                        {
                            potentialBestiess[friend].Pages++;
                        }
                    }
                }
            }
            Console.WriteLine(potentialBesties.Count);
            Console.WriteLine(potentialBestiess.Count);
            Console.WriteLine(myPages.Count);
            Console.WriteLine("Check");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {

        }

        private void speak_Click(object sender, EventArgs e)
        {

            Facy.Speak("All we need to do is to make sure we keep talking");
        }

        private void buttonSettings_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Settings");

        }

        private void buttonLogout_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Logout");

        }

        private void linkPosts_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Fetch Posts");

        }

        private void linkAlbums_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Fetch Albums");

        }

        private void labelEvents_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Fetch Events");
        }

        private void linkLabelFetchGroups_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Fetch Groups");

        }

        private void linkFavoriteTeams_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Fetch Favorite Teams");
        }

        private void linkPages_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak("Fetch Liked Pages");

        }

        private void buttonSetStatus_MouseHover(object sender, EventArgs e)
        {
            Facy.Speak($"Post status: {textBoxStatus.Text}");
        }


        private void pictureBoxGroup_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
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
    }

    public static class AppSettings
    {
        public static string s_AppID = "371702747635779"; /// (desig patter's "Design Patterns Course App 2.4" app)
        public static string[] s_Permissions = new string[] {
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
            "user_videos"
        };
        public static bool s_AuditoryAssitant;
        public static List<EventReminder> s_EventReminders;
    }
}
