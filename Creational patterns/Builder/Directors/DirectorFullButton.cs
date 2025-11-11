using Patterns_Builder;
using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Builder.Directors
{
    public class DirectorFullButton
    {
        private IBuilder _builder;

        public IBuilder Builder
        { 
            set { _builder = value; } 
        }

        public void BuildFullButton() 
        {
            _builder.Reset();
            _builder.SetSizes(20, 100);
            _builder.SetText("Testing Full Button");
            _builder.SetIcon("SomeIcon");
            _builder.SetBackground("SomeBackground");
        }
    }
}
