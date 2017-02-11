using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Design_Patterns.FacadePattern
{
    //The EmailCreator class needs this interface to handle building all of the ojbects needed to send an email out
    public interface IEmailFluentInterface
    {
        IEmailFluentInterface From(string fromAddress);
        IEmailFluentInterface To(params string[] toAddresses);
        IEmailFluentInterface CC(params string[] ccAddresses);
        IEmailFluentInterface BCC(params string[] bccAddresses);
        IEmailFluentInterface WithSubject(string subject);
        IEmailFluentInterface WithBody(string body);
        void Send();
    }
}
