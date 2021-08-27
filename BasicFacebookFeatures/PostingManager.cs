using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Status status = new Status();
            return status;
        }
    }
}
