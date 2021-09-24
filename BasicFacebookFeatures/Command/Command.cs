namespace BasicFacebookFeatures.CommandPattern
{
    public abstract class Command
    {
        public Document m_Doc;
        private string m_Backup;

        public Command(Document editor)
        {
            this.m_Doc = editor;
        }

        protected void backup()
        {
            m_Backup = m_Doc.Text;
        }

        public void Undo()
        {
            m_Doc.Text = m_Backup;
        }

        public abstract bool Execute();
    }
}
