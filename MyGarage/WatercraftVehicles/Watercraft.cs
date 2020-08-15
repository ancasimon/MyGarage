using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.WatercraftVehicles
{
    class Watercraft : Vehicle
    {
        //public string Name { get; set; }
        //public string FuelCapacity { get; set; }
        //public Color Color { get; set; }
        //public int PassengerOccupancy { get; set; }
        //Anca: deleted initial properties after I created the base class Vehicle and set it up so that the other 3 classes inherit from it!

        public override void Refuel()
        {
            Console.WriteLine($"{Name} up for refueling.");
        }

        public override void Drive()
        {
            Console.WriteLine($"{Name} can go {FuelOrBatteryCapacity} today.");
        }
    }
}
