using System.Windows.Forms;

namespace BasicFacebookFeatures.CommandPattern
{
    public class ReplaceCommand : Command
    {
        private string m_OldText;
        private string m_NewText;

        public ReplaceCommand(Document i_Doc, string i_OldText, string i_NewText) : base(i_Doc)
        {
            m_Document = i_Doc;
            m_OldText = i_OldText;
            m_NewText = i_NewText;
        }

        public override bool Execute()
        {
            if (m_OldText == string.Empty && m_NewText != string.Empty)
            {
                return false;
            }

            backup();
            m_Document.Text = m_Document.Text.Replace(m_OldText, m_NewText);
            return true;
        }
    }
}
