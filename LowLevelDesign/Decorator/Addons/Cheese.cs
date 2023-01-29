using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator.Addons
{
    internal class Cheese : IPizza
    {
        private IPizza _pizza;
        public Cheese(IPizza pizza)
        {
            this._pizza = pizza;
        }
        public int GetCost()
        {
            return _pizza.GetCost() + 80;
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + " + " + "Cheese";
        }
    }
}
