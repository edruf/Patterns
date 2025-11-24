using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Decorator
{

    internal class LoggerDecorator : BaseDecorator
    {
        private IButton _button;
        public LoggerDecorator(IButton button) : base(button)
        {
            _button = button;
        }

        public string Logger()
        {
            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            return ($"кнопка нажата пользователем в {time}");
        }

        public override void OnClick()
        {
            string log = Logger();
            Console.WriteLine(log);
            _button.OnClick();
        }
    }    
}

