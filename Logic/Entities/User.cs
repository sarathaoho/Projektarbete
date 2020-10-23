using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserID { get; set; }

<<<<<<< HEAD

=======
        public User(Mechanic mechanic)
        {
            UserID = mechanic.MechanicID;
        }

        
        
        

       
        
>>>>>>> 1baad9a214eec5659dbc8192e1a630f5602f9194
    }
}
