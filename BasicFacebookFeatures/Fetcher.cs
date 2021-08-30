using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class Fetcher
    {
        private User m_LoggedInUser;
        private MyAssistant m_FacyTheAssistant;

        public Fetcher(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_FacyTheAssistant = MyAssistant.GetAssistantInstance;
        }

        public bool Fetch(ListBox i_listBoxToFill, eFetchingField i_WhatToFetch)
        {
            bool fetchedSuccesfully = false;

            switch (i_WhatToFetch)
            {
                case eFetchingField.Posts:
                    fetchedSuccesfully = fetchPosts(i_listBoxToFill);
                    break;
                case eFetchingField.Events:
                    fetchedSuccesfully = fetchEvents(i_listBoxToFill);
                    break;
                case eFetchingField.LikedPages:
                    fetchedSuccesfully = fetchLikedPages(i_listBoxToFill);
                    break;
                case eFetchingField.FavoriteTeams:
                    fetchedSuccesfully = fetchFavoriteTeams(i_listBoxToFill);
                    break;
                case eFetchingField.Groups:
                    fetchedSuccesfully = fetchGroups(i_listBoxToFill);
                    break;
                case eFetchingField.Albums:
                    fetchedSuccesfully = fetchAlbums(i_listBoxToFill);
                    break;
            }

            return fetchedSuccesfully;
        }

        public void Unfetch(LinkLabel i_LinkLabelToFetch, ListBox i_ListBoxToClear, PictureBox i_PictureBoxImageToNull = null)
        {
            i_LinkLabelToFetch.Invoke(new Action(() => i_LinkLabelToFetch.Text = i_LinkLabelToFetch.Text.Replace("Unfetch", "Fetch")));
            i_ListBoxToClear.Invoke(new Action(() => i_ListBoxToClear.Items.Clear()));
            i_PictureBoxImageToNull?.Invoke(new Action(() => i_PictureBoxImageToNull.Image = null));
        }

        private bool fetchPosts(ListBox i_ListBoxPosts)
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

                i_ListBoxPosts.Invoke(new Action(() => i_ListBoxPosts.Items.Add(messageToShowAsListItem)));
            }

            if (i_ListBoxPosts.Items.Count == 0)
            {
                SpeakingMessageBox.Show("No Posts to retrieve :(");
                return false;
            }

            return true;
        }

        private bool fetchAlbums(ListBox i_ListBoxAlbums)
        {
            bool didntFound = true;
            i_ListBoxAlbums.DisplayMember = "Name";

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
                    i_ListBoxAlbums.Invoke(new Action(() => i_ListBoxAlbums.Items.Add(album)));
                }
            }

            return didntFound;
        }

        private bool fetchEvents(ListBox i_ListBoxEvents)
        {
            bool didntFound = true;
            i_ListBoxEvents.DisplayMember = "Name";

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
                    i_ListBoxEvents.Invoke(new Action(() => i_ListBoxEvents.Items.Add(fbEvent)));
                }
            }

            return didntFound;
        }

        private bool fetchFavoriteTeams(ListBox i_ListBoxFavoriteTeams)
        {
            bool didntFound = true;
            i_ListBoxFavoriteTeams.DisplayMember = "Name";

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
                    i_ListBoxFavoriteTeams.Invoke(new Action(() => i_ListBoxFavoriteTeams.Items.Add(team)));
                }
            }

            return didntFound;
        }

        private bool fetchLikedPages(ListBox i_ListBoxPages)
        {
            bool didntFound = true;

            i_ListBoxPages.DisplayMember = "Name";
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
                    i_ListBoxPages.Invoke(new Action(() => i_ListBoxPages.Items.Add(page)));
                }
            }

            return didntFound;
        }

        private bool fetchGroups(ListBox i_ListBoxGroups)
        {
            bool didntFound = true;

            i_ListBoxGroups.DisplayMember = "Name";
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
                    i_ListBoxGroups.Invoke(new Action(() => i_ListBoxGroups.Items.Add(group)));
                }
            }

            return didntFound;
        }
    }
}
