using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    internal class CopyCommand : ACommand
    {
        public CopyCommand(Editor editor) : base(editor)
        {
        }

        public override bool Execute()
        {
            Clipboard.Content = _editor.GetSelection();
            return false;
        }
    }
}
