using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.UIElements
{
    internal class WinButton : IButton
    {
        public void OnClick() => Console.WriteLine("Windows кнопка нажата");
        public void OnDoubleClick() => Console.WriteLine("Windows кнопка нажата дважды");
    }
}
