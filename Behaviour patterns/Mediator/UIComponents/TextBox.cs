using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.UIComponents
{
    internal class TextBox : UIComponent
    {
        public string Text { get; set; } = string.Empty;
        public TextBox(IMediator mediator) 
        {
            SetMediator(mediator);
        }

        public void SetText(string newText) 
        { 
            Text = newText;
            Console.WriteLine($"TextBox: Текст изменен на '{newText}'. Уведомляю Посредника.");
            Notify("TextChanged");
        }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Text);
        }   
    }
}
