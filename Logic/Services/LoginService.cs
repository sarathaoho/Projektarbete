using Logic.DAL;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Services
{
    public class LoginService
    {
        private DataAccess<User> _db;

        public LoginService()
        { 
            _db = new DataAccess<User>();
            
        }

        public bool Login(string username, string password)
        {

            List<User> users = _db.GetEntities();

            return users.Exists(user => user.Username.Equals(username) && user.Password.Equals(password));
        }
    }
}
