using Prototype;

namespace Patterns_Prototype;
class Client
{
    static void Main()
    {
        ButtonProperties originalProps = new ButtonProperties(1, "DropShadow");
        WinButton originalButton = new WinButton("Submit", "Blue", "ok", originalProps);

        Console.WriteLine("--- Создаем объекты ---");
        Console.WriteLine($"Оригинал: {originalButton}");

        WinButton deepCopy = originalButton.Copy();
        Console.WriteLine($"Копия:     {deepCopy}");

        Console.WriteLine("\n--- Модифицируем ОРИГИНАЛ... ---");
        originalButton.SetBorderWidth(5);
        //deepCopy = originalButton.Copy();

        Console.WriteLine("\n--- Итоговое состояние ---");
        Console.WriteLine($"Оригинал: {originalButton}");
        Console.WriteLine($"Копия:     {deepCopy}");
    }
}