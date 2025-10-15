using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Renderers
{
    internal class MacRenderer : IRenderer
    {
        public void RenderButton(string shape) 
        {
            Console.WriteLine($"отрисовка {shape} кнопки в стиле MacOS");
        }
    }
}
