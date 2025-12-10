using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Handlers
{
    internal class ClickHandler : Handler
    {
        private Handler _nextHandler;

        public void setNext(Handler handler)
        {
            _nextHandler = handler;
        }

        public void handle(Button button) 
        {
            Console.WriteLine("С кнопкой произведено действие");
        }
    }
}
