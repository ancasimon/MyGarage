using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Aircraft : Vehicle
    {
        //public string Name { get; set; }
        //public string FuelCapacity { get; set; }
        //public Color Color { get; set; }
        //public int PassengerOccupancy { get; set; }
        //Anca: deleted initial properties after I created the base class Vehicle and set it up so that the other 3 classes inherit from it!


        public override void Refuel()
        {
            Console.WriteLine($"{Name}, time to refuel!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name}, you can fly {FuelOrBatteryCapacity} today, if you want to!");
        }

        public void Land()
        {
            Console.WriteLine($"{Name}, you have used up quite a bit of fuel; time to land.");
        }

    }
}
