using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns__Singletone
{
    internal class WinButton : IButton
    {
        private string _text;
        private string _color;
        private static WinButton _instance;

        private WinButton(string text, string color)
        {
            _text = text;
            _color = color;
        }

        public static WinButton GetInstance(string text = "Старт", string color = "blue")
        {
            if (_instance == null)
            {
                _instance = new WinButton(text, color);
            }
            return _instance;
        }

        public void OnClick()
        {
            Console.WriteLine($"Windows кнопка '{_text}' нажата (цвет: {_color})");
        }

        public void OnDoubleClick()
        {
            Console.WriteLine($"Windows кнопка '{_text}' нажата дважды (цвет: {_color})");
        }

        public string GetState()
        {
            return $"text: {_text}, color: {_color}";
        }
    }
}
