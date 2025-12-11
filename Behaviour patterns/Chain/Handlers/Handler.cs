using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Handlers
{
    internal abstract class Handler
    {
        protected Handler _nextHandler;

        public Handler(Handler handler) 
        { 
            _nextHandler = handler;
        }
        public abstract void handle(Button button);
    }
}
