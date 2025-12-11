using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    internal class CommandHistory
    {
        private Stack<ACommand> _history = new Stack<ACommand>();

        public void Push(ACommand c)
        {
            _history.Push(c);
        }

        public ACommand Pop() 
        { 
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }
}
