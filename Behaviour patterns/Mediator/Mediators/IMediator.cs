using Mediator.UIComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Mediators
{
    internal interface IMediator
    {
        void Notify(UIComponent sender, string ev);
    }
}
