using Command;
using Command.Commands;

class Program
{
    static void Main()
    {
        Editor editor = new Editor();
        CommandHistory history = new CommandHistory();  

        editor.Text = "Тестовое сообщение 1";
        Console.WriteLine($"[Start] Текст: {editor.Text}");

        ACommand copyCommand = new CopyCommand(editor);
        copyCommand.Execute();
        Console.WriteLine("-> Скопировали текст в буфер");

        Clipboard.Content = "Новый текст";

        Button pasteButton = new Button(new PasteCommand(editor), history);
        pasteButton.Click();
        Console.WriteLine($"[After Paste] Текст: {editor.Text}");

        Console.WriteLine("-> Нажали Ctrl+Z (Undo)");
        ACommand lastCommand = history.Pop();
        if (lastCommand != null)
        {
            lastCommand.Undo();
        }

        Console.WriteLine($"[After Undo] Текст: {editor.Text}");
    }
}
