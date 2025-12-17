using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWithEvents
{
    internal class Subscriber
    {
        public string NameSubscriber { get; }
        public Subscriber(string name)
        {
            NameSubscriber = name;
        }
        public void OnVideoUploaded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"  -> [Зритель {NameSubscriber}]: О, круто! Смотрю '{e.Title}'");
        }
    }
}
