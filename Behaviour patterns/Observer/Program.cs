using Observer;

class Program
{
    static void Main()
    {
        var channel = new YouTubeChannel();

        var user1 = new Subscriber("Иван");
        var user2 = new Subscriber("Мария");
        var adsBot = new Advertiser();

        channel.Attach(user1);
        channel.Attach(user2);
        channel.Attach(adsBot);

        channel.UploadVideo("Observer Pattern in C#");

        channel.Detach(user2); 
        channel.UploadVideo("Как выучить C++ за час");
    }
}