using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Command
{
    class CensorCommand : ICommand
    {
        private Document m_Text;
        private string m_TextToCensor;

        public CensorCommand(Document i_Text, string i_TextToCensor)
        {
            m_Text = i_Text;
            m_TextToCensor = i_TextToCensor;
        }
        public void execute()
        {
            m_Text.CensorWord(m_TextToCensor);
        }
    }
}
