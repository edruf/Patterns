using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod
{
    internal class Text : UIComponent
    {
        public string _text { get; set; }
        public Text(string text)
        {
            _text = text;
        }
        public override void Render()
        {
            Console.WriteLine($"Рендерим текст: {_text}");
        }
    }
}
