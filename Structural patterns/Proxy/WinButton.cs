using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    internal class WinButton : IButton
    {
        public void OnClick() => Console.WriteLine("Windows Button Clicked");
        public void OnDoubleClick() => Console.WriteLine("Windows Button Double Clicked");
    }
}
