using LowLevelDesign.Observer.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.Observer
{
    public sealed class Amazon
    {
        static Amazon? AmazonInstance;
        static object _lock = new object();
        static List<IOrderPlacedSubscriber> orderPlacedSubscriberList = new List<IOrderPlacedSubscriber>();
        static List<IOrderCancelledSubscriber> orderCancelledSubscriberList = new List<IOrderCancelledSubscriber>();
        private Amazon()
        {

        }
        public void RegisterOrderPlaced(IOrderPlacedSubscriber orderPlacedSubscriber)
        {
            orderPlacedSubscriberList.Add(orderPlacedSubscriber);
        }
        public void UnRegisterOrderPlaced(IOrderPlacedSubscriber orderPlacedSubscriber)
        {
            orderPlacedSubscriberList.Remove(orderPlacedSubscriber);
        }
        public void RegisterOrderCancelled(IOrderCancelledSubscriber orderCancelledSubscriber)
        {
            orderCancelledSubscriberList.Add(orderCancelledSubscriber);
        }
        public void UnRegisterOrderCancelled(IOrderCancelledSubscriber orderCancelledSubscriber)
        {
            orderCancelledSubscriberList.Remove(orderCancelledSubscriber);
        }
        public void OrderPlaceEvent()
        {
            foreach(var subscriber in orderPlacedSubscriberList)
            {
                subscriber.OrderPlaceEvent();
            }
        }
        public void OrderCancelEvent()
        {
            foreach (var subscriber in orderCancelledSubscriberList)
            {
                subscriber.OrderCancelledEvent();
            }
        }
        public static Amazon GetInstance()
        {
            if(AmazonInstance == null)
            {
                lock (_lock)
                {
                    if(AmazonInstance == null)
                    {
                        AmazonInstance = new Amazon();
                    }
                }
            }
            return AmazonInstance;
        }
    }
}
