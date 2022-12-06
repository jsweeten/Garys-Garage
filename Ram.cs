using System;

namespace Garage
{
    public class Ram : Vehicle, IGasEngine
    {
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
        public double FuelCapacity { get; set; } = 42.50;
        public double CurrentTankPercentage { get; set; }= 7.92;
        public void RefuelTank()
        {
            CurrentTankPercentage = 42.50;
            Console.WriteLine($"The Dodge Ram spends $100 on fossil fuel and returns to {FuelCapacity} gallons.");
        }
    }
}