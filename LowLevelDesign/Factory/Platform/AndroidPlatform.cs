using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Factory.Platform
{
    internal class AndroidPlatform : IPlatform
    {
        public void AddButton()
        {
            Console.WriteLine("Android Button Created");
        }

        public void AddDropDown()
        {
            Console.WriteLine("Android DropDown Created");
        }

        public void AddMenu()
        {
            Console.WriteLine("Android Menu Created");
        }
    }
}
