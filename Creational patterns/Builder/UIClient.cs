using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    internal class UIClient
    {
        IBuilder _builder;
        public UIClient(IBuilder builder)
        {
            if (null == builder) throw new ArgumentNullException();
            _builder = builder;
        }
    }
}
