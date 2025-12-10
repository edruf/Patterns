using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Handlers
{
    internal interface Handler
    {
        public void setNext(Handler handler); 
        
        public void handle(Button button);
    }
}
