using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Vehicle
    {
        public string Name { get; set; }
        public string FuelOrBatteryCapacity { get; set; }
        public Color Color { get; set; }
        public int PassengerOccupancy { get; set; }

        //base methods:
        public virtual void Refuel()
        {
            Console.WriteLine($"{Name} up for refueling.");
        }

        public virtual void Drive()
        {
            Console.WriteLine($"{Name} can go {FuelOrBatteryCapacity} today.");
        }

    }
}
