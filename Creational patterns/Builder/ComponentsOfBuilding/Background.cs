using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder.ComponentsOfBuilding
{
    public class Background
    {
        private string background;
        public Background(string background)
        {
            this.background = background;
        }

        public override string ToString() => $"Background Color: {background}";
    }
}
