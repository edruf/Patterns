using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.UIComponents
{
    internal class Button : UIComponent
    {
        public bool IsEnabled { get; private set; } = false;

        public Button(IMediator mediator) 
        {
            SetMediator(mediator);
        }

        public void Enable()
        {
            IsEnabled = true;
            Console.WriteLine("Button: Кнопка 'Войти' стала АКТИВНОЙ.");
        }

        public void Disable()
        {
            IsEnabled = false;
            Console.WriteLine("Button: Кнопка 'Войти' стала НЕАКТИВНОЙ.");
        }

        public void Click()
        {
            if (IsEnabled) 
            {
                Console.WriteLine("Button: Вход выполнен!");
                Notify("ButtonClicked");
            }
        }
    }
}
