using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;// Used in this Facade scenario
using System.Net.Mail; // Used in this Facade scenario

namespace Design_Patterns.FacadePattern
{
    // The Facade design pattern is part of the Structural Pattern category
    // Facade used when creating multiple objects, such as multiple objects for email addresses in an email message object and an email server objects 

    // Facade also used to hide the implementation of third-party libraries and updated libraries that can break existing code

    // Facades handle changes easier

    // reference used: http://scottlilly.com/c-design-patterns-the-wrapperfacade-pattern/
    public class EmailFacade
    {
        public void EmailObject()
        {
            EmailCreator.CreateEmailFrom("from@domain.com")
                .To("to@domain.com", "to2@domain.com", "to3@domain.com")
                .CC("cc@domain.com", "cc2@domain.com")
                .BCC("bcc@domain.com", "bcc2@domain.com", "bcc3@domain.com", "bcc4@domain.com")
                .WithSubject("Email subject")
                .WithBody("Email body here")
                .Send();
        }
    }
}
