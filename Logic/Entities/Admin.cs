using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logic.Entities
{
    public class Admin : User //???
    {

        public Admin()
        {
            if (!File.Exists(@"DAL\User.json"))
            {
                var userFile = File.Create(@"Dal\User.json");
                userFile.Close();
                


            } else if (new FileInfo(@"DAL\User.json").Length == 0)
            {

            }
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
