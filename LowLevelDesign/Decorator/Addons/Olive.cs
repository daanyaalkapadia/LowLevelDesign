using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator.Addons
{
    internal class Olive : IPizza
    {
        private IPizza _pizza;
        public Olive(IPizza pizza)
        {
            this._pizza = pizza;
        }
        public int GetCost()
        {
            return _pizza.GetCost() + 20;
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + " + " + "Olive";
        }
    }
}
