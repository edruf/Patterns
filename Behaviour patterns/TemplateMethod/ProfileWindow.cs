using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    internal class ProfileWindow : UIWindow
    {
        protected override void OnFetchData()
        {
            Console.WriteLine("API: Загружаем аватар и имя пользователя...");
        }

        protected override void OnRender()
        {
            Console.WriteLine("Render: Рисуем карточку пользователя.");
        }

        protected override void OnLogActivity()
        {
            Console.WriteLine("Log: Пользователь зашел в свой профиль.");
        }
    }
}
