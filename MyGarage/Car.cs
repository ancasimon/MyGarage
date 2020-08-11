using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MyGarage
{
    class Car : Vehicle
    {
        //public string Name { get; set; }
        //public string FuelOrBatteryCapacity { get; set; }
        //public Color Color { get; set; }
        //public int PassengerOccupancy { get; set; }
        //Anca: deleted initial properties after I created the base class Vehicle and set it up so that the other 3 classes inherit from it!



        public override void Refuel()
        {
            Console.WriteLine($"Time to refuel, {PassengerOccupancy}-passenger {Name}!");
        }

        public override void Drive()
        {
            Console.WriteLine($"Where are you driving to, {Name}?");
        }

        public void Brake()
        {
            Console.WriteLine("Wow, that was pretty fast; let's slow down!");
        }


    }
}
