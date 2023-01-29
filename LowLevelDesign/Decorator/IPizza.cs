using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Decorator
{
    internal interface IPizza
    {
        public int GetCost();
        public string GetDescription();
    }
}
