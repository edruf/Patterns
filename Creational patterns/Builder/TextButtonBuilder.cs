using Patterns_Builder;
using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class TextButtonBuilder : IBuilder
    {
        StringBuilder _textButton = new StringBuilder();

        public TextButtonBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _textButton.Clear();
        }
        public void SetSizes(int height, int width)
        {
            _textButton.Append(height);
            _textButton.Append(width);
        }
        public void SetBackground(string background)
        {
            _textButton.Append(background);
        }
        public void SetText(string text)
        {
            _textButton.Append(text);
        }
        public void SetIcon(string icon)
        {
            _textButton.Append(icon);
        }
        public StringBuilder GetInfo()
        {
            var result = _textButton;
            this.Reset();
            return result;
        }
    }
}
