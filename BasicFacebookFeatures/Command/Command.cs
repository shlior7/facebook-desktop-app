namespace BasicFacebookFeatures.CommandPattern
{
    public abstract class Command
    {
        public Document m_Document;
        private string m_Backup;

        public Command(Document i_Document)
        {
            this.m_Document = i_Document;
        }

        protected void backup()
        {
            m_Backup = m_Document.Text;
        }

        public void Undo()
        {
            m_Document.Text = m_Backup;
        }

        public abstract bool Execute();
    }
}
