using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SingletonPattern.StaticLogger
{
    // Logger class in Singleton design pattern with static initialization technique
    public sealed class StaticLogger
    {
        private static readonly StaticLogger _logger = new StaticLogger();

        private StaticLogger()
        {

        }

        public static StaticLogger GetStaticLogger()
        {
            return _logger;
        }

        public void WriteMessage(string message)
        {

        }
    }
}
