using Patterns_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class DirectorMinimalButton
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalButton()
        {
            _builder.Reset();
            _builder.SetSizes(20, 100);
            _builder.SetText("Testing Simple Button");
        }
    }
}
