using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Command
{
    class WriteCommand : ICommand
    {
        private Document m_Text;
        private string m_TextToAdd;

        public WriteCommand(Document i_Text, string i_TextToAdd)
        {
            m_Text = i_Text;
            m_TextToAdd = i_TextToAdd;
        }
        public void execute()
        {
            m_Text.Write(m_TextToAdd);
        }
    }
}
