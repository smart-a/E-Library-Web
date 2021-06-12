using System;

namespace E_Library.Models
{
    public class Course
    {
        public Course()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string CourseName { set; get; }
    }
}