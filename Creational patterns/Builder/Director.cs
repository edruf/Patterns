using Patterns_Builder;
using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Builder
{
    internal class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        { 
            set { _builder = value; } 
        }

        public void BuildMinimalButton() 
        {
            _builder.Reset();
            _builder.SetSizes(20, 100);
            _builder.SetText("Testing Simple Button");
        }

        public void BuildSimpleTextButton()
        {
            this._builder.Reset();
            this._builder.SetSizes(150, 40);
            this._builder.SetBackground("blue");
            this._builder.SetText("Click Me");
            this._builder.SetIcon(null);
        }

        public void BuildFullButton() 
        {
            _builder.Reset();
            _builder.SetSizes(20, 100);
            _builder.SetText("Testing Full Button");
            _builder.SetIcon("SomeIcon");
            _builder.SetBackground("SomeBackground");
        }

        public void BuildCancelButton()
        {
            this._builder.Reset();
            this._builder.SetSizes(120, 40);
            this._builder.SetBackground("red");
            this._builder.SetText("Отмена");
            this._builder.SetIcon(null);
        }
    }
}
