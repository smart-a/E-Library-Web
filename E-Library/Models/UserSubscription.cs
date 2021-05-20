using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Library.Models
{
    public class UserSubscription
    {
        public UserSubscription()
        {
            Id = Guid.NewGuid();
            SubDate = DateTime.Now;
            SubStatus = 1;
        }

        public Guid Id { set; get; }
        public virtual User User { set; get; }
        public virtual Subscription Subscription { set; get; }
        public DateTime SubDate { set; get; }
        public int SubStatus { set; get; }
    }
}