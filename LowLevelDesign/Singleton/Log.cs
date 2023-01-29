using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Singleton
{
    internal sealed class Log : ILog
    {
        private static ILog? _log;
        private static readonly object _lock = new object();
        private Log()
        {

        }
        public static ILog GetInstance
        {
            get
            {
                if(_log == null)
                {
                    lock (_lock)
                    {
                        if(_log == null)
                        {
                            _log = new Log();
                        }
                    }                    
                }
                return _log;
            }
        }
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
