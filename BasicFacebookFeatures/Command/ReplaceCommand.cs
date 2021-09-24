
namespace BasicFacebookFeatures.CommandPattern
{
    class ReplaceCommand : Command
    {
        private string m_OldText;
        private string m_NewText;

        public ReplaceCommand(Document i_Doc, string i_OldText, string i_NewText) : base(i_Doc)
        {
            m_Doc = i_Doc;
            m_OldText = i_OldText;
            m_NewText = i_NewText;
        }
        public override bool execute()
        {
            if (m_OldText == "" && m_NewText != "") return false;
            backup();
            m_Doc.Text.Replace(m_OldText, m_NewText);
            return true;
        }


    }
}
