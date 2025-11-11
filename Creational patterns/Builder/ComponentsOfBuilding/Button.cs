using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder.ComponentsOfBuilding
{
    public class Button
    {
        public Icon? icon { get; set; }
        public Text? text { get; set; }
        public Background? background { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sizes: Height={height}px, Width={width}px");
            sb.AppendLine(background?.ToString() ?? "Background: Not Set");
            sb.AppendLine(text?.ToString() ?? "Text: Not Set");
            sb.AppendLine(icon?.ToString() ?? "Icon: Not Set");
            return sb.ToString();
        }
    }
}
