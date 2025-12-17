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
        public Document(CurrentState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(CurrentState state) 
        {
            Console.WriteLine($"Document: Переход в состояние {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Publish() => _state.Publish();
        public void Cancel() => _state.Cancel();
        public bool CheckIfGood() => _state.IsGood();  
    }
}
