using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class DraftState : CurrentState
    {
        public override bool IsGood(Document document)
        {
            return !string.IsNullOrEmpty(document.Content);
        }

        public override CurrentState Publish(Document document)
        {
            if (IsGood(document))
            {
                Console.WriteLine("Draft: Текст есть. Переход к Модерации.");
                return new ModerationState(); 
            }

            Console.WriteLine("Draft: Текст пустой. Нельзя отправить.");
            return this; 
        }

        public override CurrentState Cancel(Document document)
        {
            Console.WriteLine("Draft: Очищаем черновик.");
            document.Content = ""; 
            return this;
        }

    }
}
