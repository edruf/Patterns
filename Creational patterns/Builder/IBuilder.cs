using Patterns_Builder.ComponentsOfBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Patterns_Builder
{
    internal interface IBuilder
    {
        void Reset();

        void SetSizes(int height, int width);

        void SetBackground(string background);

        void SetText(string text);

        void SetIcon(string icon);
    }
}
