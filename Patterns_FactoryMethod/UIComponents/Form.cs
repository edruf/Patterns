using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod.UIComponents
{
    internal class UIForm : UIComponent
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Render()
        {
            Console.WriteLine($"Рендерим форму: Width={Width}, Height={Height}");
        }
    }
}
