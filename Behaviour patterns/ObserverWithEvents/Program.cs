using ObserverWithEvents;

class Program
{
    static void Main()
    {
        var myChannel = new YouTubeChannel("C# Today");

        var fan = new Subscriber("Алексей");
        var cocaCola = new Advertiser("Coca-Cola");

        myChannel.VideoUploaded += fan.OnVideoUploaded;
        myChannel.VideoUploaded += cocaCola.OnVideoUploaded;

        myChannel.ReleaseVideo("Урок по событиям в C#");

        myChannel.VideoUploaded -= cocaCola.OnVideoUploaded;

        Console.WriteLine("\n--- Рекламодатель прекратил сотрудничество ---");

        myChannel.ReleaseVideo("Стрим: отвечаю на вопросы");
    }
}