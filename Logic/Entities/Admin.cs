using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class Admin : User, IUser
    {

        private Admin()
        {
            

            //"Username": "Bosse",
            //"Password": "Meckarn123",
            //"MechanicID": "BOSV670725"
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
