using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod
{
    internal class WinFormFactory : UIFactory
    {
        protected override UIComponent FactoryMethod()
        {
            Console.WriteLine("Построили Win форму");
            return new Form { _width = 800, _height = 600 };
        }
    }

}
