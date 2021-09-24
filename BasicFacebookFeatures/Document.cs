using BasicFacebookFeatures.CommandPattern;

namespace BasicFacebookFeatures
{
    public class Document
    {
        private string m_Text;
        private CommandHistory m_History;

        public Document(string i_Text)
        {
            History = new CommandHistory();
            m_Text = i_Text;
        }

        public void Undo()
        {
            if (!History.IsEmpty())
            {
                Command command = History.Pop();
                if (command != null)
                {
                    command.Undo();
                }
            }
        }

        public string Text
        {
            get => m_Text;
            set => m_Text = value;
        }

        public CommandHistory History
        {
            get => m_History;
            set => m_History = value;
        }
    }
}
