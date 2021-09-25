using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.CommandPattern
{
    public class CommandHistory
    {
        private Stack<Command> m_History = new Stack<Command>();

        public void Push(Command i_Command)
        {
            m_History.Push(i_Command);
        }

        public Command Pop()
        {
            return m_History.Pop();
        }

        public bool IsEmpty()
        {
            return m_History.Count() == 0;
        }
    }
}
