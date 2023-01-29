using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator.Addons
{
    internal class Tomato : IPizza
    {
        private IPizza _pizza;
        public Tomato(IPizza pizza)
        {
            this._pizza = pizza;
        }
        public int GetCost()
        {
            return _pizza.GetCost() + 30;
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + " + " + "Tomato";
        }
    }
}
