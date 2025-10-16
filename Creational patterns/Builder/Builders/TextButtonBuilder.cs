using Patterns_Builder;
using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class TextButtonBuilder : IBuilder
    {
        StringBuilder _textButton = new StringBuilder(" ");

        public TextButtonBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _textButton = new StringBuilder();
            _textButton.AppendLine("Text Button Configuration");
        }
        public void SetSizes(int height, int width)
        {
            _textButton.AppendLine($"Height: {height}px, Width: {width}px");
        }
        public void SetBackground(string background)
        {
            _textButton.AppendLine($"Background: {background}");
        }
        public void SetText(string text)
        {
            _textButton.AppendLine($"Text Content: {text}");
        }
        public void SetIcon(string icon)
        {
            _textButton.AppendLine($"Icon: {icon}");
        }
        public StringBuilder GetInfo()
        {
            var result = _textButton;
            Console.WriteLine("\nBuilt Product Output");
            Console.WriteLine(result.ToString());
            this.Reset();
            return result;
        }
    }
}
