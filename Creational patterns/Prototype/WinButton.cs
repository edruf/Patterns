using Prototype;
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
        private string _icon;
        private ButtonProperties _buttonProperties;

        public WinButton(string text, string color, string icon, ButtonProperties buttonProperties)
        {
            if (text == null || color == null | buttonProperties == null) throw new ArgumentNullException();
            _text = text;
            _color = color;
            _icon = icon;
            _buttonProperties = buttonProperties;
        }

        public void SetBorderWidth(int borderWidth)
        {
            _buttonProperties.BorderWidth = borderWidth;
            Console.WriteLine($"... {this._text} рамка изменена на {borderWidth}px");
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
            WinButton copy = new WinButton(_text, _color, _icon, _buttonProperties.Copy());
            return copy;
        }

        public override string ToString()
        {
            return $"Text: {_text}, Color: {_color}, Icon: {_icon}, Properties: {_buttonProperties}";
        }
    }
}
