using System;

namespace E_Library.Models
{
    public class Subscription
    {
        public Subscription()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string SubscriptionName { set; get; }
        public double Amount { set; get; }
    }
}