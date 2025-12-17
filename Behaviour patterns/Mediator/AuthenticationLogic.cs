using Mediator.UIComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal class AuthenticationLogic
    {
        public void Process(object sender, string ev, TextBox email, TextBox pass, Button login) 
        {
            if (ev == "TextChanged")
            {
                if (!email.IsEmpty() && !pass.IsEmpty())
                {
                    login.Enable();
                }
                else
                {
                    login.Disable();
                }
            }

            if (ev == "ButtonClicked")
            {
                Console.WriteLine("AuthDialog: Успешная аутентификация! Закрываю окно...");
            }
        }
    }
}
