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
        ButtonBuilder builder;
        public UIClient(ButtonBuilder builder)
        {
            if (null == builder) throw new ArgumentNullException();
            this.builder = builder;
        }
        public Button GetButtonWithIcon(string icon)
        {
            builder.SetSizes(20, 100);
            builder.SetIcon(icon);
            return builder.GetButton();
        }
    }
}
