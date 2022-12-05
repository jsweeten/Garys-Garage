using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
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
    }
}