using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Singleton
{
    internal class Client
    {
        public static void SingletonMain()
        {
            ILog log = Log.GetInstance;
            log.Info("Application Started");
        }
    }
}
