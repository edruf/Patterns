using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Handlers
{
    internal class BlockHandler : Handler
    {

        public BlockHandler(Handler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(Button button)
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
