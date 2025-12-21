using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class PublishedState : CurrentState
    {
        public override bool IsGood(Document document) => true; 

        public override CurrentState Publish(Document document)
        {
            Console.WriteLine("Published: Уже на сайте.");
            return this;
        }

        public override CurrentState Cancel(Document document)
        {
            Console.WriteLine("Published: Снимаем с публикации...");
            return new DraftState();
        }
    }
}
