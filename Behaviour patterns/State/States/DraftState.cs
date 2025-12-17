using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class DraftState : CurrentState
    {
        public override bool IsGood() 
        {
            return !string.IsNullOrEmpty(_document.Content);
        }
        public override void Publish()
        {
            if (IsGood())
            {
                Console.WriteLine("Draft: Документ заполнен. Отправляем на модерацию.");
                _document.TransitionTo(new ModerationState());
            }
            else
            {
                Console.WriteLine("Draft: Нельзя отправить пустой черновик!");
            }
        }

        public override void Cancel()
        {
            Console.WriteLine("Draft: Черновик удален.");
        }

    }
}
