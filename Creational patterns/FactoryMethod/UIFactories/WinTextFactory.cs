using Patterns_FactoryMethod.UIComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod.UIFactories
{
    internal class WinTextFactory : UIFactory
    {
        protected override UIComponent FactoryMethod()
        {
            Console.WriteLine("Построили Win текст");
            return new UIText("тест");
        }
    }
}
