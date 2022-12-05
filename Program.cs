using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                MainColor = "Purple",
                MaximumOccupancy = 2,
                BatteryKWh = 20.25
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Red",
                MaximumOccupancy = 5,
                BatteryKWh = 41.72
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Green",
                MaximumOccupancy = 7,
                FuelCapacity = 150
            };
            Ram HD1500 = new Ram()
            {
                MainColor = "Blue",
                MaximumOccupancy = 5,
                FuelCapacity = 42
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            HD1500.Drive();
            Console.WriteLine();
            fxs.Turn("left");
            modelS.Turn("into some children");
            mx410.Turn("up");
            HD1500.Turn("down for what");
            Console.WriteLine();
            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            HD1500.Stop();
        }
    }
}