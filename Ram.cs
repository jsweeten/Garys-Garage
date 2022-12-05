using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"{this} drives by 'BAAAAAAA'");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this} veers {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} rolls to a pollutive stop");
        }
    }
}