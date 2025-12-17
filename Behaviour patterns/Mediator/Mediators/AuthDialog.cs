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
        private AuthenticationLogic _logic;
        public AuthDialog(TextBox email, TextBox password, Button login, AuthenticationLogic logic)
        {
            _emailBox = email;
            _passwordBox = password;
            _loginButton = login;
            _logic = logic;

            _emailBox.SetMediator(this);
            _passwordBox.SetMediator(this);
            _loginButton.SetMediator(this);
        }

        public void Notify(UIComponent sender, string ev) 
        {
            _logic.Process(sender, ev, _emailBox, _passwordBox, _loginButton);
        }
    }
}



