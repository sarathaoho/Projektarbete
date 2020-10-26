using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DAL
{
    public class MechanicDB
    {
        public List<Mechanic> Mechanics { get; set; }
        public MechanicDB()
        {
            Mechanics = new List<Mechanic>();
        }
    }
}

