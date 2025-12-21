using State.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    internal class Document 
    {
        private CurrentState _state;
        public string Content { get; set; } = "";

        public Document()
        {
            _state = new DraftState();
        }

        public void Publish()
        {
            _state = _state.Publish(this);
        }

        public void Cancel()
        {
            _state = _state.Cancel(this);
        }

        public string GetStateName() => _state.GetType().Name;
    }
}
