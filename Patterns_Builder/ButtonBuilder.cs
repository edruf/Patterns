using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    internal class ButtonBuilder : IBuilder
    {
        Button _button = new Button();

        public ButtonBuilder() 
        {
            this.Reset();
        }

        public void Reset() 
        {
            this._button = new Button();
        }
        public void SetSizes(int height, int width)
        {
            _button.height = height;
            _button.width = width;
        }
        public void SetBackground(string background)
        {
            _button.background = new Background(background);
        }
        public void SetText(string text)
        {
            _button.text = new Text(text);
        }
        public void SetIcon(string icon)
        {
            _button.icon = new Icon(icon);
        }
        public Button GetButton()
        {
            var result = this._button;
            this.Reset();
            return result;
        }

    }
}
