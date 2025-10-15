using Bridge.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Buttons
{
    internal abstract class Button
    {
        protected IRenderer _renderer;
        public Button(IRenderer renderer) 
        {
            if (renderer == null) throw new ArgumentNullException();
            _renderer = renderer;
        }
        public abstract void Draw();
    }
}
