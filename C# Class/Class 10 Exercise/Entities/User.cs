﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public string FirstName { get; set;}

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public User(string firstName, string lastName, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} Username : {UserName}");
        }
    }
}
