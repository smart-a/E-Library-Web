using System;

namespace E_Library.Models
{
    public class Bookmark
    {
        public Bookmark()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public virtual User User { set; get; }
        public virtual Book Book { set; get; }
    }
}