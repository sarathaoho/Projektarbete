using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DAL
{
    public class UserDB
    {
        public List<User> Users { get; set; }

         public UserDB()
        {
            Users = new List<User>();
        }
    }
}
