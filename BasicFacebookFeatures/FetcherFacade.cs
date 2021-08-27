using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class Fetcher
    {
        private static Fetcher s_Fetcher;
        private static MyAssistant m_FacyTheAssistant;
        private static User m_LoggedInUser;

        private Fetcher(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_FacyTheAssistant = MyAssistant.GetAssistantInstance;
        }

        public static Fetcher getFetcherInstance(User i_LoggedInUser = null)
        {
            if (s_Fetcher == null)
            {
                if (i_LoggedInUser == null)
                {
                    throw new Exception("Fetcher has not been set you must provide the logged in User");
                }

                s_Fetcher = new Fetcher(i_LoggedInUser);
            }

            return s_Fetcher;
        }
      
        public void ToggleFetches(LinkLabel i_FetchLinkLabel, ListBox i_FetchedData, FetchingFields i_WhatToFetch, PictureBox i_FetchedPicture = null, Action<bool> i_UnShowAction = null)
        {
            try
            {
                if (i_FetchedData.Items.Count > 0)
                {
                    i_FetchLinkLabel.Invoke(new Action(() => i_FetchLinkLabel.Text = i_FetchLinkLabel.Text.Replace("Unfetch", "Fetch")));
                    if (i_FetchedPicture != null)
                    {
                        i_FetchedPicture.Invoke(new Action(() => i_FetchedPicture.Image = null));
                    }
                    i_UnShowAction?.Invoke(false);
                    i_FetchedData.Invoke(new Action(() => i_FetchedData.Items.Clear()));
                }
                else
                {
                    if (Fetch(i_FetchedData, i_WhatToFetch))
                    {
                        i_FetchLinkLabel.Invoke(new Action(() => i_FetchLinkLabel.Text = i_FetchLinkLabel.Text.Replace("Fetch", "Unfetch")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToggleFetches(LinkLabel i_FetchLinkLabel, ListBox i_FetchedData, FetchingFields i_WhatToFetch, PictureBox i_FetchedPicture = null, Action<bool> i_UnShowAction = null)
        {
            try
            {
                if (i_FetchedData.Items.Count > 0)
                {
                    i_FetchLinkLabel.Invoke(new Action(() => i_FetchLinkLabel.Text = i_FetchLinkLabel.Text.Replace("Unfetch", "Fetch")));
                    if (i_FetchedPicture != null)
                    {
                        i_FetchedPicture.Invoke(new Action(() => i_FetchedPicture.Image = null));
                    }
                    i_UnShowAction?.Invoke(false);
                    i_FetchedData.Invoke(new Action(() => i_FetchedData.Items.Clear()));
                }
                else
                {
                    if (Fetch(i_FetchedData, i_WhatToFetch))
                    {
                        i_FetchLinkLabel.Invoke(new Action(() => i_FetchLinkLabel.Text = i_FetchLinkLabel.Text.Replace("Fetch", "Unfetch")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool Fetch(ListBox i_listBoxToFill, FetchingFields i_WhatToFetch)
        {
            bool fetchedSuccesfully = false;

            switch (i_WhatToFetch)
            {
                case FetchingFields.Posts:
                    fetchedSuccesfully = fetchPosts(i_listBoxToFill);
                    break;
                case FetchingFields.Events:
                    fetchedSuccesfully = fetchEvents(i_listBoxToFill);
                    break;
                case FetchingFields.LikedPages:
                    fetchedSuccesfully = fetchLikedPages(i_listBoxToFill);
                    break;
                case FetchingFields.FavoriteTeams:
                    fetchedSuccesfully = fetchFavoriteTeams(i_listBoxToFill);
                    break;
                case FetchingFields.Groups:
                    fetchedSuccesfully = fetchGroups(i_listBoxToFill);
                    break;
                case FetchingFields.Albums:
                    fetchedSuccesfully = fetchAlbums(i_listBoxToFill);
                    break;
            }

            return fetchedSuccesfully;
        }

        public static bool fetchPosts(ListBox listBoxPosts)
        {
            m_FacyTheAssistant.Speak("Fetching Posts!");
            foreach (Post post in m_LoggedInUser.Posts)
            {
                string messageToShowAsListItem;
                if (post.Message != null)
                {
                    messageToShowAsListItem = post.Message;
                }
                else if (post.Caption != null)
                {
                    messageToShowAsListItem = post.Caption;
                }
                else
                {
                    messageToShowAsListItem = string.Format("[{0}]", post.Type);
                }

                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(messageToShowAsListItem)));
            }

            if (listBoxPosts.Items.Count == 0)
            {
                SpeakingMessageBox.Show("No Posts to retrieve :(");
                return false;
            }

            return true;
        }

        public static bool fetchAlbums(ListBox listBoxAlbums)
        {
            bool didntFound = true;
            listBoxAlbums.DisplayMember = "Name";

            if (m_LoggedInUser.Albums.Count == 0)
            {
                SpeakingMessageBox.Show("No Albums to retrieve :(");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Albums!");
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                }
            }

            return didntFound;
        }

        public static bool fetchEvents(ListBox listBoxEvents)
        {
            bool didntFound = true;
            listBoxEvents.DisplayMember = "Name";

            if (m_LoggedInUser.Events.Count == 0)
            {
                SpeakingMessageBox.Show("No Events to retrieve :(");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying events!");
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
                }
            }

            return didntFound;
        }

        public static bool fetchFavoriteTeams(ListBox listBoxFavoriteTeams)
        {
            bool didntFound = true;
            listBoxFavoriteTeams.DisplayMember = "Name";

            if (m_LoggedInUser.FavofriteTeams.Length == 0)
            {
                SpeakingMessageBox.Show("No teams to retrieve :(");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Teams!");
                foreach (Page team in m_LoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add(team)));
                }
            }

            return didntFound;
        }

        public static bool fetchLikedPages(ListBox listBoxPages)
        {
            bool didntFound = true;

            listBoxPages.DisplayMember = "Name";
            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                SpeakingMessageBox.Show("No liked pages to retrieve :(");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Liked Pages!");
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(page)));
                }
            }

            return didntFound;
        }

        public static bool fetchGroups(ListBox listBoxGroups)
        {
            bool didntFound = true;

            listBoxGroups.DisplayMember = "Name";
            if (m_LoggedInUser.Groups.Count == 0)
            {
                SpeakingMessageBox.Show("No groups to retrieve :(");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Groups!");
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
                }
            }

            return didntFound;
        }
    }
}
