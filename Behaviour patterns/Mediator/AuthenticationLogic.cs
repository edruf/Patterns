using Mediator.UIComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal class AuthenticationLogic
    {
        public void ExecuteLogin(string email)
        {
            Console.WriteLine($"[Logic] Проверяем базу данных для: {email}...");
            Console.WriteLine("[Logic] Доступ разрешен. Добро пожаловать!");
        }
    }
}
