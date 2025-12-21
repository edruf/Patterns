using State;
namespace State.States;

class Program
{
    static void Main()
    {
        var doc = new Document();

        Console.WriteLine($"Состояние: {doc.GetStateName()}");

        Console.WriteLine("\n--- Попытка 1: Пустой текст ---");
        doc.Publish(); 

        Console.WriteLine("\n--- Попытка 2: Плохой текст (короткий) ---");
        doc.Content = "Спам";
        doc.Publish();  
        doc.Publish(); 

        Console.WriteLine("\n--- Попытка 3: Хороший текст ---");
        doc.Content = "Отличная статья про паттерны";
        doc.Publish(); 
        doc.Publish(); 

        Console.WriteLine($"\nИтог: {doc.GetStateName()}");
    }
}