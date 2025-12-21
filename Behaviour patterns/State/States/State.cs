using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace State.States
{
    internal abstract class CurrentState
    {
        public abstract bool IsGood(Document document);

        public abstract CurrentState Publish(Document document);

        public abstract CurrentState Cancel(Document document);

    }
}
