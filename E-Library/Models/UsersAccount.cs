﻿using System;

namespace E_Library.Models
{
    public class UsersAccount
    {
        public UsersAccount()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
    }
}