using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Handlers
{
    internal class BlockHandler : Handler
    {
        private Handler _nextHandler;

        public void setNext(Handler handler) 
        {
            _nextHandler = handler;
        }

        public void handle(Button button)
        {
            if (button.IsBlocked())
            {
                Console.WriteLine("Кнопка заблокирована");
            }
            else if(_nextHandler != null)
            {
                _nextHandler.handle(button);
            }
        }
    }
}
