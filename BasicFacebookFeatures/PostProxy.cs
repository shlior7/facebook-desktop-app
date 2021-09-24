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
        private readonly ProfanityFilter.ProfanityFilter m_ProfanityFilter;
        private PostingManager m_PostManager;

        public PostingProxy(User i_LoggedInUser)
        {
            m_PostManager = new PostingManager(i_LoggedInUser);
            m_ProfanityFilter = new ProfanityFilter.ProfanityFilter();
        }

        private string handleFilter(string i_Status)
        {
            Document statusEditor = new Document(i_Status);
            FilterProfanity pf = new FilterProfanity();
            GrammerChecker gc = new GrammerChecker();
            pf.setNextHandler(gc);
            pf.Handle(statusEditor);

            return statusEditor.Text;
        }
        public Status PostStatus(string i_Status)
        {
            string statusToPost;

            statusToPost = handleFilter(i_Status);
            //statusToPost = validate(i_Status);
            return m_PostManager.PostStatus(statusToPost);
        }

        private string validate(string i_Status)
        {
            StringBuilder statusToPost = new StringBuilder(i_Status);
            ReadOnlyCollection<string> swearList = m_ProfanityFilter.DetectAllProfanities(i_Status, true);

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
