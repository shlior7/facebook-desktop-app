using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Command
{
    class ReplaceCommand : ICommand
    {
        private Document m_Text;
        private string m_OldText;
        private string m_NewText;

        public ReplaceCommand(Document i_Text, string i_OldText, string i_NewText)
        {
            m_Text = i_Text;
            m_OldText = i_OldText;
            m_NewText = i_NewText;
        }
        public void execute()
        {
            m_Text.Replace(m_OldText, m_NewText);
        }
    }
}
