using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FetchFacade
    {
        private static FetchFacade s_FetchFacade;
        private Fetcher m_Fetcher;

        private FetchFacade(User i_LoggedInUser)
        {
            m_Fetcher = new Fetcher(i_LoggedInUser);
        }

        public static FetchFacade GetFetcherInstance(User i_LoggedInUser = null)
        {
            if (s_FetchFacade == null)
            {
                if (i_LoggedInUser == null)
                {
                    throw new Exception("Fetcher has not been set you must provide the logged in User");
                }

                s_FetchFacade = new FetchFacade(i_LoggedInUser);
            }

            return s_FetchFacade;
        }

        public void ToggleFetches(LinkLabel i_FetchLinkLabel, ListBox i_FetchedData, eFetchingField i_WhatToFetch, PictureBox i_FetchedPicture = null, Action<bool> i_UnShowAction = null)
        {
            try
            {
                if (i_FetchedData.Items.Count > 0)
                {
                    m_Fetcher.Unfetch(i_FetchLinkLabel, i_FetchedData, i_FetchedPicture);
                    i_UnShowAction?.Invoke(false);
                }
                else
                {
                    if (m_Fetcher.Fetch(i_FetchedData, i_WhatToFetch))
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
    }
}
