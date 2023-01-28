using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Factory.Platform
{
    public interface IPlatform
    {
        public void AddButton();
        public void AddMenu();
        public void AddDropDown();
    }
}
