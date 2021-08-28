using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostingManager : IPoster
    {
        private User m_LoggedInUser;

        public PostingManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public Status PostStatus(string i_Message)
        {
            return m_LoggedInUser.PostStatus(i_Message);
        }
    }
}
