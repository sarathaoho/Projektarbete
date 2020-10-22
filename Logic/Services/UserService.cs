using Logic.DAL;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Logic.Services
{
    public class UserService
    {
        private DataAccess<User> _userdb;
        private DataAccess<Mechanic> _mechanicdb;

        public UserService()
        {
            _userdb = new DataAccess<User>();
            _mechanicdb = new DataAccess<Mechanic>();
        }

        public List<Mechanic> GetMechanics()
        {
            List<Mechanic> mechanics = _mechanicdb.GetEntities();
            return mechanics;
        }
    }
}
