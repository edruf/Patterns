using Mediator.UIComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Mediators
{
    internal class AuthDialog : IMediator
    {
        private TextBox _emailBox;
        private TextBox _passwordBox;
        private Button _loginButton;

        public AuthDialog(TextBox email, TextBox password, Button login)
        {
            _emailBox = email;
            _passwordBox = password;
            _loginButton = login;
        }

        public void Notify(UIComponent sender, string ev) 
        {
            if (ev == "TextChanged") 
            {
                if (!_emailBox.IsEmpty() && !_passwordBox.IsEmpty())
                {
                    _loginButton.Enable();
                }
                else
                {
                    _loginButton.Disable();
                }
            }

            if (ev == "ButtonClicked") 
            {
                Console.WriteLine("AuthDialog: Успешная аутентификация! Закрываю окно...");
            }
        }
    }
}
