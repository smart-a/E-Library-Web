using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Library.Models
{
    public class Category
    {
        public Category()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string CategoryName { set; get; }
    }
}