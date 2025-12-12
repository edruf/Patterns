using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Handlers
{
    internal class ClickHandler : Handler
    {

        public ClickHandler(Handler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(Button button) 
        {
            Console.WriteLine("С кнопкой произведено действие");
        }
    }
}
