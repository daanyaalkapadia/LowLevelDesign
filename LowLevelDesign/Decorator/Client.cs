using LowLevelDesign.Decorator.Addons;
using LowLevelDesign.Decorator.BaseAddons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator
{
    internal class Client
    {
        public static void DecoratorMain()
        {
            IPizza pizza = new Paneer(new Cheese(new Tomato(new BBQChicken())));
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());
        }
    }
}
