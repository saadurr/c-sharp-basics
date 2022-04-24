using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class MultiLevel
    {
        //Base Class Vehicle
        public class Vehicle
        {
            public string owner { get; set; }
            public int registrationID { get; set; }
            public int enginePower { get; set; }
        }

        //Derived Class - First level
        public class LandVehicle : Vehicle
        {
            public int numDoors { get; set; }
            public string type { get; set; }

        }

        //Derived class - Second Level
        public class Car : LandVehicle
        {
            public string makeModel { get; set; }
        }

    }
}
