using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Factory.Platform
{
    internal class IOSPlatform : IPlatform
    {
        public void AddButton()
        {
            Console.WriteLine("IOS Button Created");
        }

        public void AddDropDown()
        {
            Console.WriteLine("IOS DropDown Created");
        }

        public void AddMenu()
        {
            Console.WriteLine("IOS Menu Created");
        }
    }
}
