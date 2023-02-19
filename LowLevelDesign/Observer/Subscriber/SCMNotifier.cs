namespace LowLevelDesign.Observer.Subscriber
{
    public class SCMNotifier : IOrderCancelledSubscriber, IOrderPlacedSubscriber
    {
        public SCMNotifier()
        {
            Amazon amazon = Amazon.GetInstance();
            amazon.RegisterOrderCancelled(this);
            amazon.RegisterOrderPlaced(this);
        }
        public void OrderCancelledEvent()
        {
            Console.WriteLine("Order Cancelled");
        }

        public void OrderPlaceEvent()
        {
            Console.WriteLine("Order Placed");
        }
    }
}
