using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder.ComponentsOfBuilding
{
    internal class Text
    {
        public string text;
        public Text(string text)
        {
            this.text = text;
        }
        public override string ToString() => $"Text Content: \"{text}\"";
    }
}
