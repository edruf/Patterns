using Strategy;

class Program
{
    static void Main()
    {
        var saveButton = new ExportButton(new PdfExportStrategy());
        saveButton.Data = "Important report data";
        Console.WriteLine("Пользователь нажал кнопку:");
        saveButton.Click();

        Console.WriteLine("\nСмена формата на JSON...");
        saveButton.SetExportStrategy(new JsonExportStrategy());

        Console.WriteLine("Пользователь нажал ту же самую кнопку:");
        saveButton.Click();
    }
}