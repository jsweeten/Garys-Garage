using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricEngine> electricVehicles = new List<IElectricEngine>() {
                fx, fxs, modelS
            };
            Console.WriteLine("");
            Console.WriteLine("Electric Vehicles");
            Console.WriteLine("");
            foreach(IElectricEngine ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(var ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(var ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasEngine> gasVehicles = new List<IGasEngine>() {
                ram, cessna150
            };

            Console.WriteLine("");
            Console.WriteLine("Gas Vehicles");
            Console.WriteLine("");
            foreach(IGasEngine gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(var gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(var gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}