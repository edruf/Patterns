using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Decorator
{

    internal class LoggerDecorator : BaseDecorator
    {
        public LoggerDecorator(IButton button) : base(button)
        {
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
            Button.OnClick();
        }
    }    
}

