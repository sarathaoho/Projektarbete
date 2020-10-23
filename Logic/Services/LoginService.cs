using Logic.DAL;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logic.Services
{
    public class LoginService
    {
        private DataAccess<User> _userdb;
        private DataAccess<Mechanic> _mechanicdb;

        public LoginService()
        { 
            _userdb = new DataAccess<User>();
            _mechanicdb = new DataAccess<Mechanic>();
            var path = @"DAL\User.json";
            if (!File.Exists(path))
            {
                var userFile = File.Create(path);
                userFile.Close();
                var users = new List<User>() { AddDefaultUser() };
                _userdb.AddEntity(users);

            } else if (new FileInfo(path).Length == 0)
            {
                var users = new List<User>() { AddDefaultUser() };
                _userdb.AddEntity(users);
            }

            
        }

        public bool Login(string username, string password)
        {

            List<User> users = _userdb.GetEntities();

            return users.Exists(user => user.Username.Equals(username) && user.Password.Equals(password));
        }

        private User AddDefaultUser()
        {
            var mechanic = new Mechanic("Bosse", "Andersson", new DateTime(1967, 05, 23));
            var mechanics = new List<Mechanic>() { mechanic };
            _mechanicdb.AddEntity(mechanics);
           

            var user = new User();
            user.Username = "Bosse";
            user.Password = "Meckarn123";
            user.UserID = mechanic.MechanicID;

            return user;
        }
    }
}
