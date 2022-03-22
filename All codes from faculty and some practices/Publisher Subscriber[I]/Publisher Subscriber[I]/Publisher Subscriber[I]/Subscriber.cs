using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_Subscriber_I_
{
    class Subscriber
    {
        public Subscriber(Publisher publisher)
        {
            publisher.publisherDelegate += this.Subscriber_EventHandler;
            //publisher.publisherDelegate = null;
            //publisher.publisherDelegate(null,null);
        }
        public void Subscriber_EventHandler(object o,EventArgs eventArgs)
        {
            Console.WriteLine("Notification received for event of {0} class",o.GetType());
        }
    }
}
