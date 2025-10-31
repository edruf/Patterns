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
    }
}