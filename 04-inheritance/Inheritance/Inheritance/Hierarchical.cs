using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Hierarchical
    {
        //Base Class Vehicle
        public class Vehicle
        {
            public string owner { get; set; }
            public int registrationID { get; set; }
            public int enginePower { get; set; }
            public string color { get; set; }
        }

        //Derived Class - First level
        public class Car : Vehicle
        {
            public int numDoors { get; set; }
            public string type { get; set; }
            public bool isAuto { get; set; }

        }

        //Derived class - Second Level
        public class TwoDoorCar : Car
        {

        }

        //Derived class - Second Level
        public class FourDoorCar : Car
        {

        }
    }
}
