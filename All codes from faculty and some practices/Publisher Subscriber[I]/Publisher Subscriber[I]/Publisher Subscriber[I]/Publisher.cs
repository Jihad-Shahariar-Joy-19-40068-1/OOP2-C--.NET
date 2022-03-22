using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher_Subscriber_I_

{
    public delegate void PublisherDelegate(object o, EventArgs eventArgs);
    class Publisher
    {
        //public PublisherDelegate publisherDelegate;
        public event PublisherDelegate publisherDelegate;
        public void PublishEvent()
        {
            if(publisherDelegate!=null)
            {
                publisherDelegate(this,null);
            }
        }

    }
}
