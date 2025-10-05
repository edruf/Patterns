using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    internal class ButtonBuilder
    {
        bool flag = false;
        Button button;

        public void SetSizes(int height, int width)
        {
            ChekIfIsbuilt();
            button.height = height;
            button.width = width;
        }
        public void SetBackground(string background)
        {
            ChekIfIsbuilt();
            button.background = new Background(background);
        }
        public void SetText(string text)
        {
            ChekIfIsbuilt();
            button.text = new Text(text);
        }
        public void SetIcon(string icon)
        {
            ChekIfIsbuilt();
            button.icon = new Icon(icon);
        }
        public Button GetButton()
        {
            ChekIfIsbuilt();
            flag = true;
            this.button = new Button();
            return button;
        }
        private void ChekIfIsbuilt()
        {
            if (flag)
            {
                throw new InvalidOperationException("Этот билдер уже использован");
            }
        }
    }
}
