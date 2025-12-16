using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Observer.Observers
{
    internal class Subscriber : IObserver
    {
        public string Name { get; private set; }
        public Subscriber(string name)
        {
            Name = name;
        }
        public void Update(ISubject subject)
        {
            if (subject is YouTubeChannel channel)
            {
                Console.WriteLine($"  -> {Name} реагирует: Ура! Новое видео '{channel.LastVideoTitle}'");
            }
        }
    }
}
