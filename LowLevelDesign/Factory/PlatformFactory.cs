using LowLevelDesign.Factory.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Factory
{
    internal class PlatformFactory
    {
        public static IPlatform GetPlatform(SupportedPlatform supportedPlatform)
        {
            switch (supportedPlatform)
            {
                case SupportedPlatform.Windows:
                    return new WindowsPlatform();
                case SupportedPlatform.Android:
                    return new AndroidPlatform();
                case SupportedPlatform.IOS:
                    return new IOSPlatform();
                default:
                    throw new NotSupportedException("Platform Not Supported");
            }
        }
    }
}