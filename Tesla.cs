using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricEngine
    {
        public override void Drive()
        {
            Console.WriteLine($"{this} drives by 'ffffffff'");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this} automatically turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this} comes to a slow, controlled stop");
        }
        public double BatteryKWh { get; set; } = 25.57;
        public int CurrentChargePercentage { get; set; } = 22;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"The Tesla battery is recharged to {BatteryKWh} Kwh");
        }
    }
}