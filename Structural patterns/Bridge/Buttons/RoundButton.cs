using Bridge.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Buttons
{
    internal class RoundButton : Button
    {
        public RoundButton(IRenderer renderer) : base(renderer) { }
        public override void Draw()
        {
            _renderer.RenderButton("круглой");
        }
    }
}
