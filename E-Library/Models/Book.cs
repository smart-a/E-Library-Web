using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Library.Models
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public virtual Category Category { set; get; }
        public string BookName { set; get; }
        public virtual Course Course { set; get; }
        public virtual Subscription Subscription { set; get; }
        public string BookPath { set; get; }
    }
}