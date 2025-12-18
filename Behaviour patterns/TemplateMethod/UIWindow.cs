using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    internal abstract class UIWindow
    {
        public void Open() 
        {
            OnInitialize();
            OnFetchData();
            OnRender();
            OnLogActivity();
        }

        public void OnInitialize()
        {
            Console.WriteLine("UI: Инициализация графического движка...");
        }

        protected abstract void OnFetchData();

        protected abstract void OnRender();

        protected virtual void OnLogActivity() { }
    }
}
