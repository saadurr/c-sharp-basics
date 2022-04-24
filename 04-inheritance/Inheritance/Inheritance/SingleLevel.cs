using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SingleLevel
    {
        //Base Class Vehicle
        public class Vehicle
        {
            public string owner { get; set; }
            public int registrationID { get; set; }
            public int enginePower { get; set; }
        }

        //Derived Class
        public class Car : Vehicle
        {
            public int numDoors { get; set; }

        }
    }
}
