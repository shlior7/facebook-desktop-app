using System.Linq;
using System.Text;

namespace BasicFacebookFeatures.CommandPattern
{
    public class CensorCommand : Command
    {
        private string m_TextToCensor;

        public CensorCommand(Document i_Text, string i_textToCensor) : base(i_Text)
        {
            m_TextToCensor = i_textToCensor;
        }

        public override bool execute()
        {
            if (m_TextToCensor == "") return false;
            backup();
            m_Doc.Replace(m_TextToCensor, censorWord(m_TextToCensor));
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
