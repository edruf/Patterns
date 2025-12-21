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
        private AuthenticationLogic _logic = new AuthenticationLogic();
        public AuthDialog()
        {
            _emailBox = new TextBox(this);
            _passwordBox = new TextBox(this);
            _loginButton = new Button(this);    
        
        }

        public TextBox Email => _emailBox;
        public TextBox Pass => _passwordBox;
        public Button LoginBtn => _loginButton;

        public void Notify(UIComponent sender, string ev) 
        {
            if (ev == "TextChanged")
            {
                _loginButton.RefreshState(_emailBox.Text, _passwordBox.Text);
            }

            if (ev == "ButtonClicked")
            {
                _logic.ExecuteLogin(_emailBox.Text);
            }
        }
    }
}



