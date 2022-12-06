using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasEngine
    {
        public override void Drive()
        {
            Console.WriteLine($"{this} flies overhead 'FpFPFPFPFPFPFP''");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this} suddenly turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} comes to a stop and falls out of the sky");
        }
        public double FuelCapacity { get; set; } = 150.25;
        public double CurrentTankPercentage { get; set; }= 74.2;
        public void RefuelTank()
        {
            CurrentTankPercentage = 150.25;
            Console.WriteLine($"The Cessna performs a midair fuel transfer, returning to {FuelCapacity} gallons of fuel");
        }
    }
}