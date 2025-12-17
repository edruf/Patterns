using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class ModerationState : CurrentState
    {
        public override bool IsGood()
        {
            bool hasEnoughLength = _document.Content.Length > 50;
            bool noSpam = !_document.Content.Contains("реклама");

            return hasEnoughLength && noSpam;
        }
        public override void Publish()
        {
            if (IsGood())
            {
                Console.WriteLine("Moderation: Проверка пройдена. Публикуем!");
                _document.TransitionTo(new PublishedState());
            }
            else
            {
                Console.WriteLine("Moderation: ОШИБКА! Текст слишком короткий. Возврат в черновик.");
                _document.TransitionTo(new DraftState());
            }
        }

        public override void Cancel()
        {
            _document.TransitionTo(new DraftState());
        }
    }
}
