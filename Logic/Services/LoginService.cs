using Logic.DAL;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Logic.Services
{
    public class LoginService
    {
        private DataAccess<Admin> _admindb;
        private DataAccess<User> _userdb;
        private DataAccess<Mechanic> _mechanicdb;


        public LoginService()
        {
            _userdb = new DataAccess<User>();
            _mechanicdb = new DataAccess<Mechanic>();
            _admindb = new DataAccess<Admin>();
            var path = @"DAL\Admin.json";

            if (!File.Exists(path))
            {
                var adminFile = File.Create(path);
                adminFile.Close();
                var admins = new List<Admin>() { AddDefaultAdmin() };
                _admindb.AddEntity(admins);

            }
            else if (new FileInfo(path).Length == 0)
            {
                var admins = new List<Admin>() { AddDefaultAdmin() };
                _admindb.AddEntity(admins);
            }


        }

        public bool Login(string username, string password)
        {


            if (File.Exists(@"DAL\User.json"))
            {
                var users = _userdb.GetEntities();

                if (users.Exists(user => user.Username.Equals(username) && user.Password.Equals(password))){
                    return true;
                }
            }

            var admins = _admindb.GetEntities();
            if (admins.Exists(admin => admin.Username.Equals(username) && admin.Password.Equals(password)))
            {
                return true;
            }

            return false;
        }

        private Admin AddDefaultAdmin()
        {
            var mechanic = new Mechanic("Bosse", "Andersson", new DateTime(1967, 05, 23));
            var mechanics = new List<Mechanic>() { mechanic };
            _mechanicdb.AddEntity(mechanics);


            var admin = new Admin();
            admin.Username = "Bosse";
            admin.Password = "Meckarn123";
            admin.UserID = mechanic.MechanicID;

            return admin;
        }
    }
}
