using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder.ComponentsOfBuilding
{
    internal class Icon
    {
        private string icon;
        public Icon(string icon)
        {
            this.icon = icon;
        }
        public override string ToString() => $"Icon Symbol: {icon}";
    }
}
