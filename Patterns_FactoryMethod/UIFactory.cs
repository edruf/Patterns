using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_FactoryMethod
{
    internal abstract class UIFactory
    {
        protected abstract UIComponent FactoryMethod();
        public UIComponent CreateComponent()
        {
            UIComponent product = FactoryMethod();
            return product;
        }
    }
}
