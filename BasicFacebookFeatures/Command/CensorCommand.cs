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
            m_Document.Text.Replace(m_TextToCensor, censorWord(m_TextToCensor));

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
