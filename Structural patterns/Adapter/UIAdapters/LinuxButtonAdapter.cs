using System;
using System.Collections.Generic;
using System.Text;
using Adapter.UIElements;

namespace Adapter.UIAdapters
{
    internal class LinuxButtonAdapter : IButton
    {
        LinuxUIButton _linuxButton;
        public LinuxButtonAdapter(LinuxUIButton libuxButton) 
        { 
            _linuxButton = libuxButton;
        }
        public void OnClick() => _linuxButton.Click();
        public void OnDoubleClick() => _linuxButton.DoubleClick();
    }
}
