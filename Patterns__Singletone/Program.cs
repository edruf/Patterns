using PatternsClassLibrary;
namespace Patterns__Singletone;

class Program
{
    static void Main()
    {
        WinButton button1 = WinButton.GetInstance("Кнопка 1", "green");
        Console.WriteLine("Первый доступ:");
        button1.OnClick();
        button1.OnDoubleClick();
        Console.WriteLine(button1.GetState());
        Console.WriteLine("\n ==================== \n");

        WinButton button2 = WinButton.GetInstance("Кнопка 2", "red");
        Console.WriteLine("Второй доступ (после изменения):");
        button2.OnClick();
        button2.OnDoubleClick();
        Console.WriteLine(button2.GetState());
    }
}