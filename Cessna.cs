using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

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
    }
}