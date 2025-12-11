using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    internal class PasteCommand : ACommand
    {
        public PasteCommand(Editor editor) : base(editor)
        {
        }

        public override bool Execute()
        {
            BackUp();
            _editor.ReplaceSelection(Clipboard.Content);
            return true;
        }
    }
}
