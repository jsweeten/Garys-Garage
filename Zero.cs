using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricEngine
    {
        public override void Drive()
        {
            Console.WriteLine($"{this} drives by 'WAHHHHHH'");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this} makes a sharp {direction} turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} decelerates quickly");
        }
        public double BatteryKWh { get; set; } = 40.42;
        public int CurrentChargePercentage { get; set; } = 56;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"The battery on the Zero motorcycle is recharged to {BatteryKWh} Kwh");
        }
    }
}