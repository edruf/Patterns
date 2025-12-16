using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observers
{
    internal class Advertiser : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is YouTubeChannel channel)
            {
                Console.WriteLine($"  -> Рекламодатель реагирует: Новое видео '{channel.LastVideoTitle}' - отличная возможность для рекламы!");
            }
        }
    }
}
