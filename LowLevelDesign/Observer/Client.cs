using LowLevelDesign.Observer.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Observer
{
    public class Client
    {
        public static void ObserverMain()
        {
            SCMNotifier scmNotifier = new SCMNotifier();
            CustomerNotifier customerNotifier = new CustomerNotifier();
            VendorNotifier vendorNotifier = new VendorNotifier();
            Amazon amazon = Amazon.GetInstance();
            amazon.OrderPlaceEvent();
        }
    }
}
