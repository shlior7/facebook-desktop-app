using System.Windows.Forms;
using System.Collections.ObjectModel;
using BasicFacebookFeatures.CommandPattern;

namespace BasicFacebookFeatures.Filters
{
    public class FilterProfanity : Filter
    {
        private ProfanityFilter.ProfanityFilter m_ProfanityFilter;

        public FilterProfanity()
        {
            m_ProfanityFilter = new ProfanityFilter.ProfanityFilter();
        }

        public override void Handle(Document i_Text)
        {
            ReadOnlyCollection<string> swearList = m_ProfanityFilter.DetectAllProfanities(i_Text.Text, true);

            foreach (string word in swearList)
            {
                if (MessageBox.Show($"Would you like to censor the word?", $"Bad Word Detected: `{word}`", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Command command = new CensorCommand(i_Text, word);
                    if (command.Execute())
                    {
                        i_Text.History.push(command);
                    }
                }
            }

            base.Handle(i_Text);
        }
    }
}
