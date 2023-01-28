using LowLevelDesign.Factory.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Factory
{
    internal class Flutter
    {
        //System Methods
        public void SetTimeout(int seconds)
        {
            Console.WriteLine("Timeout set for " + seconds + " seconds");
        }
        //Create Factory
        public IPlatform GetPlatform(SupportedPlatform supportedPlatform)
        {
            return PlatformFactory.GetPlatform(supportedPlatform);
        }
    }
}
