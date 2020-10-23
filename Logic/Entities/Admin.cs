using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logic.Entities
{
    public class Admin : User, IUser
    {

<<<<<<< HEAD
        public Admin()
        {
            if (!File.Exists(@"DAL\User.json"))
            {
                var userFile = File.Create(@"Dal\User.json");
                userFile.Close();
                


            } else if (new FileInfo(@"DAL\User.json").Length == 0)
            {

            }
=======
        private Admin()
        {
            

            //"Username": "Bosse",
            //"Password": "Meckarn123",
            //"MechanicID": "BOSV670725"
>>>>>>> 1baad9a214eec5659dbc8192e1a630f5602f9194
        }

        public void AddMechanic()
        {

        }


        public void ChangeMechanic()
        {

        }

        public void AddMechanicSkill()
        {

        }

        public void RemoveMechanicSkill()
        {

        }

        public void AddUser() //Måste kopplas till en mekaniker.
        {

        }

        public void RemoveUser()
        {

        }

        public void AddErrand()
        {

        }

    }
}
