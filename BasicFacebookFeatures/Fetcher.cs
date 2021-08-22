using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class Fetcher
    {
        private static MyAssistant m_FacyTheAssistant;
        private static User m_LoggedInUser;
        public static List<ListBox> boxes = new List<ListBox>();


        public static User LoggedInUser
        {
            set
            {
                m_LoggedInUser = value;
            }
        }
        public static MyAssistant FacyTheAssistant
        {
            set
            {
                m_FacyTheAssistant = value;
            }
        }

        /*
        //public static List<string> fetchAlbums()
        //{
        //    List<string> items = new List<string>();

        //    if (m_LoggedInUser.Albums.Count == 0)
        //    {
        //        MessageBox.Show("No Albums to retrieve :(");
        //        m_FacyTheAssistant.Speak("No Albums to display!");
        //    }
        //    else
        //    {
        //        m_FacyTheAssistant.Speak("Displaying Albums!");
        //        foreach (Album album in m_LoggedInUser.Albums)
        //        {
        //            items.Add(album.Name);
        //        }
        //    }
        //    return items;

        //}


        //public static List<string> fetchPosts()
        //{
        //    List<string> items = new List<string>();

        //    m_FacyTheAssistant.Speak("Fetching Posts!");

        //    foreach (Post post in m_LoggedInUser.Posts)
        //    {
        //        if (post.Message != null)
        //        {
        //            items.Add(post.Message);
        //        }
        //        else if (post.Caption != null)
        //        {
        //            items.Add(post.Caption);
        //        }
        //        else
        //        {
        //            items.Add(string.Format("[{0}]", post.Type));
        //        }
        //    }

        //    if (items.Count == 0)
        //    {
        //        MessageBox.Show("No Posts to retrieve :(");

        //    }
        //    return items;
        //}
        */
        public static bool fetchPosts(ListBox listBoxPosts)
        {
            listBoxPosts.Items.Clear();
            m_FacyTheAssistant.Speak("Fetching Posts!");

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
                MessageBox.Show("No Albums to retrieve :(");
                m_FacyTheAssistant.Speak("No Albums to display!");
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Albums!");
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxAlbums.Items.Add(album);
                }
            }

            return didntFound;
        }

        public static bool fetchEvents(ListBox listBoxEvents)
        {
            bool didntFound = true;
            listBoxEvents.DisplayMember = "Name";

            if (m_LoggedInUser.Events.Count== 0)
            {
                MessageBox.Show("No Events to retrieve :(");
                m_FacyTheAssistant.Speak("No Events to display!");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying events!");
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(fbEvent);
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
                MessageBox.Show("No teams to retrieve :(");
                m_FacyTheAssistant.Speak("No Teams to display!");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Teams!");
                foreach (Page team in m_LoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeams.Items.Add(team);
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
                MessageBox.Show("No liked pages to retrieve :(");
                m_FacyTheAssistant.Speak("No Liked Pages to display!");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Liked Pages!");
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
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
                MessageBox.Show("No groups to retrieve :(");
                m_FacyTheAssistant.Speak("No groups to retrieve!");
                didntFound = false;
            }
            else
            {
                m_FacyTheAssistant.Speak("Displaying Groups!");
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }

            return didntFound;
        }
    }

}
