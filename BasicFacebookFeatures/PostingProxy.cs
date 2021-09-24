using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Filters;

namespace BasicFacebookFeatures
{
    public class PostingProxy : IPoster
    {
        private PostingManager m_PostManager;

        public PostingProxy(User i_LoggedInUser)
        {
            m_PostManager = new PostingManager(i_LoggedInUser);
        }

        private void handleFilter(Document i_StatusEditor)
        {
            IHandler profanity = new FilterProfanity();
            IHandler grammer = new GrammerChecker();
            profanity.setNextHandler(grammer);
            profanity.Handle(i_StatusEditor);
        }

        public Status PostStatus(string i_Status)
        {
            string statusToPost;
            Document statusEditor = new Document(i_Status);

            handleFilter(statusEditor);
            statusToPost = statusEditor.Text;
            ConfirmPosting formConfirmPosting = new ConfirmPosting(statusEditor);
            formConfirmPosting.ShowDialog();
            if (!formConfirmPosting.Confirmed)
            {
                throw new System.Exception("Posting not confirmed");
            }

            statusToPost = statusEditor.Text;
            MessageBox.Show(statusToPost, "Confirmed Status!");
            m_PostManager.PostStatus(statusToPost);
            return m_PostManager.PostStatus(statusToPost);
        }
    }
}
