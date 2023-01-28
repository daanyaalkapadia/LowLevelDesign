using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Factory.Platform
{
    internal class WindowsPlatform : IPlatform
    {
        public void AddButton()
        {
            Console.WriteLine("Windows Button Created");
        }

        public void AddDropDown()
        {
            Console.WriteLine("Windows DropDown Created");
        }

        public void AddMenu()
        {
            Console.WriteLine("Windows Menu Created");
        }
    }
}
