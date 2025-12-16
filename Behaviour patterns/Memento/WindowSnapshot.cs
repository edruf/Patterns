using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Memento
{
    public partial class GraphicWindow 
    { 
        private  class WindowSnapshot : IMemento
        {
            public int X { get; }
            public int Y { get; }
            public string Color { get; }
            private DateTime _date;

            public WindowSnapshot(int x, int y, string color)
            {
                X = x;
                Y = y;
                _date = DateTime.Now;
                Color = color;
            }

            public string GetName()
            {
                return $"{_date:HH:mm:ss} — Окно '{Color}' в точке ({X}, {Y})";
            }

            public DateTime GetDate()
            {
                return _date;
            }
        }
    }
}
