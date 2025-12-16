using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subjects
{
    internal class YouTubeChannel : ISubject
    {
        public string LastVideoTitle { get; private set; }   
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer) 
        {
            _observers.Add(observer);
            Console.WriteLine("Channel: Добавлен новый подписчик.");
        }

        public void Detach(IObserver observer) 
        { 
            _observers.Remove(observer);
            Console.WriteLine("Channel: Подписчик удален.");
        }

        public void Notify() 
        {
            Console.WriteLine("Channel: Уведомление подписчиков о новом видео...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void UploadVideo(string title) 
        {
            LastVideoTitle = title;
            Console.WriteLine($"\nChannel: Загружаю новое видео '{title}'...");
            Notify();
        }   
    }
}
