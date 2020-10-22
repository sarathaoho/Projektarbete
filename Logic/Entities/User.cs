using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string MechanicID { get; set; }

        public User(Mechanic mechanic)
        {
            MechanicID = mechanic.MechanicID;
        }

       
        
    }
}
