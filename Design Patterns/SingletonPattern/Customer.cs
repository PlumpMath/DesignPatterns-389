using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SingletonPattern
{
    // The Singleton Design Pattern is part of the Creational Pattern category
    // Developers can use singleton pattern for classes that use an external resource (file system, database server, or Web service) and if there multiple objects try to use that same resource at the same time
    // singleton class is easier to mock for unit testing than global or static class 
    // reference used: http://scottlilly.com/c-design-patterns-the-singleton-pattern/
    public class Customer
    {
        private readonly Logger _logger; // or private readonly StaticLogger _logger if using the static intialization technique

        public string Name { get; set; }

        public Customer(string name)
        {
            _logger = Logger.GetLogger(); // or _logger = StaticLogger.GetStaticLogger(); if using the static initialization technique

            Name = name;
        }

        public void UpdateAddress(string streetAddress, string city)
        {
            _logger.WriteMessage($"Updated the address for: {Name} at {DateTime.Now}");
        }

    }
}
