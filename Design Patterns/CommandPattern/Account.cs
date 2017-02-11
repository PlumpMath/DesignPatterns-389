using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CommandPattern
{
    // The Command Design Pattern is part of the Behavior Pattern category
    //The command pattern encapuslates a method call as an object containin necessary information
    //Command Pattern [Behavioral Pattern] contains four parts: Command; Receiver; Invoker; Client
    // In the Command Pattern, the account class serves as the receiver that contains the business objects that receive the action form the Command
    //USED FOR MESSAGE QUEUEs or LOG REQUESTS. See: http://www.dofactory.com/net/command-design-pattern
    public class Account
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public Account(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}
