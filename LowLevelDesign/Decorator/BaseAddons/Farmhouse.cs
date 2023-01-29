using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator.BaseAddons
{
    internal class Farmhouse : IPizza
    {
        //Empty constructor because of base addons
        public Farmhouse()
        {

        }
        public int GetCost()
        {
            return 150;
        }

        public string GetDescription()
        {
            return "Farmhouse";
        }
    }
}
