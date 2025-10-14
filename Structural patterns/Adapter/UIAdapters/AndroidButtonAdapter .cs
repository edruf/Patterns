using Adapter.UIElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.UIAdapters
{
    internal class AndroidButtonAdapter : IButton
    {
        AndroidUIButton _androidButton;
        public AndroidButtonAdapter(AndroidUIButton androidButton)
        {
            this._androidButton = androidButton;
        }
        public void OnClick() => _androidButton.Press();
        public void OnDoubleClick() => _androidButton.DoublePress();
    }
}
