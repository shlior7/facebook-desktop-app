using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Command
{
    class EraseCommand : ICommand
    {
        private Document m_Text;
        private string m_TextToErase;

        public EraseCommand(Document i_Text, string i_TextToErase)
        {
            m_Text = i_Text;
            m_TextToErase = i_TextToErase;
        }
        public void execute()
        {
            m_Text.Erase(m_TextToErase);
        }
    }
}
