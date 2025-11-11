using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Decorator
{
    enum UserRole
    {
        Admin,
        User,
        Guest
    }

    internal class AllowDecorator : BaseDecorator
    {
        private UserRole role;
        public AllowDecorator(IButton button, UserRole role) : base(button)
        {
            this.role = role;
        }
        public override void OnClick()
        {

            if(role == UserRole.Admin) base.OnClick();
            else Console.WriteLine("Доступ запрещен");
        }
    }    
}

