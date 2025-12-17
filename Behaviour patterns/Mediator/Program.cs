using Mediator;
using Mediator.Mediators;
using Mediator.UIComponents;

class Program
{
    static void Main()
    {
        TextBox emailBox = new TextBox(null);
        TextBox passwordBox = new TextBox(null);
        Button loginButton = new Button(null);
        AuthenticationLogic logic = new AuthenticationLogic();

        AuthDialog mediator = new AuthDialog(emailBox, passwordBox, loginButton, logic);

        logic.Process(mediator, "init", emailBox, passwordBox, loginButton);

        Console.WriteLine("\n--- СЦЕНАРИЙ 1: Поля пустые ---");
        loginButton.Click(); 

        Console.WriteLine("\n--- СЦЕНАРИЙ 2: Заполняем только Email ---");
        emailBox.SetText("test@mail.ru");

        Console.WriteLine("\n--- СЦЕНАРИЙ 3: Заполняем Пароль ---");
        passwordBox.SetText("12345");

        Console.WriteLine("\n--- СЦЕНАРИЙ 4: Кликаем активную кнопку ---");
        loginButton.Click();
    }
}
