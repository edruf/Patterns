using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal abstract class BaseDecorator : IButton
    {
        private IButton Button { get; }
        public BaseDecorator(IButton button)
        {
            Button = button;
        }

        public virtual void OnClick() => _button.OnClick();

        public virtual void OnDoubleClick() => _button.OnDoubleClick();
    }
}
