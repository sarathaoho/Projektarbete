using Logic.DAL;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Services
{
    public static class AdamService
    {

        public static void AddUser(UserDB user)
        {
            DataAccess<UserDB> dataAccess = new DataAccess<UserDB>();

            dataAccess.AddEntity(user);
        }
    }
}
