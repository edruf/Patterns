using Memento;
using System;

class Program
{
    static void Main()
    {
        GraphicWindow window = new GraphicWindow(10, 10, "White");
        History history = new History(window);

        window.PrintState();

        history.Backup();
        window.Move(50, 100);

        history.Backup();
        window.ChangeColor("Red");

        window.PrintState(); 

        history.Backup();
        window.Move(200, 200);

        history.ShowHistoryList();

        Console.WriteLine("\n*** Нажимаем Ctrl+Z ***");
        history.Undo(); 
        window.PrintState();

        Console.WriteLine("\n*** Нажимаем Ctrl+Z еще раз ***");
        history.Undo(); 
        window.PrintState();
    }
}