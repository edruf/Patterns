using Bridge.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Buttons
{
    internal class SquareButton : Button
    {
        public SquareButton(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.RenderButton("квадратной");
        }
    }
}
