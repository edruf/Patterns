using System;
using Adapter.UIElements;
using Adapter.UIAdapters;
using Adapter;
internal class Program 
{   public  static void Main()
    {
        // Обычная кнопка
        IButton winButton = new WinButton();
        winButton.OnClick();
        winButton.OnDoubleClick();

        // Адаптированная Android-кнопка    
        IButton androidButton = new AndroidButtonAdapter(new AndroidUIButton());
        androidButton.OnClick();
        androidButton.OnDoubleClick();

        //Адаптированная iOS-кнопка
        IButton iosButton = new IosButtonAdapter(new IosUIButton());
        iosButton.OnClick();
        iosButton.OnDoubleClick();

        //Адаптированная Linux-кнопка
        IButton linuxButton = new LinuxButtonAdapter(new LinuxUIButton());
        linuxButton.OnClick();
        linuxButton.OnDoubleClick();
    }
}