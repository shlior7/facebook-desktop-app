using BasicFacebookFeatures.CommandPattern;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class Document
    {
        private string m_Text;
        private CommandHistory m_History;

        public Document(string i_Text)
        {
            m_History = new CommandHistory();
            m_Text = i_Text;
        }

        public void Undo()
        {
            if (m_History.isEmpty())
            {
                return;
            }

            Command command = m_History.pop();
            if (command != null)
            {
                command.undo();
            }
        }

        public void Censor(string i_ToCensor)
        {
            executeCommand(new CensorCommand(this, i_ToCensor));
        }

        public void Replace(string i_OldText, string i_NewText)
        {
            executeCommand(new ReplaceCommand(this, i_OldText, i_NewText));
        }

        private void executeCommand(Command command)
        {
            if (command.Execute())
            {
                m_History.push(command);
            }
        }

        public string Text
        {
            get => m_Text;
            set => m_Text = value;
        }
    }
}
