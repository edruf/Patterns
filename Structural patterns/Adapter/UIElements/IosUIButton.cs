using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.UIElements
{
    internal class IosUIButton
    {
        public void Tap() => Console.WriteLine("iOS: кнопка нажата");
        public void DoubleTap() => Console.WriteLine("iOS: кнопка нажата дважды");
    }
}
