using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ObserverWithEvents
{
    internal class Advertiser
    {
        public string NameAdvertiser { get; }
        public Advertiser(string name)
        {
            NameAdvertiser = name;
        }
        public void OnVideoUploaded(object sender, VideoEventArgs e)
        {
            var channel = (YouTubeChannel)sender;
            Console.WriteLine($"  -> [Реклама {NameAdvertiser}]: Вставляем ролик в '{e.Title}' на канале {channel.NameChannel}");
        }
    }
}
