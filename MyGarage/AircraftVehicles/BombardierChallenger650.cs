using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.AircraftVehicles
{
    class BombardierChallenger650 : Aircraft
    {
        public bool HasGEEngine { get; set; } = true;

        public int CabinHeight { get; set; } = 6;

        public override void Fly()
        {
            Console.WriteLine($"{Name}! Cabin height of {CabinHeight} feet! You just took it up a notch!");
        }
    }
}
