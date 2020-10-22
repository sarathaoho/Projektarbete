using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string model, string registrationnumber, int odometer, string fueltype) : base(model, registrationnumber, odometer, fueltype)
        {
                
        }
    }
}
