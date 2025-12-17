using State;
namespace State.States;
class Program
{
    static void Main()
    {
        var doc = new Document(new DraftState());
        doc.Content = "Коротко";

        doc.Publish(); 
        doc.Publish(); 

        doc.Content = "Это очень длинный и качественный текст для публикации";
        doc.Publish(); 
        doc.Publish(); 

        doc.Publish(); 
        doc.Cancel();  
    }
}