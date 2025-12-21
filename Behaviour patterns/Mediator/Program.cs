using Mediator;
using Mediator.Mediators;
using Mediator.UIComponents;

class Program
{
    static void Main()
    {
        AuthDialog dialog = new AuthDialog();

        Console.WriteLine("\n--- СЦЕНАРИЙ 1: Поля пустые ---");
        dialog.LoginBtn.Click();

        Console.WriteLine("\n--- СЦЕНАРИЙ 2: Заполняем только Email ---");
        dialog.Email.SetText("test@mail.ru");
        dialog.LoginBtn.Click();

        Console.WriteLine("\n--- СЦЕНАРИЙ 3: Заполняем Пароль ---");
        dialog.Pass.SetText("12345");

        Console.WriteLine("\n--- СЦЕНАРИЙ 4: Кликаем активную кнопку ---");
        dialog.LoginBtn.Click();
    }
}