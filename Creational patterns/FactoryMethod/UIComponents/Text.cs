using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod.UIComponents
{
    internal class UIText : UIComponent
    {
        public string Text { get; set; }
        public UIText(string text)
        {
            Text = text;
        }
        public override void Render()
        {
            Console.WriteLine($"Рендерим текст: {Text}");
        }
    }
}
