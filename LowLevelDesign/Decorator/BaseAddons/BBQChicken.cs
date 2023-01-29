using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator.BaseAddons
{
    internal class BBQChicken : IPizza
    {
        public int GetCost()
        {
            return 200;
        }

        public string GetDescription()
        {
            return "BBQChicken";
        }
    }
}
