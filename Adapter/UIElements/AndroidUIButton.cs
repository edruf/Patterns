using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.UIElements
{
    internal class AndroidUIButton
    {
        public void Press() => Console.WriteLine("Android: кнопка нажата");
        public void DoublePress() => Console.WriteLine("Android: кнопка нажата дважды");
    }
}
