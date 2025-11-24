using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    internal class IProxy : IButton
    {
        private IButton _button;
        private UserRole _role;
        public IProxy(IButton button, UserRole role)
        {
            _button = button;
            _role = role;
        }

        public void OnClick()
        {
            if (_role == UserRole.Admin || _role == UserRole.User)
            {
                _button.OnClick();
            }
            else
            {
                Console.WriteLine("Access Denied: Insufficient Permissions to Click the Button");
            }
        }

        public void OnDoubleClick() 
        {
            if (_role == UserRole.Admin)
            {
                _button.OnDoubleClick();
            }
            else
            {
                Console.WriteLine("Access Denied: Insufficient Permissions to Click the Button");
            }
        }
    }
}
