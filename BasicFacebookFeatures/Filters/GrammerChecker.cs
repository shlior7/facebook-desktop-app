using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.CommandPattern;
using NHunspell;

namespace BasicFacebookFeatures.Filters
{
    public class GrammerChecker : Filter
    {
        public override void Handle(Document i_Text)
        {
            using (Hunspell hunspell = new Hunspell())
            {
                hunspell.Load("../../en_us.aff", "../../en_us.dic");
                string[] words = i_Text.Text.Split(' ');
                foreach (string word in words)
                {
                    if (!word.Contains('*') && !hunspell.Spell(word))
                    {
                        MessageBox.Show($"Spell Mistake Detected: `{word}`");
                        List<string> suggestions = hunspell.Suggest(word);
                        if (suggestions.Count() > 0)
                        {
                            suggestions.Add(word);
                            SuggetionPicker suggetionForm = new SuggetionPicker(suggestions);
                            suggetionForm.ShowDialog();
                            if (suggetionForm.Confirmed)
                            {
                                Command command = new ReplaceCommand(i_Text, word, suggetionForm.SelectedSuggestion);
                                if (command.Execute())
                                {
                                    i_Text.History.Push(command);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Suggestion");
                        }
                    }
                }
            }

            base.Handle(i_Text);
        }
    }
}
