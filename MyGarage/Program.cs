using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MyGarage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly               //ANCA: Question - should this be relying on a property/conditional or is it ok if we manually identify that we are creating aircraft objects??
            // With a single `foreach`, have each vehicle Fly()
            var aircraft1 = new AircraftVehicles.BombardierChallenger350()
            {
                Name = "Bombardier Challenger 350",
                FuelOrBatteryCapacity = "350,000",
                Color = Color.Grey,
                PassengerOccupancy = 10,
                VehicleType = VehicleType.Aircraft
            };
            var aircraft2 = new AircraftVehicles.BombardierChallenger350()
            {
                Name = "Bombardier Challenger 350",
                FuelOrBatteryCapacity = "350,000",
                Color = Color.Black,
                PassengerOccupancy = 10,
                VehicleType = VehicleType.Aircraft
            };
            var aircraft3 = new AircraftVehicles.BombardierChallenger650()
            {
                Name = "Bombardier Challenger 650",
                FuelOrBatteryCapacity = "4,011 nm",
                Color = Color.Navy,
                PassengerOccupancy = 12,
                VehicleType = VehicleType.Aircraft
            };
            var aircraft4 = new AircraftVehicles.BombardierChallenger650()
            {
                Name = "Bombardier Challenger 650",
                FuelOrBatteryCapacity = "4,011 nm",
                Color = Color.White,
                PassengerOccupancy = 12,
                VehicleType = VehicleType.Aircraft
            };

            var aircraftVehicles = new List<AircraftVehicles.Aircraft>();

            aircraftVehicles.Add(aircraft1);
            aircraftVehicles.Add(aircraft2);
            aircraftVehicles.Add(aircraft3);
            aircraftVehicles.Add(aircraft4);

            foreach (var item in aircraftVehicles)
            {
                item.Fly();
            }



            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var car1NissanLeaf = new Cars.NissanLeaf()
            {
                Name = "LeafMeAlone",
                FuelOrBatteryCapacity = "200 miles",
                Color = Color.White,
                PassengerOccupancy = 4,
                VehicleType = VehicleType.Car
            };

            var car2TeslaModel3 = new Cars.TeslaModel3()
            {
                Name = "Model 3",
                FuelOrBatteryCapacity = "300 miles",
                Color = Color.Black,
                PassengerOccupancy = 4,
                VehicleType = VehicleType.Car
            };

            var cars = new List<Cars.Car>();

            cars.Add(car1NissanLeaf);
            cars.Add(car2TeslaModel3);

            foreach (var item in cars)
            {
                item.Drive();
            }



            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waverunner1 = new WatercraftVehicles.YamahaWaveRunner()
            {
                Name = "WaveBasic",
                FuelOrBatteryCapacity = "90 miles",
                Color = Color.White,
                PassengerOccupancy = 1,
                VehicleType = VehicleType.Watercraft
            };
            var waverunner2 = new WatercraftVehicles.YamahaWaveRunner()
            {
                Name = "WavePlus",
                FuelOrBatteryCapacity = "90 miles",
                Color = Color.Grey,
                PassengerOccupancy = 2,
                VehicleType = VehicleType.Watercraft
            };

            var watercraft = new List<WatercraftVehicles.Watercraft>();

            watercraft.Add(waverunner1);
            watercraft.Add(waverunner2);

            foreach (var item in watercraft)
            {
                item.Drive();

            }


        }
    }
}
