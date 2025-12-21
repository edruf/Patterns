using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.UIComponents
{
    internal class Button : UIComponent
    {
        public bool IsEnabled { get; private set; } 

        public Button(IMediator mediator) : base(mediator) { }

        public void RefreshState(string email, string pass)
        {
            bool isValid = !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pass);

            if (IsEnabled != isValid)
            {
                IsEnabled = isValid;
                Console.WriteLine($"[Button] Состояние изменено: IsEnabled = {IsEnabled}");
            }
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
                Notify("LoginAction");
            }
            else
            {
                Console.WriteLine("[Button] Клик проигнорирован (кнопка неактивна).");
            }
        }
    }
}
