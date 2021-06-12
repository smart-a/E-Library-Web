using System;

namespace E_Library.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
            Wallet = 0;
        }

        //[Key]
        public Guid Id { set; get; }
        public string StudentNumber { set; get; }
        public string Fullname { set; get; }
        public string Gender { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public int Level { set; get; }
        public double Wallet { set; get; }
        public UserEnum UserType { set; get; }
        public string Password { set; get; }


        public enum UserEnum
        {
            Student,
            Member
        }
    }

    public class UserDisplay
    {
        public Guid Id { set; get; }
        public string StudentNumber { set; get; }
        public string Fullname { set; get; }
        public string Gender { set; get; }
        public int Level { set; get; }
    }
}