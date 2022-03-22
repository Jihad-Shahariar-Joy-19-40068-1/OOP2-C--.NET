using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_Subscriber_I_
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);
            publisher.PublishEvent();
        }
    }
}
