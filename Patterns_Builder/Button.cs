using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    internal class Button
    {
        public Icon? icon { get; set; }
        public Text? text { get; set; }
        public Background? background { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }

    }
}
