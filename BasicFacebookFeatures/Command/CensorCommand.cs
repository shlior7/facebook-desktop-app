using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicFacebookFeatures.CommandPattern
{
    public class CensorCommand : Command
    {
        private string m_TextToCensor;

        public CensorCommand(Document i_Text, string i_textToCensor) : base(i_Text)
        {
            m_TextToCensor = i_textToCensor;
        }

        public override bool Execute()
        {
            if (m_TextToCensor == string.Empty)
            {
                return false;
            }

            backup();
            Command command = new ReplaceCommand(m_Doc, m_TextToCensor, censorWord(m_TextToCensor));
            if (command.Execute())
            {
                m_Doc.History.push(command);
            }

            return true;
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
