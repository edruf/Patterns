using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ObserverWithEvents
{
    internal class YouTubeChannel
    {
        public string NameChannel { get; }  
        public event EventHandler<VideoEventArgs> VideoUploaded;
        
        public YouTubeChannel(string name) 
        { 
            NameChannel = name;
        }

        public void ReleaseVideo(string title) 
        {
            Console.WriteLine($"\n[КАНАЛ {NameChannel}]: Выпускаем новое видео — '{title}'!");
            VideoUploaded?.Invoke(this, new VideoEventArgs(title));
        }
    }
}
