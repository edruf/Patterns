using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Prototype
{
    internal class WinButton : ICopyable<WinButton>, IButton
    {
        private string _text;
        private string _color;

        public WinButton(string text, string color)
        {
            if(text == null || color == null) throw new ArgumentNullException();
            _text = text;
            _color = color;
        }
        public void OnClick()
        {
            Console.WriteLine($"Windows кнопка {_text} нажата (цвет: {_color})");
        }
        public void OnDoubleClick()
        {
            Console.WriteLine($"Windows кнопка {_text} нажата дважды (цвет: {_color})");
        }
        public WinButton Copy()
        {
            WinButton copy = new WinButton(_text, _color);
            return copy;
        }

        //public void SetText(string text)
        //{
        //    _text = text;
        //}

        //public void SetColor(string color)
        //{
        //    _color = color;
        //}
        public override string ToString()
        {
            return "text : " + _text + ", " + " color : " + _color;
        }
    }
}
