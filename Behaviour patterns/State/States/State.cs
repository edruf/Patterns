using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace State.States
{
    internal abstract class CurrentState
    {
        protected Document _document;
        public void SetContext(Document document) 
        { 
            _document = document;
        }
        public abstract bool IsGood();

        public abstract void Publish();

        public abstract void Cancel();

    }
}
