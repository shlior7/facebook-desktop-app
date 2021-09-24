using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.CommandPattern
{
    public class CommandHistory
    {
        private Stack<Command> history = new Stack<Command>();

        public void push(Command c)
        {
            history.Push(c);
        }

        public Command pop()
        {
            return history.Pop();
        }

        public bool isEmpty() 
        { 
            return history.Count() == 0;
        }
    }
}
