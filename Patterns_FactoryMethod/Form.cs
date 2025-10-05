using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod
{
    internal class Form : UIComponent
    {
        public int _width { get; set; }
        public int _height { get; set; }

        public override void Render()
        {
            Console.WriteLine($"Рендерим форму: Width={_width}, Height={_height}");
        }
    }
}
