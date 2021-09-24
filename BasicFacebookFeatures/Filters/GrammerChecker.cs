using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Filters
{
    public class GrammerChecker : Filter
    {
        public override void Handle(Document i_Text)
        {
            using (NHunspell.Hunspell hunspell = new NHunspell.Hunspell("en_us.aff", "en_us.dic"))
            {
                string[] words = i_Text.Text.Split(' ');
                foreach (string word in words)
                {
                    if (!hunspell.Spell(word))
                    {
                        List<string> suggestions = hunspell.Suggest(word);
                        SuggetionPicker suggetionForm = new SuggetionPicker(suggestions);

                        foreach (string suggestion in suggestions)
                        {
                            if (MessageBox.Show($"Would you like to Change the word to `{suggestion}`?", $"Spell Mistake Detected: `{word}`", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                i_Text.Replace(word, suggestion);
                            }
                        }
                    }
                }
            }

            base.Handle(i_Text);
        }
    }
}
