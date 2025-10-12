using Adapter.UIElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.UIAdapters
{
    internal class IosButtonAdapter : IButton
    {
        IosUIButton _iosButton;
        public IosButtonAdapter(IosUIButton iosButton) 
        {
            iosButton = _iosButton;
        }

        public void OnClick() => _iosButton.Tap();
        public void OnDoubleClick() => _iosButton.DoubleTap();
    }
}
