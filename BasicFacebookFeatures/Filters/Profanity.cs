using BasicFacebookFeatures.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Filters
{
    class Profanity : Filter
    {
        ProfanityFilter.ProfanityFilter m_ProfanityFilter;

        public virtual void handle(ref string i_Text)
        {
            //m_Command = new CensorCommand(); 
            //StringBuilder statusToPost = new StringBuilder(i_Text);
            //ReadOnlyCollection<string> swearList = m_ProfanityFilter.DetectAllProfanities(i_Text, true);

            //foreach (string word in swearList)
            //{
            //    string censoredWord = censorWord(word);
            //    if (MessageBox.Show($"Would you like to censor the word to `{censoredWord}`?", $"Bad Word Detected: `{word}`", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        statusToPost.Replace(word, censoredWord);
            //    }
            //}

            //return statusToPost.ToString();
        }
    }
}
