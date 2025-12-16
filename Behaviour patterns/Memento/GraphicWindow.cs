using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public partial class GraphicWindow
    {
        private int _x;
        private int _y;
        private string  _color;

        public GraphicWindow(int x, int y, string color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public void Move(int x, int y) 
        { 
            _x = x;
            _y = y;
            Console.WriteLine($"Окно перемещено в: {_x}, {_y}");
        }

        public void ChangeColor(string color) 
        { 
            _color = color;
            Console.WriteLine($"Цвет окна изменен на: {_color}");
        }

        public void PrintState() 
        { 
            Console.WriteLine($"Текущее состояние окна: Позиция({_x}, {_y}), Цвет({_color})");
        }

        public IMemento Save() 
        { 
            return new WindowSnapshot(_x, _y, _color);
        }

        public void Restore(IMemento memento) 
        {
            if ((memento is WindowSnapshot snapshot)) 
            { 
                _x = snapshot.X;
                _y = snapshot.Y;
                _color = snapshot.Color;

                Console.WriteLine($"-> Состояние восстановлено: {snapshot.GetName()}");
            }
        }
    }
}
