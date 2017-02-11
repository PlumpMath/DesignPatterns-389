using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SingletonPattern
{
    //Logger class using the Singleton Design Pattern (double-locking technique)
    public sealed class Logger
    {
        private static Logger _logger;

        private static readonly object _syncLock = new object();

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if(_logger == null)
            {
                lock (_syncLock)
                {
                    if(_logger == null)
                    {
                        _logger = new Logger();
                    }
                }
            }

            return _logger;
        }

        public void WriteMessage(string message)
        {

        }
    }
}
