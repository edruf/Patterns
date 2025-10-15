using Patterns_Builder;
using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Builder
{
    internal class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        { 
            set { _builder = value; } 
        }

        public void BuildMinimalButton(string text) 
        {
            _builder.Reset();
            _builder.SetSizes(20, 100);
            _builder.SetText(text);
            //Console.WriteLine($"{}");
        }

        public void BuildFullButton(string text, string icon, string background ) 
        {
            _builder.Reset();
            _builder.SetSizes(20, 100);
            _builder.SetText(text);
            _builder.SetIcon(icon);
            _builder.SetBackground(background);
        }
    }
}
