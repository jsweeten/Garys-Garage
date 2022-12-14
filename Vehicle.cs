using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {this} suddenly turns {direction}!");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The {this} comes to a screeching halt!");
        }
        public override string ToString()
        {
            return MainColor + " " + GetType().Name;
        }
    }

    public interface IElectricEngine
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
    public interface IGasEngine
    {
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }
        public void RefuelTank();
    }
}