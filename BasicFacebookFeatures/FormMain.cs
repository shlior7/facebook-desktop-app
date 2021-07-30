﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using TestBed;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;
        LoginResult m_LoginResult;
        public FormMain()
        {
            FormLogin loginForm = new FormLogin();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            if (loginForm.LoggedInUser != null)
            //     string access = "EAAFSD8o8IEMBADJQwkmXhGbHTQtNKZCVNyWsALC9GJxv1SmuBCtb1pjAEntW7MZBapm0EvAZCWyPHulVsTCU7IjIefuXhgg5HtrUmVTzGmjWTs22rCe72XDyeqy5vATaUguHq2L9S7qSM4YuT1FN9Uiov7SH3KbifC1ZBDo0JQZDZD";
            //     LoginResult m_LoginResult = FacebookService.Connect(access);
            m_LoginResult = FacebookService.Login("371702747635779", /// (desig patter's "Design Patterns Course App 2.4" app)
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
                    "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = loginForm.LoggedInUser;
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    InitializeComponent();
                    FacebookWrapper.FacebookService.s_CollectionLimit = 200;
                }
                
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

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxFavoriteTeams.SelectedItem as Page;
                pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }

        private void linkFavoriteTeams_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Items.Clear();
            listBoxFavoriteTeams.DisplayMember = "Name";
            foreach (Page team in m_LoggedInUser.FavofriteTeams)
            {
                listBoxFavoriteTeams.Items.Add(team);
            }

            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show("No teams to retrieve :(");
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
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
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
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
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
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings();
            }
            m_FormAppSettings.ShowDialog();
        }
        public struct Friend
        {
            public User friend;
            public int sharedThings;
        }
        public class SharedStuff
        {
            public int events;
            public int posts;
            public int groups;
            public int pages;

            public SharedStuff(int i_events, int i_posts, int i_groups)
            {
                this.events = i_events;
                this.posts = i_posts;
                this.groups = i_groups;
            }

        }
        public class BySharedThings : IComparer<Friend>
        {
            public int Compare(Friend x, Friend y)
            {
                return x.sharedThings.CompareTo(y.sharedThings);
            }
        }
        ///// DOTO To Style like the mf wants
        private void BestFriendButton_Click(object sender, EventArgs e)
        {
            Friend curFriend = new Friend();
            bool flag = false;
            Dictionary<User, SharedStuff> potentialBestiess = new Dictionary<User, SharedStuff>();
            SortedSet<Friend> potentialBesties = new SortedSet<Friend>(new BySharedThings());
            Dictionary<string, string> myPages = new Dictionary<string, string>();
            foreach (Group group in m_LoggedInUser.Groups)
            {
                foreach (User friend in group.Members)
                {
                    if (potentialBestiess.ContainsKey(friend))
                    {
                        potentialBestiess[friend].groups++;
                    }
                    else
                    {

                        potentialBestiess.Add(friend, new SharedStuff(0, 0, 1));
                    }
                }
            }
            foreach (Post post in m_LoggedInUser.Posts)
            {
                foreach (User friend in post.LikedBy)
                {
                    if (potentialBestiess.ContainsKey(friend))
                    {
                        potentialBestiess[friend].posts++;
                    }
                    else
                    {
                        potentialBestiess.Add(friend, new SharedStuff(0, 1, 0));
                    }
                }
            }
            foreach (Event myEvent in m_LoggedInUser.Events)
            {
                foreach (User attending in myEvent.AttendingUsers)
                {
                    if (potentialBestiess.ContainsKey(attending))
                    {
                        potentialBestiess[attending].events++;
                    }
                    else
                    {
                        potentialBestiess.Add(attending, new SharedStuff(1, 0, 0));
                    }
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
                            potentialBestiess[friend].pages++;
                        }
                    }
                }
            }
            Console.WriteLine(m_LoggedInUser.Friends.Count);
            Console.WriteLine(myPages.Count);
            Console.WriteLine("Check");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {

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
            "user_videos"};
    }
}
