using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    internal class Editor
    {
        public string Text { get; set; } = string.Empty;

        public string GetSelection()
        {
            return Text;
        }

        public void DeleteSelection()
        {
            Text = string.Empty;
        }

        public void ReplaceSelection(string text)
        {
            Text = text;
        }
    }
}
