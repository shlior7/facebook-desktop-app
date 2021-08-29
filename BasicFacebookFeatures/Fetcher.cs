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

        public void Unfetch(LinkLabel i_LinkLabelToFetch, ListBox i_listBoxToClear, PictureBox i_PictureBoxImageToNull = null)
        {
            i_LinkLabelToFetch.Invoke(new Action(() => i_LinkLabelToFetch.Text = i_LinkLabelToFetch.Text.Replace("Unfetch", "Fetch")));
            i_listBoxToClear.Invoke(new Action(() => i_listBoxToClear.Items.Clear()));
            i_PictureBoxImageToNull?.Invoke(new Action(() => i_PictureBoxImageToNull.Image = null));
        }

        private bool fetchPosts(ListBox i_listBoxPosts)
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

                i_listBoxPosts.Invoke(new Action(() => i_listBoxPosts.Items.Add(messageToShowAsListItem)));
            }

            if (i_listBoxPosts.Items.Count == 0)
            {
                SpeakingMessageBox.Show("No Posts to retrieve :(");
                return false;
            }

            return true;
        }

        private bool fetchAlbums(ListBox i_listBoxAlbums)
        {
            bool didntFound = true;
            i_listBoxAlbums.DisplayMember = "Name";

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
                    i_listBoxAlbums.Invoke(new Action(() => i_listBoxAlbums.Items.Add(album)));
                }
            }

            return didntFound;
        }

        private bool fetchEvents(ListBox i_listBoxEvents)
        {
            bool didntFound = true;
            i_listBoxEvents.DisplayMember = "Name";

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
                    i_listBoxEvents.Invoke(new Action(() => i_listBoxEvents.Items.Add(fbEvent)));
                }
            }

            return didntFound;
        }

        private bool fetchFavoriteTeams(ListBox _listBoxFavoriteTeams)
        {
            bool didntFound = true;
            _listBoxFavoriteTeams.DisplayMember = "Name";

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
                    _listBoxFavoriteTeams.Invoke(new Action(() => _listBoxFavoriteTeams.Items.Add(team)));
                }
            }

            return didntFound;
        }

        private bool fetchLikedPages(ListBox i_listBoxPages)
        {
            bool didntFound = true;

            i_listBoxPages.DisplayMember = "Name";
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
                    i_listBoxPages.Invoke(new Action(() => i_listBoxPages.Items.Add(page)));
                }
            }

            return didntFound;
        }

        private bool fetchGroups(ListBox i_listBoxGroups)
        {
            bool didntFound = true;

            i_listBoxGroups.DisplayMember = "Name";
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
                    i_listBoxGroups.Invoke(new Action(() => i_listBoxGroups.Items.Add(group)));
                }
            }

            return didntFound;
        }
    }
}
