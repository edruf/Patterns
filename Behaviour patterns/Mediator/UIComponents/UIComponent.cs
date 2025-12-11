using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.UIComponents
{
    internal abstract class UIComponent
    {
        protected IMediator _mediator;
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected void Notify(string ev)
        {
            _mediator.Notify(this, ev);
        }
    }
}
