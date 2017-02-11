using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.DataMapperPattern
{

    // Data Mapper design patter converts between business objects (classes) and database records
    // Reference from: http://scottlilly.com/c-design-patterns-data-mapper-and-active-record/ 
    // Customer class below is the business object
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPremiumMember { get; set; }

        public Customer(int id, string name, bool isPremiumMember)
        {
            Id = id;
            Name = name;
            IsPremiumMember = isPremiumMember;
        }
    }
}
