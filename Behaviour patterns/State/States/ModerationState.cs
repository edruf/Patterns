using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class ModerationState : CurrentState
    {
        public override bool IsGood(Document document)
        {
            return document.Content.Length > 5 && !document.Content.Contains("спам");
        }

        public override CurrentState Publish(Document document)
        {
            if (IsGood(document))
            {
                Console.WriteLine("Moderation: Проверка пройдена. Публикуем.");
                return new PublishedState();
            }

            Console.WriteLine("Moderation: ОШИБКА (мало текста или спам). Возврат в Черновик.");
            return new DraftState();
        }

        public override CurrentState Cancel(Document document)
        {
            Console.WriteLine("Moderation: Отклонено вручную.");
            return new DraftState();
        }
    }
}
