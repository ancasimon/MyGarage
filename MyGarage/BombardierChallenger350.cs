using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class BombardierChallenger350 : Aircraft
    {
        public bool HasHoneywellEngine { get; set; } = true;

        public int CabinLength { get; set; } = 25;

        public override void Fly()
        {
            Console.WriteLine($"{Name}! Cabin length of {CabinLength} feet! Now you're flying in style!");
        }
    }
}
