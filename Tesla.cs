using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

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
    }
}