using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal abstract class BaseDecorator : IButton
    {
        private IButton _button;
        public BaseDecorator(IButton button)
        {
            _button = button;
        }

        public virtual void OnClick() => _button.OnClick();

        public virtual void OnDoubleClick() => _button.OnDoubleClick();
    }
}
