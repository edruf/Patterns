using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class PublishedState : CurrentState
    {
        public override bool IsGood()
        {
            return true;
        }
        public override void Publish()
        {
            Console.WriteLine("Published: Документ уже опубликован. Ничего не делаем.");
        }

        public override void Cancel()
        {
            Console.WriteLine("Published: Снимаю с публикации...");
            _document.TransitionTo(new DraftState());
        }
    }
}
