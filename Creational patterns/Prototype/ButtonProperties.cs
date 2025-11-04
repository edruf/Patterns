using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class ButtonProperties
    {
       public int BorderWidth { get; set; }
       public string ShadowType { get; set; }

        public ButtonProperties(int borderWidth, string shadowType)
        {
            BorderWidth = borderWidth;
            ShadowType = shadowType;
        }

        public ButtonProperties Copy()
        {
            return new ButtonProperties(this.BorderWidth, this.ShadowType);
        }

        public override string ToString()
        {
            return $"[Border: {BorderWidth}px, Shadow: {ShadowType}]";
        }
    }
}
