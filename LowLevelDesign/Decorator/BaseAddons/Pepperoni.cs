using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator.BaseAddons
{
    internal class Pepperoni : IPizza
    {
        public int GetCost()
        {
            return 180;
        }

        public string GetDescription()
        {
            return "Pepperoni";
        }
    }
}
