﻿using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username {get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateJoined { get; }

        public User() { }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            DateJoined = DateTime.Now;
        }
    }
}
