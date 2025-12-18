using TemplateMethod;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- ОТКРЫВАЕМ ПРОФИЛЬ ---");
        UIWindow profile = new ProfileWindow();
        profile.Open();

        Console.WriteLine("\n--- ОТКРЫВАЕМ ОТЧЕТЫ ---");
        UIWindow reports = new ReportWindow();
        reports.Open();
    }
}