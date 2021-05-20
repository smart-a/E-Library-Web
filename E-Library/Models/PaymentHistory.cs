using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Library.Models
{
    public class PaymentHistory
    {
        public PaymentHistory()
        {
            Id = Guid.NewGuid();
            PaidAt = DateTime.Now;
        }

        public Guid Id { set; get; }
        public virtual User User { set; get; }
        public double Amount { set; get; }
        public DateTime PaidAt { set; get; }
    }
}