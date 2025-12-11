using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    internal abstract class ACommand
    {
        protected Editor _editor;
        private string _backup;

        public ACommand(Editor editor)
        {
            _editor = editor;
        }

        public void BackUp() 
        { 
            _backup = _editor.Text;
        }

        public void Undo() 
        { 
            _editor.Text = _backup;
        }

        public abstract bool Execute();
    }
}
