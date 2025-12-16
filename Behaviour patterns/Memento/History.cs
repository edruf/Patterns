using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    internal class History
    {
        private Stack<IMemento> _mementos = new Stack<IMemento>();
        private GraphicWindow _window;

        public History(GraphicWindow window)
        {
            _window = window;
        }

        public void Backup() 
        {
            Console.WriteLine("\n[History] Сохранение состояния...");
            _mementos.Push(_window.Save());
        }

        public void Undo() 
        {
            if (_mementos.Count == 0) 
            {
                Console.WriteLine("[History] Истории нет!");
                return;
            }

            var memento = _mementos.Pop();  
            _window.Restore(memento);
        }

        public void ShowHistoryList() 
        {
            Console.WriteLine("\n[History] Список сохраненных состояний:");
            foreach (var memento in _mementos) 
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
