using Chain.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    internal class Button 
    {
        private bool _blocked = false;
        private Handler _handler;

        public Button(Handler handler) 
        {
            _handler = handler;
        }

        public void Block() 
        { 
            _blocked = true;
        }

        public void Unblock()
        {
            _blocked = false;
        }

        public bool IsBlocked() 
        { 
            return _blocked;
        }

        public void OnClick()
        {
            _handler.handle(this);
        }
    }
}
