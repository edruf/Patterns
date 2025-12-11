using Command.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    internal class Button
    {
        private ACommand _command;
        private CommandHistory _history;
        public Button(ACommand command, CommandHistory history)
        {
            _command = command;
            _history = history;
        }
        public void Click()
        {
            if (_command.Execute())
            {
                _history.Push(_command);
            }
        }
    }
}
