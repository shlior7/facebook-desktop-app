using FacebookWrapper.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace BasicFacebookFeatures
{

    public class PostingProxy : Poster
    {
        PostingManager m_PostManager;
        readonly ProfanityFilter.ProfanityFilter m_Filter;

        public PostingProxy(User i_LoggedInUser)
        {

            m_PostManager = new PostingManager(i_LoggedInUser);
            m_Filter = new ProfanityFilter.ProfanityFilter();
        }

        public Status PostStatus(string i_Status)
        {
            string statusToPost;

            statusToPost = validate(i_Status);
            MessageBox.Show($"status posted {statusToPost}");
            return m_PostManager.PostStatus(statusToPost);
        }

        private string validate(string i_Status)
        {
            StringBuilder statusToPost = new StringBuilder(i_Status);
            ReadOnlyCollection<string> swearList = m_Filter.DetectAllProfanities(i_Status, true);
            foreach (string word in swearList)
            {
                string censoredWord = censorWord(word);
                if (MessageBox.Show($"Would you like to censor the word to `{censoredWord}`?", $"Bad Word Detected: `{word}`", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    statusToPost.Replace(word, censoredWord);
                }
            }

            return statusToPost.ToString();
        }
        private string censorWord(string i_Word)
        {
            StringBuilder censoredWord = new StringBuilder();
            for (int i = 0; i < i_Word.Length; i++)
            {
                if (i == 0 || i == i_Word.Length - 1)
                {
                    censoredWord.Append(i_Word.ElementAt(i));
                }
                else
                {
                    censoredWord.Append('*');
                }
            }
            return censoredWord.ToString();
        }
    }
}
