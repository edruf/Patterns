using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.UIElements
{
    internal class LinuxUIButton
    {
        public void Click() => Console.WriteLine("Linux: кнопка нажата");
        public void DoubleClick() => Console.WriteLine("Linux: кнопка нажата дважды");
    }
}
