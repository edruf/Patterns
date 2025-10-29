using Patterns_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    internal class DirectorCancelButton
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
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
