using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWithEvents
{
    internal class VideoEventArgs : EventArgs
    {
        public string Title { get; }
        public VideoEventArgs(string title)
        {
            Title = title;
        }
    }
}
